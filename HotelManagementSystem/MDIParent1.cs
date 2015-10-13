using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class MDIParent1 : Form
    {

        public MDIParent1()
        {
            InitializeComponent();
        }

        #region VARIABLES
        Login login = new Login();
        #endregion

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClosePrevChildForm()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void CustomerTS_Click(object sender, EventArgs e)
        {
            ClosePrevChildForm();
            CustomerRecord customerrecord = new CustomerRecord();
            customerrecord.MdiParent = this;
            customerrecord.Show();
        }

        private void EmployeeTS_Click(object sender, EventArgs e)
        {
            ClosePrevChildForm();
            UserAccounts employeerecord = new UserAccounts();
            employeerecord.MdiParent = this;
            employeerecord.Show();
            
        }

        private void LogoutTS_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void RoomTS_Click(object sender, EventArgs e)
        {
            ClosePrevChildForm();
            Rooms room = new Rooms();
            room.MdiParent = this;
            room.Show();
            
        }

        private void CheckinTS_Click(object sender, EventArgs e)
        {
            ClosePrevChildForm();
            CheckIn checkin = new CheckIn();
            checkin.MdiParent = this;
            checkin.Show();
            
        }

        private void DatetimeT_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        //Irish
        private void employeeAccountsTS_Click(object sender, EventArgs e)
        {
            ClosePrevChildForm();
            UserAccounts employeeAccounts = new UserAccounts();
            employeeAccounts.MdiParent = this;
            employeeAccounts.Size = this.Size;
            employeeAccounts.Show();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            if (!login.adminPriviledges)
            {
                administratorToolStripMenuItem.Visible = false;
                EmployeeTS.Enabled = false;
                InventoryTS.Enabled = false;
                setRoomPriceToolStripMenuItem.Enabled = false;
            }
        }
    }
}
