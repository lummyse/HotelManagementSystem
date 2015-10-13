namespace WindowsFormsApplication1
{
    partial class AdminControlPanel
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
            this.accountsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addAccountBt = new System.Windows.Forms.Button();
            this.password2AddTb = new System.Windows.Forms.TextBox();
            this.password1AddTb = new System.Windows.Forms.TextBox();
            this.usernameAddTb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.employeeAddRb = new System.Windows.Forms.RadioButton();
            this.adminAddRb = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.changePasswordCb = new System.Windows.Forms.CheckBox();
            this.editLoadBt = new System.Windows.Forms.Button();
            this.editBt = new System.Windows.Forms.Button();
            this.password2EditTb = new System.Windows.Forms.TextBox();
            this.oldPasswordTb = new System.Windows.Forms.TextBox();
            this.password1EditTb = new System.Windows.Forms.TextBox();
            this.usernameEditTb = new System.Windows.Forms.TextBox();
            this.accountTypeGb = new System.Windows.Forms.GroupBox();
            this.employeeEditRd = new System.Windows.Forms.RadioButton();
            this.adminEditRd = new System.Windows.Forms.RadioButton();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.password2Label = new System.Windows.Forms.Label();
            this.password1Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.deleteBt = new System.Windows.Forms.Button();
            this.usernameDeleteTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.accountTypeGb.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountsDataGridView
            // 
            this.accountsDataGridView.AllowUserToAddRows = false;
            this.accountsDataGridView.AllowUserToDeleteRows = false;
            this.accountsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.accountsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.accountsDataGridView.Name = "accountsDataGridView";
            this.accountsDataGridView.ReadOnly = true;
            this.accountsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.accountsDataGridView.Size = new System.Drawing.Size(540, 227);
            this.accountsDataGridView.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 255);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(540, 189);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addAccountBt);
            this.tabPage1.Controls.Add(this.password2AddTb);
            this.tabPage1.Controls.Add(this.password1AddTb);
            this.tabPage1.Controls.Add(this.usernameAddTb);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(532, 163);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ADD";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addAccountBt
            // 
            this.addAccountBt.Location = new System.Drawing.Point(339, 110);
            this.addAccountBt.Name = "addAccountBt";
            this.addAccountBt.Size = new System.Drawing.Size(167, 38);
            this.addAccountBt.TabIndex = 6;
            this.addAccountBt.Tag = "Enter";
            this.addAccountBt.Text = "Create";
            this.addAccountBt.UseVisualStyleBackColor = true;
            this.addAccountBt.Click += new System.EventHandler(this.addAccountBt_Click);
            // 
            // password2AddTb
            // 
            this.password2AddTb.Location = new System.Drawing.Point(121, 95);
            this.password2AddTb.MaxLength = 25;
            this.password2AddTb.Name = "password2AddTb";
            this.password2AddTb.Size = new System.Drawing.Size(183, 20);
            this.password2AddTb.TabIndex = 3;
            this.password2AddTb.UseSystemPasswordChar = true;
            this.password2AddTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password2AddTb_KeyPress);
            // 
            // password1AddTb
            // 
            this.password1AddTb.Location = new System.Drawing.Point(121, 61);
            this.password1AddTb.MaxLength = 25;
            this.password1AddTb.Name = "password1AddTb";
            this.password1AddTb.Size = new System.Drawing.Size(183, 20);
            this.password1AddTb.TabIndex = 2;
            this.password1AddTb.UseSystemPasswordChar = true;
            this.password1AddTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password1AddTb_KeyPress);
            // 
            // usernameAddTb
            // 
            this.usernameAddTb.Location = new System.Drawing.Point(121, 28);
            this.usernameAddTb.MaxLength = 20;
            this.usernameAddTb.Name = "usernameAddTb";
            this.usernameAddTb.Size = new System.Drawing.Size(183, 20);
            this.usernameAddTb.TabIndex = 1;
            this.usernameAddTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameAddTb_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.employeeAddRb);
            this.groupBox1.Controls.Add(this.adminAddRb);
            this.groupBox1.Location = new System.Drawing.Point(339, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Type:";
            // 
            // employeeAddRb
            // 
            this.employeeAddRb.AutoSize = true;
            this.employeeAddRb.Checked = true;
            this.employeeAddRb.Location = new System.Drawing.Point(86, 29);
            this.employeeAddRb.Name = "employeeAddRb";
            this.employeeAddRb.Size = new System.Drawing.Size(71, 17);
            this.employeeAddRb.TabIndex = 5;
            this.employeeAddRb.TabStop = true;
            this.employeeAddRb.Text = "Employee";
            this.employeeAddRb.UseVisualStyleBackColor = true;
            // 
            // adminAddRb
            // 
            this.adminAddRb.AutoSize = true;
            this.adminAddRb.Location = new System.Drawing.Point(17, 29);
            this.adminAddRb.Name = "adminAddRb";
            this.adminAddRb.Size = new System.Drawing.Size(54, 17);
            this.adminAddRb.TabIndex = 4;
            this.adminAddRb.Text = "Admin";
            this.adminAddRb.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Re-enter Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.changePasswordCb);
            this.tabPage2.Controls.Add(this.editLoadBt);
            this.tabPage2.Controls.Add(this.editBt);
            this.tabPage2.Controls.Add(this.password2EditTb);
            this.tabPage2.Controls.Add(this.oldPasswordTb);
            this.tabPage2.Controls.Add(this.password1EditTb);
            this.tabPage2.Controls.Add(this.usernameEditTb);
            this.tabPage2.Controls.Add(this.accountTypeGb);
            this.tabPage2.Controls.Add(this.oldPasswordLabel);
            this.tabPage2.Controls.Add(this.password2Label);
            this.tabPage2.Controls.Add(this.password1Label);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(532, 163);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "EDIT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // changePasswordCb
            // 
            this.changePasswordCb.AutoSize = true;
            this.changePasswordCb.Location = new System.Drawing.Point(197, 134);
            this.changePasswordCb.Name = "changePasswordCb";
            this.changePasswordCb.Size = new System.Drawing.Size(111, 17);
            this.changePasswordCb.TabIndex = 4;
            this.changePasswordCb.Text = "Change password";
            this.changePasswordCb.UseVisualStyleBackColor = true;
            this.changePasswordCb.Visible = false;
            this.changePasswordCb.CheckStateChanged += new System.EventHandler(this.changePasswordCb_CheckStateChanged);
            // 
            // editLoadBt
            // 
            this.editLoadBt.Location = new System.Drawing.Point(217, 55);
            this.editLoadBt.Name = "editLoadBt";
            this.editLoadBt.Size = new System.Drawing.Size(84, 23);
            this.editLoadBt.TabIndex = 8;
            this.editLoadBt.Text = "Load Details";
            this.editLoadBt.UseVisualStyleBackColor = true;
            this.editLoadBt.Click += new System.EventHandler(this.editLoadBt_Click);
            // 
            // editBt
            // 
            this.editBt.Location = new System.Drawing.Point(338, 111);
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(167, 38);
            this.editBt.TabIndex = 7;
            this.editBt.Tag = "Enter";
            this.editBt.Text = "Change Account Details";
            this.editBt.UseVisualStyleBackColor = true;
            this.editBt.Visible = false;
            this.editBt.Click += new System.EventHandler(this.editBt_Click);
            // 
            // password2EditTb
            // 
            this.password2EditTb.Enabled = false;
            this.password2EditTb.Location = new System.Drawing.Point(118, 108);
            this.password2EditTb.MaxLength = 25;
            this.password2EditTb.Name = "password2EditTb";
            this.password2EditTb.Size = new System.Drawing.Size(183, 20);
            this.password2EditTb.TabIndex = 3;
            this.password2EditTb.UseSystemPasswordChar = true;
            this.password2EditTb.Visible = false;
            this.password2EditTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password2EditTb_KeyPress);
            // 
            // oldPasswordTb
            // 
            this.oldPasswordTb.Enabled = false;
            this.oldPasswordTb.Location = new System.Drawing.Point(118, 50);
            this.oldPasswordTb.MaxLength = 25;
            this.oldPasswordTb.Name = "oldPasswordTb";
            this.oldPasswordTb.Size = new System.Drawing.Size(183, 20);
            this.oldPasswordTb.TabIndex = 2;
            this.oldPasswordTb.UseSystemPasswordChar = true;
            this.oldPasswordTb.Visible = false;
            this.oldPasswordTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oldPasswordTb_KeyPress);
            // 
            // password1EditTb
            // 
            this.password1EditTb.Enabled = false;
            this.password1EditTb.Location = new System.Drawing.Point(118, 79);
            this.password1EditTb.MaxLength = 25;
            this.password1EditTb.Name = "password1EditTb";
            this.password1EditTb.Size = new System.Drawing.Size(183, 20);
            this.password1EditTb.TabIndex = 2;
            this.password1EditTb.UseSystemPasswordChar = true;
            this.password1EditTb.Visible = false;
            this.password1EditTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password1EditTb_KeyPress);
            // 
            // usernameEditTb
            // 
            this.usernameEditTb.Location = new System.Drawing.Point(118, 19);
            this.usernameEditTb.MaxLength = 20;
            this.usernameEditTb.Name = "usernameEditTb";
            this.usernameEditTb.Size = new System.Drawing.Size(183, 20);
            this.usernameEditTb.TabIndex = 1;
            this.usernameEditTb.TextChanged += new System.EventHandler(this.usernameEditTb_TextChanged);
            this.usernameEditTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameEditTb_KeyPress);
            // 
            // accountTypeGb
            // 
            this.accountTypeGb.Controls.Add(this.employeeEditRd);
            this.accountTypeGb.Controls.Add(this.adminEditRd);
            this.accountTypeGb.Location = new System.Drawing.Point(338, 22);
            this.accountTypeGb.Name = "accountTypeGb";
            this.accountTypeGb.Size = new System.Drawing.Size(167, 62);
            this.accountTypeGb.TabIndex = 6;
            this.accountTypeGb.TabStop = false;
            this.accountTypeGb.Text = "Account Type:";
            this.accountTypeGb.Visible = false;
            // 
            // employeeEditRd
            // 
            this.employeeEditRd.AutoSize = true;
            this.employeeEditRd.Checked = true;
            this.employeeEditRd.Location = new System.Drawing.Point(86, 29);
            this.employeeEditRd.Name = "employeeEditRd";
            this.employeeEditRd.Size = new System.Drawing.Size(71, 17);
            this.employeeEditRd.TabIndex = 6;
            this.employeeEditRd.TabStop = true;
            this.employeeEditRd.Text = "Employee";
            this.employeeEditRd.UseVisualStyleBackColor = true;
            this.employeeEditRd.CheckedChanged += new System.EventHandler(this.employeeEditRd_CheckedChanged);
            // 
            // adminEditRd
            // 
            this.adminEditRd.AutoSize = true;
            this.adminEditRd.Location = new System.Drawing.Point(17, 29);
            this.adminEditRd.Name = "adminEditRd";
            this.adminEditRd.Size = new System.Drawing.Size(54, 17);
            this.adminEditRd.TabIndex = 5;
            this.adminEditRd.Text = "Admin";
            this.adminEditRd.UseVisualStyleBackColor = true;
            this.adminEditRd.CheckedChanged += new System.EventHandler(this.adminEditRd_CheckedChanged);
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.Location = new System.Drawing.Point(34, 53);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(75, 13);
            this.oldPasswordLabel.TabIndex = 4;
            this.oldPasswordLabel.Text = "Old Password:";
            this.oldPasswordLabel.Visible = false;
            // 
            // password2Label
            // 
            this.password2Label.AutoSize = true;
            this.password2Label.Location = new System.Drawing.Point(11, 111);
            this.password2Label.Name = "password2Label";
            this.password2Label.Size = new System.Drawing.Size(100, 13);
            this.password2Label.TabIndex = 3;
            this.password2Label.Text = "Re-enter Password:";
            this.password2Label.Visible = false;
            // 
            // password1Label
            // 
            this.password1Label.AutoSize = true;
            this.password1Label.Location = new System.Drawing.Point(28, 82);
            this.password1Label.Name = "password1Label";
            this.password1Label.Size = new System.Drawing.Size(81, 13);
            this.password1Label.TabIndex = 4;
            this.password1Label.Text = "New Password:";
            this.password1Label.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Username:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.deleteBt);
            this.tabPage3.Controls.Add(this.usernameDeleteTb);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(619, 163);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DELETE";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // deleteBt
            // 
            this.deleteBt.Location = new System.Drawing.Point(306, 88);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(84, 23);
            this.deleteBt.TabIndex = 2;
            this.deleteBt.Tag = "Enter";
            this.deleteBt.Text = "Delete";
            this.deleteBt.UseVisualStyleBackColor = true;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // usernameDeleteTb
            // 
            this.usernameDeleteTb.Location = new System.Drawing.Point(207, 52);
            this.usernameDeleteTb.MaxLength = 20;
            this.usernameDeleteTb.Name = "usernameDeleteTb";
            this.usernameDeleteTb.Size = new System.Drawing.Size(183, 20);
            this.usernameDeleteTb.TabIndex = 1;
            this.usernameDeleteTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameDeleteTb_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Username:";
            // 
            // AdminControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 456);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.accountsDataGridView);
            this.Name = "AdminControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminControlPanel";
            this.Load += new System.EventHandler(this.AdminControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.accountTypeGb.ResumeLayout(false);
            this.accountTypeGb.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView accountsDataGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox password2AddTb;
        private System.Windows.Forms.TextBox password1AddTb;
        private System.Windows.Forms.TextBox usernameAddTb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addAccountBt;
        private System.Windows.Forms.RadioButton employeeAddRb;
        private System.Windows.Forms.RadioButton adminAddRb;
        private System.Windows.Forms.Button editBt;
        private System.Windows.Forms.TextBox password2EditTb;
        private System.Windows.Forms.TextBox password1EditTb;
        private System.Windows.Forms.TextBox usernameEditTb;
        private System.Windows.Forms.GroupBox accountTypeGb;
        private System.Windows.Forms.RadioButton employeeEditRd;
        private System.Windows.Forms.RadioButton adminEditRd;
        private System.Windows.Forms.Label password2Label;
        private System.Windows.Forms.Label password1Label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button editLoadBt;
        private System.Windows.Forms.Button deleteBt;
        private System.Windows.Forms.TextBox usernameDeleteTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox changePasswordCb;
        private System.Windows.Forms.TextBox oldPasswordTb;
        private System.Windows.Forms.Label oldPasswordLabel;

    }
}