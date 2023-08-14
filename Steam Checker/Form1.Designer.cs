namespace Steam_Checker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewValidAccounts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewInvalidAccounts = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLoadAccounts = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listViewProtectedAccounts = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCheckedCount = new System.Windows.Forms.Label();
            this.btnAddAccounts = new System.Windows.Forms.Button();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.open_website_at_start = new System.Windows.Forms.CheckBox();
            this.show_proxy_manager = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proxyManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewValidAccounts);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 399);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valid Accounts";
            // 
            // listViewValidAccounts
            // 
            this.listViewValidAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewValidAccounts.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewValidAccounts.FullRowSelect = true;
            this.listViewValidAccounts.GridLines = true;
            this.listViewValidAccounts.HideSelection = false;
            this.listViewValidAccounts.Location = new System.Drawing.Point(7, 19);
            this.listViewValidAccounts.Name = "listViewValidAccounts";
            this.listViewValidAccounts.Size = new System.Drawing.Size(267, 374);
            this.listViewValidAccounts.TabIndex = 5;
            this.listViewValidAccounts.UseCompatibleStateImageBehavior = false;
            this.listViewValidAccounts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Valid Accounts";
            this.columnHeader1.Width = 263;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewInvalidAccounts);
            this.groupBox2.Location = new System.Drawing.Point(300, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 399);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invalid Accounts";
            // 
            // listViewInvalidAccounts
            // 
            this.listViewInvalidAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewInvalidAccounts.FullRowSelect = true;
            this.listViewInvalidAccounts.GridLines = true;
            this.listViewInvalidAccounts.HideSelection = false;
            this.listViewInvalidAccounts.Location = new System.Drawing.Point(17, 19);
            this.listViewInvalidAccounts.Name = "listViewInvalidAccounts";
            this.listViewInvalidAccounts.Size = new System.Drawing.Size(267, 374);
            this.listViewInvalidAccounts.TabIndex = 6;
            this.listViewInvalidAccounts.UseCompatibleStateImageBehavior = false;
            this.listViewInvalidAccounts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Invalid Accounts";
            this.columnHeader2.Width = 263;
            // 
            // btnLoadAccounts
            // 
            this.btnLoadAccounts.Location = new System.Drawing.Point(19, 417);
            this.btnLoadAccounts.Name = "btnLoadAccounts";
            this.btnLoadAccounts.Size = new System.Drawing.Size(571, 23);
            this.btnLoadAccounts.TabIndex = 4;
            this.btnLoadAccounts.Text = "Check Accounts";
            this.btnLoadAccounts.UseVisualStyleBackColor = true;
            this.btnLoadAccounts.Click += new System.EventHandler(this.btnLoadAccounts_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listViewProtectedAccounts);
            this.groupBox3.Location = new System.Drawing.Point(601, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 399);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Protected Accounts";
            // 
            // listViewProtectedAccounts
            // 
            this.listViewProtectedAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listViewProtectedAccounts.ContextMenuStrip = this.contextMenuStrip2;
            this.listViewProtectedAccounts.FullRowSelect = true;
            this.listViewProtectedAccounts.GridLines = true;
            this.listViewProtectedAccounts.HideSelection = false;
            this.listViewProtectedAccounts.Location = new System.Drawing.Point(17, 19);
            this.listViewProtectedAccounts.Name = "listViewProtectedAccounts";
            this.listViewProtectedAccounts.Size = new System.Drawing.Size(267, 374);
            this.listViewProtectedAccounts.TabIndex = 6;
            this.listViewProtectedAccounts.UseCompatibleStateImageBehavior = false;
            this.listViewProtectedAccounts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Protected Accounts";
            this.columnHeader3.Width = 263;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(103, 26);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // lblCheckedCount
            // 
            this.lblCheckedCount.AutoSize = true;
            this.lblCheckedCount.Location = new System.Drawing.Point(16, 445);
            this.lblCheckedCount.Name = "lblCheckedCount";
            this.lblCheckedCount.Size = new System.Drawing.Size(35, 13);
            this.lblCheckedCount.TabIndex = 7;
            this.lblCheckedCount.Text = "label1";
            // 
            // btnAddAccounts
            // 
            this.btnAddAccounts.Location = new System.Drawing.Point(601, 417);
            this.btnAddAccounts.Name = "btnAddAccounts";
            this.btnAddAccounts.Size = new System.Drawing.Size(284, 23);
            this.btnAddAccounts.TabIndex = 10;
            this.btnAddAccounts.Text = "Add Accounts";
            this.btnAddAccounts.UseVisualStyleBackColor = true;
            this.btnAddAccounts.Click += new System.EventHandler(this.btnAddAccounts_Click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem2});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(103, 26);
            this.contextMenuStrip3.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip3_Opening);
            // 
            // copyToolStripMenuItem2
            // 
            this.copyToolStripMenuItem2.Name = "copyToolStripMenuItem2";
            this.copyToolStripMenuItem2.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem2.Text = "Copy";
            this.copyToolStripMenuItem2.Click += new System.EventHandler(this.copyToolStripMenuItem2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Open Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // open_website_at_start
            // 
            this.open_website_at_start.AutoSize = true;
            this.open_website_at_start.Checked = true;
            this.open_website_at_start.CheckState = System.Windows.Forms.CheckState.Checked;
            this.open_website_at_start.Location = new System.Drawing.Point(466, 449);
            this.open_website_at_start.Name = "open_website_at_start";
            this.open_website_at_start.Size = new System.Drawing.Size(124, 17);
            this.open_website_at_start.TabIndex = 12;
            this.open_website_at_start.Text = "Open Credits at Start";
            this.open_website_at_start.UseVisualStyleBackColor = true;
            this.open_website_at_start.CheckedChanged += new System.EventHandler(this.open_website_at_start_CheckedChanged);
            // 
            // show_proxy_manager
            // 
            this.show_proxy_manager.AutoSize = true;
            this.show_proxy_manager.Checked = true;
            this.show_proxy_manager.CheckState = System.Windows.Forms.CheckState.Checked;
            this.show_proxy_manager.Location = new System.Drawing.Point(336, 449);
            this.show_proxy_manager.Name = "show_proxy_manager";
            this.show_proxy_manager.Size = new System.Drawing.Size(127, 17);
            this.show_proxy_manager.TabIndex = 13;
            this.show_proxy_manager.Text = "Show Proxy Manager";
            this.show_proxy_manager.UseVisualStyleBackColor = true;
            this.show_proxy_manager.CheckedChanged += new System.EventHandler(this.show_proxy_manager_CheckedChanged);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.proxyManagerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(181, 92);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // proxyManagerToolStripMenuItem
            // 
            this.proxyManagerToolStripMenuItem.Name = "proxyManagerToolStripMenuItem";
            this.proxyManagerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proxyManagerToolStripMenuItem.Text = "Proxy Manager";
            this.proxyManagerToolStripMenuItem.Click += new System.EventHandler(this.proxyManagerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip4;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Settings";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 474);
            this.Controls.Add(this.show_proxy_manager);
            this.Controls.Add(this.open_website_at_start);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddAccounts);
            this.Controls.Add(this.lblCheckedCount);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnLoadAccounts);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam Checker (Proxy Version)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoadAccounts;
        private System.Windows.Forms.ListView listViewValidAccounts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCheckedCount;
        private System.Windows.Forms.ListView listViewInvalidAccounts;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listViewProtectedAccounts;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.Button btnAddAccounts;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox open_website_at_start;
        private System.Windows.Forms.CheckBox show_proxy_manager;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proxyManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

