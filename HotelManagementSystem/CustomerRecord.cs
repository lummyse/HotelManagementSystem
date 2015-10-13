using System;
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
        public static Regex allowedKeys = new Regex(@"[^a-zA-Z0-9\b]");
        public static Regex alphabetonly = new Regex(@"[^a-zA-Z\b]");
        public static Regex numbersonly = new Regex(@"[^0-9\b]");
        private void SearchB_Click(object sender, EventArgs e)
        {
            if (SearchTB.Text == "")
            {
                displayRecordsInDGV();
            }
            else
            {
                searchSN();
            }
            
        }
        void searchSN()
        {
            String stringconn = "Data Source=localhost; userid='root'; password=''; initial Catalog=hotelsystem";
            MySqlConnection sqlconn = new MySqlConnection(stringconn);
            MySqlCommand sqlcomm = new MySqlCommand();
            //MySqlDataReader sqlDR;

            sqlconn.Open();
            //sqlcomm.Connection = sqlconn;
            String query = "SELECT * FROM customerrecord WHERE Lastname = '" + SearchTB.Text + "'";
            
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
        public void displayRecordsInDGV()
        {
            String query = "SELECT * FROM customerrecord";
            String stringconn = "Data Source = 127.0.0.1; userid = 'root'; password = ''; Initial Catalog = hotelsystem";
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
    }
}
