using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_Checker
{
    public partial class ProxyForm : Form
    {
        public ProxyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string prefix = string.Empty;

            if (radio_http.Checked)
                prefix = "http://";
            else if (radio_https.Checked)
                prefix = "https://";
            else if (radio_socks4.Checked)
                prefix = "socks4://";
            else if (radio_socks5.Checked)
                prefix = "socks5://";

            string[] lines = richInput.Text.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            richOuput.Clear();

            foreach (string line in lines)
            {
                richOuput.AppendText(prefix + line + Environment.NewLine);
            }
        }

        private void ProxyForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = "proxies.txt";
            if (!File.Exists(fileName))
            {
                MessageBox.Show($"I'll create the {fileName} for you. And open it!");
                File.Create(fileName).Close();
            }

            Process.Start("notepad.exe", fileName);

        }
    }
}
