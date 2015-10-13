namespace WindowsFormsApplication1
{
    partial class UserAccounts
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addAccountBt = new System.Windows.Forms.Button();
            this.password2AddTb = new System.Windows.Forms.TextBox();
            this.password1AddTb = new System.Windows.Forms.TextBox();
            this.usernameAddTb = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.employeeAddRb = new System.Windows.Forms.RadioButton();
            this.adminAddRb = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.deleteBt = new System.Windows.Forms.Button();
            this.usernameDeleteTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.accountTypeGb.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.accountsDataGridView.Location = new System.Drawing.Point(14, 26);
            this.accountsDataGridView.MultiSelect = false;
            this.accountsDataGridView.Name = "accountsDataGridView";
            this.accountsDataGridView.ReadOnly = true;
            this.accountsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.accountsDataGridView.Size = new System.Drawing.Size(547, 572);
            this.accountsDataGridView.TabIndex = 0;
            this.accountsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountsDataGridView_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.addAccountBt);
            this.groupBox2.Controls.Add(this.password2AddTb);
            this.groupBox2.Controls.Add(this.password1AddTb);
            this.groupBox2.Controls.Add(this.usernameAddTb);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(581, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 200);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ADD ACCOUNT";
            // 
            // addAccountBt
            // 
            this.addAccountBt.Location = new System.Drawing.Point(270, 136);
            this.addAccountBt.Name = "addAccountBt";
            this.addAccountBt.Size = new System.Drawing.Size(167, 38);
            this.addAccountBt.TabIndex = 14;
            this.addAccountBt.Tag = "Enter";
            this.addAccountBt.Text = "Create Account";
            this.addAccountBt.UseVisualStyleBackColor = true;
            this.addAccountBt.Click += new System.EventHandler(this.addAccountBt_Click);
            // 
            // password2AddTb
            // 
            this.password2AddTb.Location = new System.Drawing.Point(121, 118);
            this.password2AddTb.MaxLength = 25;
            this.password2AddTb.Name = "password2AddTb";
            this.password2AddTb.Size = new System.Drawing.Size(131, 20);
            this.password2AddTb.TabIndex = 13;
            this.password2AddTb.UseSystemPasswordChar = true;
            this.password2AddTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password2AddTb_KeyPress);
            // 
            // password1AddTb
            // 
            this.password1AddTb.Location = new System.Drawing.Point(121, 79);
            this.password1AddTb.MaxLength = 25;
            this.password1AddTb.Name = "password1AddTb";
            this.password1AddTb.Size = new System.Drawing.Size(131, 20);
            this.password1AddTb.TabIndex = 12;
            this.password1AddTb.UseSystemPasswordChar = true;
            this.password1AddTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password1AddTb_KeyPress);
            // 
            // usernameAddTb
            // 
            this.usernameAddTb.Location = new System.Drawing.Point(121, 41);
            this.usernameAddTb.MaxLength = 20;
            this.usernameAddTb.Name = "usernameAddTb";
            this.usernameAddTb.ShortcutsEnabled = false;
            this.usernameAddTb.Size = new System.Drawing.Size(131, 20);
            this.usernameAddTb.TabIndex = 11;
            this.usernameAddTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameAddTb_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.employeeAddRb);
            this.groupBox3.Controls.Add(this.adminAddRb);
            this.groupBox3.Location = new System.Drawing.Point(270, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 62);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account Type:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Re-enter Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Username:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.changePasswordCb);
            this.groupBox4.Controls.Add(this.editLoadBt);
            this.groupBox4.Controls.Add(this.editBt);
            this.groupBox4.Controls.Add(this.password2EditTb);
            this.groupBox4.Controls.Add(this.oldPasswordTb);
            this.groupBox4.Controls.Add(this.password1EditTb);
            this.groupBox4.Controls.Add(this.usernameEditTb);
            this.groupBox4.Controls.Add(this.accountTypeGb);
            this.groupBox4.Controls.Add(this.oldPasswordLabel);
            this.groupBox4.Controls.Add(this.password2Label);
            this.groupBox4.Controls.Add(this.password1Label);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(581, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(461, 222);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "EDIT ACCOUNT";
            // 
            // changePasswordCb
            // 
            this.changePasswordCb.AutoSize = true;
            this.changePasswordCb.Location = new System.Drawing.Point(148, 176);
            this.changePasswordCb.Name = "changePasswordCb";
            this.changePasswordCb.Size = new System.Drawing.Size(111, 17);
            this.changePasswordCb.TabIndex = 16;
            this.changePasswordCb.Text = "Change password";
            this.changePasswordCb.UseVisualStyleBackColor = true;
            this.changePasswordCb.Visible = false;
            this.changePasswordCb.CheckStateChanged += new System.EventHandler(this.changePasswordCb_CheckStateChanged);
            // 
            // editLoadBt
            // 
            this.editLoadBt.Location = new System.Drawing.Point(168, 79);
            this.editLoadBt.Name = "editLoadBt";
            this.editLoadBt.Size = new System.Drawing.Size(84, 23);
            this.editLoadBt.TabIndex = 20;
            this.editLoadBt.Text = "Load Details";
            this.editLoadBt.UseVisualStyleBackColor = true;
            this.editLoadBt.Click += new System.EventHandler(this.editLoadBt_Click);
            // 
            // editBt
            // 
            this.editBt.Location = new System.Drawing.Point(270, 164);
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(167, 38);
            this.editBt.TabIndex = 19;
            this.editBt.Tag = "Enter";
            this.editBt.Text = "Change Account Details";
            this.editBt.UseVisualStyleBackColor = true;
            this.editBt.Visible = false;
            this.editBt.Click += new System.EventHandler(this.editBt_Click);
            // 
            // password2EditTb
            // 
            this.password2EditTb.Enabled = false;
            this.password2EditTb.Location = new System.Drawing.Point(121, 144);
            this.password2EditTb.MaxLength = 25;
            this.password2EditTb.Name = "password2EditTb";
            this.password2EditTb.Size = new System.Drawing.Size(131, 20);
            this.password2EditTb.TabIndex = 12;
            this.password2EditTb.UseSystemPasswordChar = true;
            this.password2EditTb.Visible = false;
            this.password2EditTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password2EditTb_KeyPress);
            // 
            // oldPasswordTb
            // 
            this.oldPasswordTb.Enabled = false;
            this.oldPasswordTb.Location = new System.Drawing.Point(121, 76);
            this.oldPasswordTb.MaxLength = 25;
            this.oldPasswordTb.Name = "oldPasswordTb";
            this.oldPasswordTb.Size = new System.Drawing.Size(131, 20);
            this.oldPasswordTb.TabIndex = 11;
            this.oldPasswordTb.UseSystemPasswordChar = true;
            this.oldPasswordTb.Visible = false;
            this.oldPasswordTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oldPasswordTb_KeyPress);
            // 
            // password1EditTb
            // 
            this.password1EditTb.Enabled = false;
            this.password1EditTb.Location = new System.Drawing.Point(121, 111);
            this.password1EditTb.MaxLength = 25;
            this.password1EditTb.Name = "password1EditTb";
            this.password1EditTb.Size = new System.Drawing.Size(131, 20);
            this.password1EditTb.TabIndex = 10;
            this.password1EditTb.UseSystemPasswordChar = true;
            this.password1EditTb.Visible = false;
            this.password1EditTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password1EditTb_KeyPress);
            // 
            // usernameEditTb
            // 
            this.usernameEditTb.Location = new System.Drawing.Point(121, 42);
            this.usernameEditTb.MaxLength = 20;
            this.usernameEditTb.Name = "usernameEditTb";
            this.usernameEditTb.Size = new System.Drawing.Size(131, 20);
            this.usernameEditTb.TabIndex = 9;
            this.usernameEditTb.TextChanged += new System.EventHandler(this.usernameEditTb_TextChanged);
            this.usernameEditTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameEditTb_KeyPress);
            // 
            // accountTypeGb
            // 
            this.accountTypeGb.Controls.Add(this.employeeEditRd);
            this.accountTypeGb.Controls.Add(this.adminEditRd);
            this.accountTypeGb.Location = new System.Drawing.Point(270, 37);
            this.accountTypeGb.Name = "accountTypeGb";
            this.accountTypeGb.Size = new System.Drawing.Size(167, 62);
            this.accountTypeGb.TabIndex = 18;
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
            this.oldPasswordLabel.Location = new System.Drawing.Point(39, 79);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(75, 13);
            this.oldPasswordLabel.TabIndex = 15;
            this.oldPasswordLabel.Text = "Old Password:";
            this.oldPasswordLabel.Visible = false;
            // 
            // password2Label
            // 
            this.password2Label.AutoSize = true;
            this.password2Label.Location = new System.Drawing.Point(16, 147);
            this.password2Label.Name = "password2Label";
            this.password2Label.Size = new System.Drawing.Size(100, 13);
            this.password2Label.TabIndex = 13;
            this.password2Label.Text = "Re-enter Password:";
            this.password2Label.Visible = false;
            // 
            // password1Label
            // 
            this.password1Label.AutoSize = true;
            this.password1Label.Location = new System.Drawing.Point(33, 114);
            this.password1Label.Name = "password1Label";
            this.password1Label.Size = new System.Drawing.Size(81, 13);
            this.password1Label.TabIndex = 14;
            this.password1Label.Text = "New Password:";
            this.password1Label.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Username:";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.deleteBt);
            this.groupBox5.Controls.Add(this.usernameDeleteTb);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(581, 479);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(461, 119);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DELETE ACCOUNT";
            // 
            // deleteBt
            // 
            this.deleteBt.Location = new System.Drawing.Point(192, 73);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(112, 28);
            this.deleteBt.TabIndex = 14;
            this.deleteBt.Tag = "Enter";
            this.deleteBt.Text = "Delete Account";
            this.deleteBt.UseVisualStyleBackColor = true;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // usernameDeleteTb
            // 
            this.usernameDeleteTb.Location = new System.Drawing.Point(121, 39);
            this.usernameDeleteTb.MaxLength = 20;
            this.usernameDeleteTb.Name = "usernameDeleteTb";
            this.usernameDeleteTb.Size = new System.Drawing.Size(183, 20);
            this.usernameDeleteTb.TabIndex = 13;
            this.usernameDeleteTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameDeleteTb_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Username:";
            // 
            // UserAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 616);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.accountsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Accounts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.accountTypeGb.ResumeLayout(false);
            this.accountTypeGb.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView accountsDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addAccountBt;
        private System.Windows.Forms.TextBox password2AddTb;
        private System.Windows.Forms.TextBox password1AddTb;
        private System.Windows.Forms.TextBox usernameAddTb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton employeeAddRb;
        private System.Windows.Forms.RadioButton adminAddRb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox changePasswordCb;
        private System.Windows.Forms.Button editLoadBt;
        private System.Windows.Forms.Button editBt;
        private System.Windows.Forms.TextBox password2EditTb;
        private System.Windows.Forms.TextBox oldPasswordTb;
        private System.Windows.Forms.TextBox password1EditTb;
        private System.Windows.Forms.TextBox usernameEditTb;
        private System.Windows.Forms.GroupBox accountTypeGb;
        private System.Windows.Forms.RadioButton employeeEditRd;
        private System.Windows.Forms.RadioButton adminEditRd;
        private System.Windows.Forms.Label oldPasswordLabel;
        private System.Windows.Forms.Label password2Label;
        private System.Windows.Forms.Label password1Label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button deleteBt;
        private System.Windows.Forms.TextBox usernameDeleteTb;
        private System.Windows.Forms.Label label7;

    }
}