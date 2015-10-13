namespace WindowsFormsApplication1
{
    partial class MDIParent1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomTS = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutTS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitTS = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckinTS = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerTS = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeTS = new System.Windows.Forms.ToolStripMenuItem();
            this.InventoryTS = new System.Windows.Forms.ToolStripMenuItem();
            this.utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.setRoomPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeAccountsTS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.LogoutTSB = new System.Windows.Forms.ToolStripButton();
            this.ExitTSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DatetimeT = new System.Windows.Forms.Timer(this.components);
            this.Date = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu,
            this.utilityToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.administratorToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(984, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RoomTS,
            this.LogoutTS,
            this.toolStripSeparator5,
            this.ExitTS});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // RoomTS
            // 
            this.RoomTS.ImageTransparentColor = System.Drawing.Color.Black;
            this.RoomTS.Name = "RoomTS";
            this.RoomTS.Size = new System.Drawing.Size(151, 22);
            this.RoomTS.Text = "&View All Room";
            this.RoomTS.Click += new System.EventHandler(this.RoomTS_Click);
            // 
            // LogoutTS
            // 
            this.LogoutTS.ImageTransparentColor = System.Drawing.Color.Black;
            this.LogoutTS.Name = "LogoutTS";
            this.LogoutTS.Size = new System.Drawing.Size(151, 22);
            this.LogoutTS.Text = "&Log Out";
            this.LogoutTS.Click += new System.EventHandler(this.LogoutTS_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(148, 6);
            // 
            // ExitTS
            // 
            this.ExitTS.Name = "ExitTS";
            this.ExitTS.Size = new System.Drawing.Size(151, 22);
            this.ExitTS.Text = "E&xit";
            this.ExitTS.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckinTS,
            this.cutToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(81, 20);
            this.editMenu.Text = "&Transaction";
            // 
            // CheckinTS
            // 
            this.CheckinTS.ImageTransparentColor = System.Drawing.Color.Black;
            this.CheckinTS.Name = "CheckinTS";
            this.CheckinTS.Size = new System.Drawing.Size(130, 22);
            this.CheckinTS.Text = "&Check In";
            this.CheckinTS.Click += new System.EventHandler(this.CheckinTS_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.cutToolStripMenuItem.Text = "&Check Out";
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustomerTS,
            this.EmployeeTS,
            this.InventoryTS});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(54, 20);
            this.viewMenu.Text = "&Search";
            // 
            // CustomerTS
            // 
            this.CustomerTS.Name = "CustomerTS";
            this.CustomerTS.Size = new System.Drawing.Size(184, 22);
            this.CustomerTS.Text = "Check In/ Check Out";
            this.CustomerTS.Click += new System.EventHandler(this.CustomerTS_Click);
            // 
            // EmployeeTS
            // 
            this.EmployeeTS.Name = "EmployeeTS";
            this.EmployeeTS.Size = new System.Drawing.Size(184, 22);
            this.EmployeeTS.Text = "&Employee Records";
            this.EmployeeTS.Click += new System.EventHandler(this.EmployeeTS_Click);
            // 
            // InventoryTS
            // 
            this.InventoryTS.Name = "InventoryTS";
            this.InventoryTS.Size = new System.Drawing.Size(184, 22);
            this.InventoryTS.Text = "&Inventory Records";
            // 
            // utilityToolStripMenuItem
            // 
            this.utilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.setRoomPriceToolStripMenuItem});
            this.utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            this.utilityToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.utilityToolStripMenuItem.Text = "&Utility";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem2.Text = "&Customer Info";
            // 
            // setRoomPriceToolStripMenuItem
            // 
            this.setRoomPriceToolStripMenuItem.Name = "setRoomPriceToolStripMenuItem";
            this.setRoomPriceToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.setRoomPriceToolStripMenuItem.Text = "&Set Room Price";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkInToolStripMenuItem,
            this.checkOutToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "&Report";
            // 
            // checkInToolStripMenuItem
            // 
            this.checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            this.checkInToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.checkInToolStripMenuItem.Text = "Check In";
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.checkOutToolStripMenuItem.Text = "Check Out";
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeAccountsTS});
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.administratorToolStripMenuItem.Text = "Administrator";
            // 
            // employeeAccountsTS
            // 
            this.employeeAccountsTS.Name = "employeeAccountsTS";
            this.employeeAccountsTS.Size = new System.Drawing.Size(179, 22);
            this.employeeAccountsTS.Text = "Employee Accounts";
            this.employeeAccountsTS.Click += new System.EventHandler(this.employeeAccountsTS_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton4,
            this.toolStripSeparator2,
            this.LogoutTSB,
            this.ExitTSB,
            this.toolStripSeparator3});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(984, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton1.Text = "Check In";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.CheckinTS_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(67, 22);
            this.toolStripButton3.Text = "Check Out";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(88, 22);
            this.toolStripButton4.Text = "View All Room";
            this.toolStripButton4.Click += new System.EventHandler(this.RoomTS_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // LogoutTSB
            // 
            this.LogoutTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LogoutTSB.Image = ((System.Drawing.Image)(resources.GetObject("LogoutTSB.Image")));
            this.LogoutTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogoutTSB.Name = "LogoutTSB";
            this.LogoutTSB.Size = new System.Drawing.Size(54, 22);
            this.LogoutTSB.Text = "Log Out";
            this.LogoutTSB.Click += new System.EventHandler(this.LogoutTS_Click);
            // 
            // ExitTSB
            // 
            this.ExitTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExitTSB.Image = ((System.Drawing.Image)(resources.GetObject("ExitTSB.Image")));
            this.ExitTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitTSB.Name = "ExitTSB";
            this.ExitTSB.Size = new System.Drawing.Size(29, 22);
            this.ExitTSB.Text = "Exit";
            this.ExitTSB.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // DatetimeT
            // 
            this.DatetimeT.Enabled = true;
            this.DatetimeT.Interval = 1;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(818, 30);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(63, 13);
            this.Date.TabIndex = 5;
            this.Date.Text = "Date Today";
            this.Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem RoomTS;
        private System.Windows.Forms.ToolStripMenuItem LogoutTS;
        private System.Windows.Forms.ToolStripMenuItem ExitTS;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem CheckinTS;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem CustomerTS;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem EmployeeTS;
        private System.Windows.Forms.ToolStripMenuItem InventoryTS;
        private System.Windows.Forms.ToolStripMenuItem utilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem setRoomPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton LogoutTSB;
        private System.Windows.Forms.ToolStripButton ExitTSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeAccountsTS;
        private System.Windows.Forms.Timer DatetimeT;
        private System.Windows.Forms.Label Date;
    }
}



