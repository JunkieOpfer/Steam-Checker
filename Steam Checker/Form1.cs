#region CREDITS
/*
 * github.com/JunkieOpfer
 * if u use it give credits
*/
#endregion

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_Checker
{
    public partial class Form1 : Form
    {
        private static Accounts accounts = new Accounts();
        private bool isChecking = false;

        private delegate void UpdateListViewDelegate(string text);
        private readonly object listViewLock = new object();

        public Form1()
        {
            InitializeComponent();
        }

        #region load
        private void Form1_Load(object sender, EventArgs e)
        {
            open_website_at_start.Checked = Properties.Settings.Default.OpenCredits;

            if(open_website_at_start.Checked == true)
            {
                Process.Start("https://github.com/JunkieOpfer");
            }
            else
            {

            }
        }
        #endregion
        private async void btnLoadAccounts_Click(object sender, EventArgs e)
        {
            if (isChecking)
                return;

            isChecking = true;

            string content = "";
            if (!File.Exists("Accounts.txt"))
            {
                MessageBox.Show("Put your accounts in Accounts.txt. I'll open this file for you.", "Information", MessageBoxButtons.OK);
                File.WriteAllText("Accounts.txt", "");
                Process.Start("notepad.exe", "Accounts.txt");
                isChecking = false;
                return;
            }
            else
            {
                content = File.ReadAllText("Accounts.txt");
                if (String.IsNullOrEmpty(content) || String.IsNullOrWhiteSpace(content))
                {
                    MessageBox.Show("Put your accounts in Accounts.txt. I'll open this file for you.", "Information", MessageBoxButtons.OK);
                    Process.Start("notepad.exe", "Accounts.txt");
                    isChecking = false;
                    return;
                }
            }

            List<string> combos = new List<string>(File.ReadAllText("Accounts.txt").Split(Environment.NewLine.ToCharArray()));
            combos = combos.Distinct().ToList();
            combos.RemoveAll(i => String.IsNullOrEmpty(i) || String.IsNullOrWhiteSpace(i) || !i.Contains(":"));
            if (combos.Count == 0)
            {
                MessageBox.Show("Put your accounts (as combos) in Accounts.txt. I'll open this file for you.", "Information", MessageBoxButtons.OK);
                Process.Start("notepad.exe", "Accounts.txt");
                isChecking = false;
                return;
            }

            await Task.Run(() =>
            {
                Checker checker = new Checker();
                checker.OnAccountChecked += Checker_OnAccountChecked;
                checker.OnCheckerDone += Checker_OnCheckerDone;
                checker.CheckAccounts(ref combos);
            });

            isChecking = false;
        }

        private async void Checker_OnCheckerDone(TimeSpan time)
        {
            string validContent = "";
            string invalidContent = "";
            string steamGuardProtectedContent = "";

            await Task.Run(() =>
            {
                foreach (var i in accounts.Vaild)
                {
                    string accountText = $"{i.Username}:{i.Password}"; // (id) :{i.Id}
                    validContent += GetAccountInfo(i);                 
                }

                foreach (var i in accounts.InVaild)
                {
                    string accountText = $"{i.Username}:{i.Password}";
                    invalidContent += GetAccountInfo(i);
                }

                foreach (var i in accounts.SteamGuardProtected)
                {
                    string accountText = $"{i.Username}:{i.Password}"; // (id) :{i.Id}
                    steamGuardProtectedContent += GetAccountInfo(i);
                }
            });

            MessageBox.Show($"Invalid Accounts: {accounts.InVaild.Count} | Valid Accounts: {accounts.Vaild.Count} | Protected Accounts: {accounts.SteamGuardProtected.Count}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

          if (!Directory.Exists("Output"))
                Directory.CreateDirectory("Output");

            File.WriteAllText("Output\\Valid.txt", validContent);
            File.WriteAllText("Output\\Invalid.txt", invalidContent);
            File.WriteAllText("Output\\Protected.txt", steamGuardProtectedContent);
        }

        private string GetAccountInfo(Account account)
        {
            //return $"\n\n~~~~~~~~~~~~~~~~~~~~~\n" +
            //       $"\nUsername: {account.Username}" +
            //       $"\nPassword: {account.Password}" +

            return $"\n\n=====Steam Checker - github.com/JunkieOpfer=====\n" +
                   $"{account.Username}:{account.Password}" +
                   (account.Type == Status.Success ? $"\nSteamID: {account.Id}" : "");
        }

        private void UpdateListViewSafe(System.Windows.Forms.ListView listView, string text)
        {
            if (listView.InvokeRequired)
            {
                listView.Invoke(new Action(() => UpdateListViewSafe(listView, text)));
            }
            else
            {
                bool exists = listView.Items.Cast<ListViewItem>().Any(item => item.Text == text);
                if (!exists)
                {
                    ListViewItem item = new ListViewItem(text);
                    listView.Items.Add(item);
                }
            }
        }

        private void Checker_OnAccountChecked(int Index, int Count, Account Account)
        {
            UpdateListViewDelegate updateListViewDelegate = null;

            switch (Account.Type)
            {
                case Status.Fail:
                    updateListViewDelegate = text =>
                    {
                        if (!listViewInvalidAccounts.Items.Cast<ListViewItem>().Any(item => item.Text == text))
                        {
                            accounts.InVaild.Add(Account);

                            ListViewItem item = new ListViewItem(text);
                            listViewInvalidAccounts.Items.Add(item);
                        }
                    };
                    break;

                case Status.Success:
                    updateListViewDelegate = text =>
                    {
                        if (!listViewValidAccounts.Items.Cast<ListViewItem>().Any(item => item.Text == text))
                        {
                            accounts.Vaild.Add(Account);

                            ListViewItem item = new ListViewItem(text);
                            listViewValidAccounts.Items.Add(item);
                        }
                    };
                    break;

                case Status.SteamGuardProtected:
                    updateListViewDelegate = text =>
                    {
                        if (!listViewProtectedAccounts.Items.Cast<ListViewItem>().Any(item => item.Text == text))
                        {
                            accounts.SteamGuardProtected.Add(Account);

                            ListViewItem item = new ListViewItem(text);
                            listViewProtectedAccounts.Items.Add(item);
                        }
                    };
                    break;

                default:
                    return;
            }

            lblCheckedCount.Invoke(new Action(() =>
            {
                lblCheckedCount.Text = $"Checked {Index}/{Count}";
            }));

            if (updateListViewDelegate != null)
            {
                listViewValidAccounts.Invoke(updateListViewDelegate, $"{Account.Username}:{Account.Password}"); //(accountid) :{Account.Id}
            }

            Application.DoEvents();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
           
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Überprüfen, ob eine Gridline ausgewählt ist
            if (listViewValidAccounts.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Select a Account.", "Information");
                return;
            }

            // Kopieren der ausgewählten Gridline
            string copiedText = string.Empty;
            foreach (ListViewItem selectedItem in listViewValidAccounts.SelectedItems)
            {
                for (int i = 0; i < selectedItem.SubItems.Count; i++)
                {
                    copiedText += selectedItem.SubItems[i].Text;
                    if (i < selectedItem.SubItems.Count - 1)
                        copiedText += "\t"; // Trennzeichen (z. B. Tabulator) zwischen Spalten
                }
                copiedText += Environment.NewLine; // Neue Zeile am Ende jeder Gridline
            }

            // In die Zwischenablage kopieren
            Clipboard.SetText(copiedText);

            MessageBox.Show("Copied!", "Succesful");
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Überprüfen, ob eine Gridline ausgewählt ist
            if (listViewValidAccounts.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Select a Account.", "Information");
                return;
            }

            // Kopieren der ausgewählten Gridline
            string copiedText = string.Empty;
            foreach (ListViewItem selectedItem in listViewValidAccounts.SelectedItems)
            {
                for (int i = 0; i < selectedItem.SubItems.Count; i++)
                {
                    copiedText += selectedItem.SubItems[i].Text;
                    if (i < selectedItem.SubItems.Count - 1)
                        copiedText += "\t"; // Trennzeichen (z. B. Tabulator) zwischen Spalten
                }
                copiedText += Environment.NewLine; // Neue Zeile am Ende jeder Gridline
            }

            // In die Zwischenablage kopieren
            Clipboard.SetText(copiedText);

            MessageBox.Show("Copied!", "Succesful");
        }

        private void btnAddAccounts_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "Accounts.txt");
        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {

        }

        private void copyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (listViewInvalidAccounts.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Select a Account.", "Information");
                return;
            }

            string copiedText = string.Empty;
            foreach (ListViewItem selectedItem in listViewInvalidAccounts.SelectedItems)
            {
                for (int i = 0; i < selectedItem.SubItems.Count; i++)
                {
                    copiedText += selectedItem.SubItems[i].Text;
                    if (i < selectedItem.SubItems.Count - 1)
                        copiedText += "\t";
                }
                copiedText += Environment.NewLine;
            }

            Clipboard.SetText(copiedText);

            MessageBox.Show("Copied!", "Succesful");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.OpenCredits = open_website_at_start.Checked;
            Properties.Settings.Default.Save();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string exeFolderPath = Application.StartupPath;
            string path = System.IO.Path.Combine(exeFolderPath, "Output");

            Process.Start("explorer.exe", path);
        }
    }
}
