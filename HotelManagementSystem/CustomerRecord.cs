﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1
{
    public partial class CustomerRecord : Form
    {
        public CustomerRecord()
        {
            InitializeComponent();
        }

        #region VARIABLES
        CRUD crud = new CRUD();
        SaltAndHashGenerator shg = new SaltAndHashGenerator();
        public static Regex allowedKeys = new Regex(@"[^a-zA-Z0-9\b]");
        public const String stringconn = "Data Source = 127.0.0.1; userid = 'root'; password = ''; Initial Catalog = hotelsystem";
        #endregion

        void searchSN()
        {
            try
            {
                MySqlConnection sqlconn = new MySqlConnection(stringconn);
                MySqlCommand sqlcomm = new MySqlCommand();
                //MySqlDataReader sqlDR;
                sqlconn.Open();
                //sqlcomm.Connection = sqlconn;
                String query = "SELECT * FROM customerrecord WHERE CustomerID = '" + CustidTB.Text + "' , CustomerName = '" + CustnameTB.Text + "'";
                //sqlcomm.CommandText = query;
                //sqlcomm.CommandType = CommandType.Text;
                //sqlDR = sqlcomm.ExecuteReader();
                //sqlDR.Read();
                MySqlCommand sqlCommand = new MySqlCommand(query, sqlconn);
                MySqlDataAdapter sqlDataA = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                sqlDataA.SelectCommand = sqlCommand;
                sqlDataA.Fill(ds, "result");
                DGV.DataSource = ds;
                DGV.DataMember = "result";
                sqlconn.Close();
            }
            catch
            {
                MessageBox.Show("Invalid Input!");
                CustidTB.Clear();
                CustnameTB.Clear();
            }
        }
        public void displayRecordsInDGV()
        {
            String query = "SELECT * FROM customerrecord";
            MySqlConnection sqlconn = new MySqlConnection(stringconn);
            sqlconn.Open();
            MySqlCommand sqlCommand = new MySqlCommand(query, sqlconn);
            MySqlDataAdapter sqlDataA = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            sqlDataA.SelectCommand = sqlCommand;
            sqlDataA.Fill(ds, "result");
            DGV.DataSource = ds;
            DGV.DataMember = "result";
            sqlconn.Close();
        }

        private void CustomerRecord_Load(object sender, EventArgs e)
        {
            //MDIParent1 mdi = new MDIParent1();
            //this.Size = mdi.Size;
            displayRecordsInDGV();
        }

        private void SearchTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (allowedKeys.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                searchSN();
            }
        }

        private void CustomerCB_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomerCB.Checked == true)
            {
                CustidTB.Enabled = true;
            }
            else
                CustidTB.Enabled = false;
        }

        private void ShowAllB_Click(object sender, EventArgs e)
        {
            displayRecordsInDGV();
        }


        private void CheckinCB_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckinCB.Checked == true)
            {
                CheckinDTP.Enabled = true;
            }
            else
                CheckinDTP.Enabled = false;
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            if (CustidTB.Text == "")
            {
                displayRecordsInDGV();
            }
            else
            {
                searchSN();
            }
            
        }

        private void CustnameCB_CheckedChanged(object sender, EventArgs e)
        {
            if (CustnameCB.Checked == true)
            {
                CustnameTB.Enabled = true;
            }
            else
                CustnameTB.Enabled = false;
        }
    }
}
