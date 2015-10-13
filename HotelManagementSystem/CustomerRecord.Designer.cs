namespace WindowsFormsApplication1
{
    partial class CustomerRecord
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CustnameCB = new System.Windows.Forms.CheckBox();
            this.CustnameTB = new System.Windows.Forms.TextBox();
            this.CheckinDTP = new System.Windows.Forms.DateTimePicker();
            this.CustidTB = new System.Windows.Forms.TextBox();
            this.CheckinCB = new System.Windows.Forms.CheckBox();
            this.CustomerCB = new System.Windows.Forms.CheckBox();
            this.SearchB = new System.Windows.Forms.Button();
            this.ShowAllB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(12, 168);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.Size = new System.Drawing.Size(430, 272);
            this.DGV.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CustnameCB);
            this.groupBox1.Controls.Add(this.CustnameTB);
            this.groupBox1.Controls.Add(this.CheckinDTP);
            this.groupBox1.Controls.Add(this.CustidTB);
            this.groupBox1.Controls.Add(this.CheckinCB);
            this.groupBox1.Controls.Add(this.CustomerCB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 121);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Customer\'s Booking";
            // 
            // CustnameCB
            // 
            this.CustnameCB.AutoSize = true;
            this.CustnameCB.Location = new System.Drawing.Point(23, 63);
            this.CustnameCB.Name = "CustnameCB";
            this.CustnameCB.Size = new System.Drawing.Size(104, 17);
            this.CustnameCB.TabIndex = 10;
            this.CustnameCB.Text = "Customer Name:";
            this.CustnameCB.UseVisualStyleBackColor = true;
            this.CustnameCB.CheckedChanged += new System.EventHandler(this.CustnameCB_CheckedChanged);
            // 
            // CustnameTB
            // 
            this.CustnameTB.Location = new System.Drawing.Point(142, 60);
            this.CustnameTB.Name = "CustnameTB";
            this.CustnameTB.Size = new System.Drawing.Size(183, 20);
            this.CustnameTB.TabIndex = 8;
            this.CustnameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTB_KeyPress);
            // 
            // CheckinDTP
            // 
            this.CheckinDTP.Enabled = false;
            this.CheckinDTP.Location = new System.Drawing.Point(142, 86);
            this.CheckinDTP.Name = "CheckinDTP";
            this.CheckinDTP.Size = new System.Drawing.Size(183, 20);
            this.CheckinDTP.TabIndex = 7;
            // 
            // CustidTB
            // 
            this.CustidTB.Location = new System.Drawing.Point(142, 34);
            this.CustidTB.Name = "CustidTB";
            this.CustidTB.Size = new System.Drawing.Size(183, 20);
            this.CustidTB.TabIndex = 6;
            this.CustidTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTB_KeyPress);
            // 
            // CheckinCB
            // 
            this.CheckinCB.AutoSize = true;
            this.CheckinCB.Location = new System.Drawing.Point(23, 89);
            this.CheckinCB.Name = "CheckinCB";
            this.CheckinCB.Size = new System.Drawing.Size(95, 17);
            this.CheckinCB.TabIndex = 1;
            this.CheckinCB.Text = "Check In Time";
            this.CheckinCB.UseVisualStyleBackColor = true;
            this.CheckinCB.CheckedChanged += new System.EventHandler(this.CheckinCB_CheckedChanged);
            // 
            // CustomerCB
            // 
            this.CustomerCB.AutoSize = true;
            this.CustomerCB.Checked = true;
            this.CustomerCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CustomerCB.Location = new System.Drawing.Point(23, 37);
            this.CustomerCB.Name = "CustomerCB";
            this.CustomerCB.Size = new System.Drawing.Size(87, 17);
            this.CustomerCB.TabIndex = 0;
            this.CustomerCB.Text = "Customer ID:";
            this.CustomerCB.UseVisualStyleBackColor = true;
            this.CustomerCB.CheckedChanged += new System.EventHandler(this.CustomerCB_CheckedChanged);
            // 
            // SearchB
            // 
            this.SearchB.Location = new System.Drawing.Point(32, 139);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(75, 23);
            this.SearchB.TabIndex = 8;
            this.SearchB.Text = "Search";
            this.SearchB.UseVisualStyleBackColor = true;
            this.SearchB.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // ShowAllB
            // 
            this.ShowAllB.Location = new System.Drawing.Point(113, 139);
            this.ShowAllB.Name = "ShowAllB";
            this.ShowAllB.Size = new System.Drawing.Size(75, 23);
            this.ShowAllB.TabIndex = 10;
            this.ShowAllB.Text = "Show All";
            this.ShowAllB.UseVisualStyleBackColor = true;
            this.ShowAllB.Click += new System.EventHandler(this.ShowAllB_Click);
            // 
            // CustomerRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 452);
            this.Controls.Add(this.ShowAllB);
            this.Controls.Add(this.SearchB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CustomerRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Record";
            this.Load += new System.EventHandler(this.CustomerRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker CheckinDTP;
        private System.Windows.Forms.TextBox CustidTB;
        private System.Windows.Forms.CheckBox CheckinCB;
        private System.Windows.Forms.CheckBox CustomerCB;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.TextBox CustnameTB;
        private System.Windows.Forms.Button ShowAllB;
        private System.Windows.Forms.CheckBox CustnameCB;
    }
}