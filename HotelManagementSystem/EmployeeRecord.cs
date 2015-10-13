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
            String id = EmpidTB.Text;
            String name = EmpnameTB.Text;
            String position = EmppositionCB.Text;
            String status = CivilstatusCB.Text;
            String gender = GenderCB.Text;
            String age = AgeNUD.Text;
            String address = AddressTB.Text;
            String email = EmailTB.Text;
            String contactNo = ContactnoTB.Text;
            String rname = RnameTB.Text;
            String rcontactNo = RcontactnoTB.Text;
            String relation = RelationTB.Text;
            String query = "SELECT EmployeeName FROM employeerecord WHERE EmployeeName ='" + EmpnameTB.Text + "'";

            if (crud.isExistingRecord(stringconn, query))
            {
                MessageBox.Show("This record exists already");
            }
            else
            {
                query = "INSERT INTO employeerecord VALUES('" + id + "','" + name + "','" + position +
                "','" + status + "','" + gender + "','" + age + "','" + address + "','" + email +
                "','" + contactNo + "','" + rname + "','" + rcontactNo + "','" + relation + "','";
                String message = "Record Added!";
                crud.addRecord(stringconn, query, message);
                clearAllText(this);
            }
        }
        private void editRecord()
        {
            String id = EmpidTB.Text;
            String name = EmpnameTB.Text;
            String position = EmppositionCB.Text;
            String status = CivilstatusCB.Text;
            String gender = GenderCB.Text;
            String age = AgeNUD.Text;
            String address = AddressTB.Text;
            String email = EmailTB.Text;
            String contactNo = ContactnoTB.Text;
            String rname = RnameTB.Text;
            String rcontactNo = RcontactnoTB.Text;
            String relation = RelationTB.Text;
            String empName = EmpnameTB.Text;
            String query = "SELECT * FROM employeerecord WHERE EmployeeName = '" + empName + "'";
            if (crud.isExistingRecord(stringconn, query))
            {
                query = "UPDATE employeerecord SET EmployeeID = '" + id + "', EmployeePosition = '" + position +
                        "', Status = '" + status + "', Gender = '" + gender + "', Age = '" + age +
                        "', Address = '" + address + "', Email = '" + email + "', ContactNo = '" + contactNo +
                        "', RName = '" + rname + "', RContact = '" + rcontactNo + "', Relation = '" + relation + "'";
                crud.addRecord(stringconn, query, "Record Updated");
                displayRecordsInDGV();
                clearAllText(this);
            }
            else
            {
                MessageBox.Show("Enter a valid username");
            }
        }
        private void deleteRecord()
        {
            String name = EmpnameTB.Text;
            String query = "SELECT * FROM employeerecord WHERE EmployeeName='" + name + "'";
            if (crud.isExistingRecord(stringconn, query))
            {
                query = "DELETE FROM employeerecord WHERE EmployeeName='" + name + "'";
                crud.deleteRecord(stringconn, query, "Record Deleted!");
                displayRecordsInDGV();
                clearAllText(this);
            }
            else
            {
                MessageBox.Show("Username doesn't exist");
            }
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

        public void clearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    clearAllText(c);
            }
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
