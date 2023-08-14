namespace Steam_Checker
{
    partial class ProxyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProxyForm));
            this.richInput = new System.Windows.Forms.RichTextBox();
            this.radio_http = new System.Windows.Forms.RadioButton();
            this.radio_https = new System.Windows.Forms.RadioButton();
            this.radio_socks5 = new System.Windows.Forms.RadioButton();
            this.radio_socks4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richOuput = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richInput
            // 
            this.richInput.Location = new System.Drawing.Point(12, 25);
            this.richInput.Name = "richInput";
            this.richInput.Size = new System.Drawing.Size(300, 175);
            this.richInput.TabIndex = 0;
            this.richInput.Text = "";
            // 
            // radio_http
            // 
            this.radio_http.AutoSize = true;
            this.radio_http.Location = new System.Drawing.Point(212, 45);
            this.radio_http.Name = "radio_http";
            this.radio_http.Size = new System.Drawing.Size(54, 17);
            this.radio_http.TabIndex = 1;
            this.radio_http.TabStop = true;
            this.radio_http.Text = "HTTP";
            this.radio_http.UseVisualStyleBackColor = true;
            // 
            // radio_https
            // 
            this.radio_https.AutoSize = true;
            this.radio_https.Location = new System.Drawing.Point(21, 45);
            this.radio_https.Name = "radio_https";
            this.radio_https.Size = new System.Drawing.Size(61, 17);
            this.radio_https.TabIndex = 2;
            this.radio_https.TabStop = true;
            this.radio_https.Text = "HTTPS";
            this.radio_https.UseVisualStyleBackColor = true;
            // 
            // radio_socks5
            // 
            this.radio_socks5.AutoSize = true;
            this.radio_socks5.Location = new System.Drawing.Point(529, 45);
            this.radio_socks5.Name = "radio_socks5";
            this.radio_socks5.Size = new System.Drawing.Size(61, 17);
            this.radio_socks5.TabIndex = 3;
            this.radio_socks5.TabStop = true;
            this.radio_socks5.Text = "Socks5";
            this.radio_socks5.UseVisualStyleBackColor = true;
            // 
            // radio_socks4
            // 
            this.radio_socks4.AutoSize = true;
            this.radio_socks4.Location = new System.Drawing.Point(308, 45);
            this.radio_socks4.Name = "radio_socks4";
            this.radio_socks4.Size = new System.Drawing.Size(61, 17);
            this.radio_socks4.TabIndex = 4;
            this.radio_socks4.TabStop = true;
            this.radio_socks4.Text = "Socks4";
            this.radio_socks4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_socks5);
            this.groupBox1.Controls.Add(this.radio_socks4);
            this.groupBox1.Controls.Add(this.radio_http);
            this.groupBox1.Controls.Add(this.radio_https);
            this.groupBox1.Location = new System.Drawing.Point(12, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proxy Type";
            // 
            // richOuput
            // 
            this.richOuput.Location = new System.Drawing.Point(320, 25);
            this.richOuput.Name = "richOuput";
            this.richOuput.Size = new System.Drawing.Size(300, 175);
            this.richOuput.TabIndex = 6;
            this.richOuput.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(488, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Format Proxies";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Output:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Add/Edit Proxies";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProxyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 342);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richOuput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProxyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam Checker (Proxy Version) | Proxy Manager";
            this.Load += new System.EventHandler(this.ProxyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richInput;
        private System.Windows.Forms.RadioButton radio_http;
        private System.Windows.Forms.RadioButton radio_https;
        private System.Windows.Forms.RadioButton radio_socks5;
        private System.Windows.Forms.RadioButton radio_socks4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richOuput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}