namespace WindowsFormsApplication1
{
    partial class EmployeeRecord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CivilstatusCB = new System.Windows.Forms.ComboBox();
            this.AgeNUD = new System.Windows.Forms.NumericUpDown();
            this.RnameTB = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.RelationTB = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.RcontactnoTB = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ContactnoTB = new System.Windows.Forms.TextBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.GenderCB = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.EmppositionCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpidTB = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.EmpnameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddB = new System.Windows.Forms.Button();
            this.DeleteB = new System.Windows.Forms.Button();
            this.UpdateB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EmprecordDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNUD)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmprecordDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.EmailTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CivilstatusCB);
            this.groupBox1.Controls.Add(this.AgeNUD);
            this.groupBox1.Controls.Add(this.RnameTB);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.RelationTB);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.RcontactnoTB);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.ContactnoTB);
            this.groupBox1.Controls.Add(this.AddressTB);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.GenderCB);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.EmppositionCB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EmpidTB);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.EmpnameTB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(603, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 393);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Information";
            // 
            // EmailTB
            // 
            this.EmailTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTB.Location = new System.Drawing.Point(112, 230);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.ReadOnly = true;
            this.EmailTB.Size = new System.Drawing.Size(196, 22);
            this.EmailTB.TabIndex = 131;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 130;
            this.label1.Text = "Email Address";
            // 
            // CivilstatusCB
            // 
            this.CivilstatusCB.BackColor = System.Drawing.SystemColors.Window;
            this.CivilstatusCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CivilstatusCB.FormattingEnabled = true;
            this.CivilstatusCB.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Widow/Widower"});
            this.CivilstatusCB.Location = new System.Drawing.Point(112, 115);
            this.CivilstatusCB.Name = "CivilstatusCB";
            this.CivilstatusCB.Size = new System.Drawing.Size(138, 24);
            this.CivilstatusCB.TabIndex = 129;
            // 
            // AgeNUD
            // 
            this.AgeNUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgeNUD.Location = new System.Drawing.Point(112, 174);
            this.AgeNUD.Name = "AgeNUD";
            this.AgeNUD.ReadOnly = true;
            this.AgeNUD.Size = new System.Drawing.Size(72, 22);
            this.AgeNUD.TabIndex = 128;
            // 
            // RnameTB
            // 
            this.RnameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RnameTB.Location = new System.Drawing.Point(112, 301);
            this.RnameTB.Name = "RnameTB";
            this.RnameTB.ReadOnly = true;
            this.RnameTB.Size = new System.Drawing.Size(196, 22);
            this.RnameTB.TabIndex = 127;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(14, 310);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 13);
            this.label19.TabIndex = 126;
            this.label19.Text = "Contact Name";
            // 
            // RelationTB
            // 
            this.RelationTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RelationTB.Location = new System.Drawing.Point(112, 357);
            this.RelationTB.Name = "RelationTB";
            this.RelationTB.ReadOnly = true;
            this.RelationTB.Size = new System.Drawing.Size(196, 22);
            this.RelationTB.TabIndex = 125;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(14, 361);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 124;
            this.label18.Text = "Relation";
            // 
            // RcontactnoTB
            // 
            this.RcontactnoTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RcontactnoTB.Location = new System.Drawing.Point(112, 329);
            this.RcontactnoTB.Name = "RcontactnoTB";
            this.RcontactnoTB.ReadOnly = true;
            this.RcontactnoTB.Size = new System.Drawing.Size(196, 22);
            this.RcontactnoTB.TabIndex = 123;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 333);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 122;
            this.label16.Text = "Contact No";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkRed;
            this.label17.Location = new System.Drawing.Point(13, 284);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(215, 15);
            this.label17.TabIndex = 121;
            this.label17.Text = "In case of Emergency, Please Contact:";
            // 
            // ContactnoTB
            // 
            this.ContactnoTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactnoTB.Location = new System.Drawing.Point(112, 258);
            this.ContactnoTB.Name = "ContactnoTB";
            this.ContactnoTB.ReadOnly = true;
            this.ContactnoTB.Size = new System.Drawing.Size(196, 22);
            this.ContactnoTB.TabIndex = 120;
            // 
            // AddressTB
            // 
            this.AddressTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressTB.Location = new System.Drawing.Point(112, 202);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.ReadOnly = true;
            this.AddressTB.Size = new System.Drawing.Size(196, 22);
            this.AddressTB.TabIndex = 119;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 211);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 118;
            this.label14.Text = "Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 117;
            this.label13.Text = "Contact No";
            // 
            // GenderCB
            // 
            this.GenderCB.BackColor = System.Drawing.SystemColors.Window;
            this.GenderCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderCB.FormattingEnabled = true;
            this.GenderCB.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.GenderCB.Location = new System.Drawing.Point(112, 145);
            this.GenderCB.Name = "GenderCB";
            this.GenderCB.Size = new System.Drawing.Size(138, 24);
            this.GenderCB.TabIndex = 116;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 115;
            this.label12.Text = "Age";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 114;
            this.label11.Text = "Civil Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 113;
            this.label10.Text = "Gender";
            // 
            // EmppositionCB
            // 
            this.EmppositionCB.BackColor = System.Drawing.SystemColors.Window;
            this.EmppositionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmppositionCB.FormattingEnabled = true;
            this.EmppositionCB.Items.AddRange(new object[] {
            "General Manager",
            "Accounting Supervisor",
            "Front Office Manager",
            "Front Office Cashier",
            "Security Guard",
            "Technician",
            "Groundsperson",
            "Chef",
            "Bartender",
            "Dining Manager",
            "Waiter",
            "Busperson"});
            this.EmppositionCB.Location = new System.Drawing.Point(112, 85);
            this.EmppositionCB.Name = "EmppositionCB";
            this.EmppositionCB.Size = new System.Drawing.Size(86, 24);
            this.EmppositionCB.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Employee Position";
            // 
            // EmpidTB
            // 
            this.EmpidTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpidTB.Location = new System.Drawing.Point(112, 29);
            this.EmpidTB.Name = "EmpidTB";
            this.EmpidTB.Size = new System.Drawing.Size(84, 22);
            this.EmpidTB.TabIndex = 61;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(13, 33);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 13);
            this.label23.TabIndex = 59;
            this.label23.Text = "Employee ID";
            // 
            // EmpnameTB
            // 
            this.EmpnameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpnameTB.Location = new System.Drawing.Point(112, 57);
            this.EmpnameTB.Name = "EmpnameTB";
            this.EmpnameTB.ReadOnly = true;
            this.EmpnameTB.Size = new System.Drawing.Size(186, 22);
            this.EmpnameTB.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "Employee Name";
            // 
            // AddB
            // 
            this.AddB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddB.Location = new System.Drawing.Point(6, 15);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(91, 31);
            this.AddB.TabIndex = 109;
            this.AddB.Text = "CREATE";
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // DeleteB
            // 
            this.DeleteB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteB.Location = new System.Drawing.Point(200, 15);
            this.DeleteB.Name = "DeleteB";
            this.DeleteB.Size = new System.Drawing.Size(91, 31);
            this.DeleteB.TabIndex = 111;
            this.DeleteB.Text = "DELETE";
            this.DeleteB.UseVisualStyleBackColor = true;
            // 
            // UpdateB
            // 
            this.UpdateB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateB.Location = new System.Drawing.Point(103, 15);
            this.UpdateB.Name = "UpdateB";
            this.UpdateB.Size = new System.Drawing.Size(91, 31);
            this.UpdateB.TabIndex = 112;
            this.UpdateB.Text = "UPDATE";
            this.UpdateB.UseVisualStyleBackColor = true;
            this.UpdateB.Click += new System.EventHandler(this.UpdateB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddB);
            this.groupBox2.Controls.Add(this.UpdateB);
            this.groupBox2.Controls.Add(this.DeleteB);
            this.groupBox2.Location = new System.Drawing.Point(620, 430);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 51);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            // 
            // EmprecordDGV
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmprecordDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EmprecordDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmprecordDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.EmprecordDGV.Location = new System.Drawing.Point(12, 12);
            this.EmprecordDGV.Name = "EmprecordDGV";
            this.EmprecordDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmprecordDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.EmprecordDGV.Size = new System.Drawing.Size(585, 469);
            this.EmprecordDGV.TabIndex = 114;
            this.EmprecordDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmprecordDGV_CellContentClick);
            // 
            // EmployeeRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 493);
            this.Controls.Add(this.EmprecordDGV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeeRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeRecords";
            this.Load += new System.EventHandler(this.EmployeeRecord_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNUD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmprecordDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox EmpnameTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox EmppositionCB;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox EmpidTB;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.ComboBox CivilstatusCB;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Button DeleteB;
        private System.Windows.Forms.Button UpdateB;
        public System.Windows.Forms.NumericUpDown AgeNUD;
        public System.Windows.Forms.TextBox RnameTB;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox RelationTB;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox RcontactnoTB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox ContactnoTB;
        public System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox GenderCB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView EmprecordDGV;
        public System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.Label label1;


    }
}