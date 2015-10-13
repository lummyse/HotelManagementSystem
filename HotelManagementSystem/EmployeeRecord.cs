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
    public partial class EmployeeRecord : Form
    {
        public EmployeeRecord()
        {
            InitializeComponent();
        }
        #region VARIABLES
        CRUD crud = new CRUD();
        SaltAndHashGenerator shg = new SaltAndHashGenerator();
        public static Regex allowedKeys = new Regex(@"[^a-zA-Z0-9\b]");
        public const String stringconn = "Data Source = 127.0.0.1; userid = 'root'; password = ''; Initial Catalog = hotelsystem";
        public const int saltByteSize = 16;
        public const int hashByteSize = 20;
        public const int hashingIterations = 100000;
        public bool willChangePassword = false;
        public bool hasPermission;
        public int accountTypeNo;
        #endregion

        public void addrecord()
        {
            String stringconn = "Data Source=localhost; userid='root'; password=''; initial Catalog=hotelsystem";
            MySqlConnection sqlconn = new MySqlConnection(stringconn);
            MySqlCommand sqlcomm = new MySqlCommand();

            sqlconn.Open();
            sqlcomm.CommandText = "INSERT INTO employeerecord VALUES('" + EmpidTB.Text + "','" + EmpnameTB.Text + "','" + EmppositionCB.Text + 
                "','" + CivilstatusCB.Text + "','" + GenderCB.Text + "','" + AgeNUD.Text + "','" + AddressTB.Text + "','" + EmailTB.Text + 
                "','" + ContactnoTB.Text + "','" + RnameTB.Text + "','" + RcontactnoTB.Text + "','" + RelationTB.Text + "','";
            sqlcomm.CommandType = CommandType.Text;
            sqlcomm.Connection = sqlconn;
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
            MessageBox.Show("Record Saved!");
            reset();

        }

        public void displayRecordsInDGV()
        {
            String query = "SELECT * FROM employeerecord";
            MySqlConnection sqlconn = new MySqlConnection(stringconn);
            sqlconn.Open();
            MySqlCommand sqlCommand = new MySqlCommand(query, sqlconn);
            MySqlDataAdapter sqlDataA = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            sqlDataA.SelectCommand = sqlCommand;
            sqlDataA.Fill(ds, "result");
            EmprecordDGV.DataSource = ds;
            EmprecordDGV.DataMember = "result";
            sqlconn.Close();
        }

        public void reset()
        {
            EmpidTB.Clear();
            EmpnameTB.Clear();
            EmppositionCB.Text = "";
            CivilstatusCB.Text = "";
            GenderCB.Text = "";
            AgeNUD.ResetText();
            AddressTB.Clear();
            EmailTB.Clear();
            ContactnoTB.Clear();
            RnameTB.Clear();
            RcontactnoTB.Clear();
            RelationTB.Clear();
        }
        public void opensesame()
        {
 
        }


        private void AddB_Click(object sender, EventArgs e)
        {
            addrecord();
        }

        private void UpdateB_Click(object sender, EventArgs e)
        {

        }

        private void EmprecordDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpidTB.Text = EmprecordDGV.CurrentRow.Cells[0].Value.ToString();
            EmpnameTB.Text = EmprecordDGV.CurrentRow.Cells[1].Value.ToString();
            EmppositionCB.Text = EmprecordDGV.CurrentRow.Cells[2].Value.ToString();
            CivilstatusCB.Text = EmprecordDGV.CurrentRow.Cells[3].Value.ToString();
            GenderCB.Text = EmprecordDGV.CurrentRow.Cells[4].Value.ToString();
            AgeNUD.Value.ToString(EmprecordDGV.CurrentRow.Cells[5].Value.ToString());
            AddressTB.Text = EmprecordDGV.CurrentRow.Cells[6].Value.ToString();
            EmailTB.Text = EmprecordDGV.CurrentRow.Cells[7].Value.ToString();
            ContactnoTB.Text = EmprecordDGV.CurrentRow.Cells[8].Value.ToString();
            RnameTB.Text = EmprecordDGV.CurrentRow.Cells[9].Value.ToString();
            RcontactnoTB.Text = EmprecordDGV.CurrentRow.Cells[10].Value.ToString();
            RelationTB.Text = EmprecordDGV.CurrentRow.Cells[11].Value.ToString();
        }

        private void EmployeeRecord_Load(object sender, EventArgs e)
        {
            displayRecordsInDGV();
        }

    }
}
