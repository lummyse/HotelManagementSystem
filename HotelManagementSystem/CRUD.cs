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
    class CRUD
    {
        //CHECKS IF A RECORD EXISTS
        public bool isExistingRecord(String connection, String query)
        {
            MySqlConnection sqlconn = new MySqlConnection(connection);
            MySqlCommand sqlCommand = new MySqlCommand();
            MySqlDataReader sqlDataR;
            sqlconn.Open();
            sqlCommand.CommandText = query;
            sqlCommand.Connection = sqlconn;
            sqlCommand.CommandType = CommandType.Text;
            sqlDataR = sqlCommand.ExecuteReader();
            if (sqlDataR.HasRows)
            {
                sqlconn.Close();
                return true;
            }
            sqlconn.Close();
            return false;
        }

        public void addRecord(String connection, String query, String message)
        {
            try
            {
                MySqlConnection sqlconn = new MySqlConnection(connection);
                sqlconn.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, sqlconn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show(message);
                sqlconn.Close();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public String[] getRecordRowDetails(String connection, String query, int noOfColumns)
        {
            MySqlConnection sqlconn = new MySqlConnection(connection);
            MySqlCommand sqlCommand = new MySqlCommand(query, sqlconn);
            MySqlDataReader sqlDataR;
            String[] rowDetails = new String[noOfColumns];
            sqlconn.Open();
            sqlDataR = sqlCommand.ExecuteReader();
            sqlDataR.Read();
            for (int i = 0; i < sqlDataR.FieldCount; i++)
            {
                rowDetails[i] = sqlDataR[i].ToString();
            }
            sqlconn.Close();
            return rowDetails;
        }
        public void editRecord(String connection, String query, String message)
        {
            try
            {
                MySqlConnection sqlconn = new MySqlConnection(connection);
                sqlconn.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, sqlconn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show(message);
                sqlconn.Close();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void deleteRecord(String connection, String query, String message)
        {
            try
            {
                MySqlConnection sqlconn = new MySqlConnection(connection);
                sqlconn.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, sqlconn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Account Deleted!");
                sqlconn.Close();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
