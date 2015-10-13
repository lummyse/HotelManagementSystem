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
    public partial class UserAccounts : Form
    {
        public UserAccounts()
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

        private void addAccountBt_Click(object sender, EventArgs e)
        {
            if (usernameAddTb.TextLength == 0 || password1AddTb.TextLength == 0 || password2AddTb.TextLength == 0)
            {
                MessageBox.Show("Please complete all fields");
            }
            else
            {
                addRecord();
            }
        }
        private void editLoadBt_Click(object sender, EventArgs e)
        {
            if (usernameEditTb.TextLength == 0)
            {
                MessageBox.Show("Enter username");
            }
            else
            {
                loadDetails();
            }
        }
        private void passEditBt_Click(object sender, EventArgs e)
        {
            password1EditTb.Enabled = true;
            password2EditTb.Enabled = true;
            willChangePassword = true;
        }
        private void editBt_Click(object sender, EventArgs e)
        {
            editRecord();
        }
        private void deleteBt_Click(object sender, EventArgs e)
        {
            if (usernameDeleteTb.TextLength == 0)
            {
                MessageBox.Show("Enter username");
            }
            else
            {
                deleteRecord();
            }
        }

        private void usernameEditTb_TextChanged(object sender, EventArgs e)
        {
            oldPasswordLabel.Visible = false;
            oldPasswordTb.Visible = false;
            oldPasswordTb.Enabled = false;
            password1EditTb.Visible = false;
            password1EditTb.Enabled = false;
            password1Label.Visible = false;
            password2EditTb.Visible = false;
            password2EditTb.Enabled = false;
            password2Label.Visible = false;
            accountTypeGb.Visible = false;
            editLoadBt.Visible = true;
            changePasswordCb.Visible = false;
            changePasswordCb.Checked = false;
            editBt.Visible = false;
        }
        private void changePasswordCb_CheckStateChanged(object sender, EventArgs e)
        {
            if (changePasswordCb.Checked)
            {
                oldPasswordTb.Enabled = true;
                password1EditTb.Enabled = true;
                password2EditTb.Enabled = true;
                willChangePassword = true;
            }
            else
            {
                oldPasswordTb.Enabled = false;
                password1EditTb.Enabled = false;
                password2EditTb.Enabled = false;
                willChangePassword = false;
            }
        }
        private void adminEditRd_CheckedChanged(object sender, EventArgs e)
        {
            if (adminEditRd.Checked)
            {
                accountTypeNo = 1;
            }
        }
        private void employeeEditRd_CheckedChanged(object sender, EventArgs e)
        {
            if (employeeEditRd.Checked)
            {
                accountTypeNo = 0;
            }
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
        public void displayRecordsInDGV()
        {
            String query = "SELECT * FROM useraccounts";
            MySqlConnection sqlconn = new MySqlConnection(stringconn);
            sqlconn.Open();
            MySqlCommand sqlCommand = new MySqlCommand(query, sqlconn);
            MySqlDataAdapter sqlDataA = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            sqlDataA.SelectCommand = sqlCommand;
            sqlDataA.Fill(ds, "result");
            accountsDataGridView.DataSource = ds;
            accountsDataGridView.DataMember = "result";
            sqlconn.Close();
        }

        private void addRecord()
        {
            String username = usernameAddTb.Text;
            String query = "SELECT Username FROM useraccounts WHERE Username ='" + username + "'";

            if (crud.isExistingRecord(stringconn, query))
            {
                MessageBox.Show("Invalid Username");
            }
            else
            {
                String password1 = password1AddTb.Text;
                String password2 = password2AddTb.Text;

                if (password1.Equals(password2))
                {
                    int permissionNo = 0;
                    byte[] salt = shg.generateSalt(saltByteSize);
                    byte[] hash = shg.generateHash(password1, salt, hashingIterations, hashByteSize);
                    String finalHash = Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
                    if (adminAddRb.Checked)
                    {
                        permissionNo = 1;
                    }

                    query = "INSERT INTO useraccounts VALUES('" + username + "','" + password1 + "','" + finalHash + "','" + permissionNo + "')";
                    String message = "Account Registered!";
                    crud.addRecord(stringconn, query, message);
                    clearAllText(this);
                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                }
            }
            displayRecordsInDGV();
        }
        private void editRecord()
        {
            String username = usernameEditTb.Text;
            String query = "SELECT * FROM useraccounts WHERE Username = '" + username + "'";
            if (willChangePassword)
            {
                String password1 = password1EditTb.Text;
                String password2 = password2EditTb.Text;
                String[] userDetails = crud.getRecordRowDetails(stringconn, query, 4);
                String oldPasswordInDB = userDetails[1];
                String oldPassword = oldPasswordTb.Text;

                if (oldPasswordTb.TextLength == 0 || password1EditTb.TextLength == 0 || password2EditTb.TextLength == 0)
                {
                    MessageBox.Show("Incomplete fields");
                    return;
                }
                if(!oldPassword.Equals(oldPasswordInDB)){
                    MessageBox.Show("Old password entered does not match registered password in database");
                    return;
                }
                if (!password1.Equals(password2))
                {
                    MessageBox.Show("Passwords don't match");
                    return;
                }

                byte[] salt = shg.generateSalt(saltByteSize);
                byte[] hash = shg.generateHash(password1, salt, hashingIterations, hashByteSize);
                String finalHash = Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
                query = "UPDATE useraccounts SET Password = '" + password1 + "', Hashed_Password = '" + finalHash + "', Full_Permission = '" + accountTypeNo + "' WHERE Username = '" + username + "'";
            }
            else
            {
                query = "UPDATE useraccounts SET Full_Permission = '" + accountTypeNo + "' WHERE Username = '" + username + "'";
            }
            crud.addRecord(stringconn, query, "Details successfully edited!");
            displayRecordsInDGV();
            clearAllText(this);
        }
        private void deleteRecord()
        {
            String username = usernameDeleteTb.Text;
            String query = "SELECT * FROM useraccounts WHERE Username='" + username + "'";
            if (crud.isExistingRecord(stringconn, query))
            {
                query = "DELETE FROM useraccounts WHERE Username='" + username + "'";
                crud.deleteRecord(stringconn, query, "User Deleted!");
                displayRecordsInDGV();
                clearAllText(this);
            }
            else
            {
                MessageBox.Show("Username doesn't exist");
            }
        }
        private void loadDetails()
        {
            String username = usernameEditTb.Text;
            String query = "SELECT * from useraccounts WHERE Username='" + username + "'";
            if (crud.isExistingRecord(stringconn, query))
            {
                String[] userDetails = crud.getRecordRowDetails(stringconn, query, 4);
                hasPermission = bool.Parse(userDetails[3]);
                if (hasPermission)
                {
                    adminEditRd.Checked = true;
                }
                else
                {
                    employeeEditRd.Checked = true;
                }
                oldPasswordLabel.Visible = true;
                oldPasswordTb.Visible = true;
                password1EditTb.Visible = true;
                password1Label.Visible = true;
                password2EditTb.Visible = true;
                password2Label.Visible = true;
                accountTypeGb.Visible = true;
                editLoadBt.Visible = false;
                changePasswordCb.Visible = true;
                editBt.Visible = true;
            }
            else
            {
                MessageBox.Show("Username doesn't exists");
            }
        }

        #region KEYPRESS EVENTS
        private void usernameAddTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (allowedKeys.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                addRecord();
            }
        }
        private void password1AddTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (allowedKeys.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                addRecord();
            }
        }
        private void password2AddTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (allowedKeys.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                addRecord();
            }
        }

        private void usernameEditTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (allowedKeys.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                loadDetails();
            }
        }
        private void oldPasswordTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (allowedKeys.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                editRecord();
            }
        }
        private void password1EditTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (allowedKeys.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                editRecord();
            }
        }
        private void password2EditTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (allowedKeys.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                editRecord();
            }
        }

        private void usernameDeleteTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (allowedKeys.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                deleteRecord();
            }
        }
        #endregion

        private void UserAccounts_Load(object sender, EventArgs e)
        {
            displayRecordsInDGV();
        }
    }
}
