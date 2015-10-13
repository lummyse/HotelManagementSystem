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
using System.Security.Cryptography;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region VARIABLES
        public static Regex allowedKeys = new Regex(@"[^a-zA-Z0-9\b]");
        public const String stringconn = "Data Source = 127.0.0.1; userid = 'root'; password = ''; Initial Catalog = hotelsystem";
        public const int saltByteSize = 16;
        public const int hashByteSize = 20;
        public const int hashingIterations = 100000;
        private double opacity = 0.095;
        SaltAndHashGenerator shg = new SaltAndHashGenerator();
        CRUD crud = new CRUD();
        #endregion
            
        private Boolean checkUserExists()
        {
            string username = usernameTb.Text;
            String command = "SELECT * FROM useraccounts WHERE Username ='" + username + "'";
            return crud.isExistingRecord(stringconn, command);
        }
        private Boolean checkPasswordsMatch(String givenPassword, String passwordInDb)
        {
            //split hashed password in DB
            char[] delimiter = { ':' };
            string[] split = passwordInDb.Split(delimiter);
            byte[] salt = Convert.FromBase64String(split[0]);
            byte[] storedHash = Convert.FromBase64String(split[1]);

            //generate hash for the password given
            byte[] newHash = shg.generateHash(givenPassword, salt, hashingIterations, hashByteSize);
            
            //compare the two hashes
            var diff = (uint)newHash.Length ^ (uint)storedHash.Length;
            for (var i = 0; (i < newHash.Length) && (i < storedHash.Length); i++)
            {
                diff |= (uint)(newHash[i] ^ storedHash[i]);
            }
            return diff == 0;
        }
        private String getDBPassword()
        {
            string username = usernameTb.Text;
            MySqlConnection sqlconn = new MySqlConnection(stringconn);
            MySqlCommand sqlCommand = new MySqlCommand();
            MySqlDataReader sqlDataR;
            sqlconn.Open();
            sqlCommand.CommandText = "SELECT Hashed_Password FROM useraccounts WHERE Username = '" + username + "'";
            sqlCommand.Connection = sqlconn;
            sqlCommand.CommandType = CommandType.Text;
            sqlDataR = sqlCommand.ExecuteReader();
            sqlDataR.Read();
            String dbPass = sqlDataR[0].ToString();
            sqlconn.Close();
            return dbPass;
        }
    
        private void createAdminB_Click(object sender, EventArgs e)
        {
            byte[] salt = shg.generateSalt(saltByteSize);
            String password = "admin";
            byte[] hash = shg.generateHash(password, salt, hashingIterations, hashByteSize);
            String finalHash = Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
            MySqlConnection sqlconn = new MySqlConnection(stringconn);
            MySqlCommand sqlCommand = new MySqlCommand();
            sqlconn.Open();
            sqlCommand.CommandText = "INSERT INTO useraccounts VALUES('admin','admin','" + finalHash + "', 1)";
            sqlCommand.Connection = sqlconn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Admin account created");
            sqlconn.Close();
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            performLogin();
        }
        private void performLogin()
        {
            if ((usernameTb.TextLength == 0) || (passwordTb.TextLength == 0))
            {
                MessageBox.Show("Please Fill All Blanks");
                return;
            }

            if (checkUserExists())
            {
                String password = passwordTb.Text;
                byte[] salt = shg.generateSalt(saltByteSize);
                byte[] hash = shg.generateHash(password, salt, hashingIterations, hashByteSize);

                String finalHash = Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
                var dbPassword = getDBPassword();



                if (checkPasswordsMatch(password, dbPassword))
                {
                    MessageBox.Show("Access Granted");
                    String username = usernameTb.Text;
                    String query = "SELECT * FROM useraccounts WHERE Username='" + username + "'";
                    String[] userDetails = crud.getRecordRowDetails(stringconn, query, 4);
                    bool hasPermission = bool.Parse(userDetails[3]);
                    if (hasPermission)
                    {
                        MDIParent1 mdiparent = new MDIParent1();
                        mdiparent.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Access Denied");
                }
            }
            else
            {
                MessageBox.Show("User does not exist");
            }   
        }
        #region KEYPRESS EVENTS
        private void usernameTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (allowedKeys.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                performLogin();
            }
        }
        private void passwordTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (allowedKeys.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                performLogin();
            }
        }
        #endregion 

        private void Login_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            fadeInTimer.Interval = 100;
            fadeInTimer.Start();
        }
        private void fadeInTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += opacity;
            }
            else
            {
                fadeInTimer.Stop();
            }
        }

    }
}
