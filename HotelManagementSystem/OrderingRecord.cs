using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;
using Microsoft.VisualBasic;

namespace WindowsFormsApplication1
{
    public partial class OrderingRecord : Form
    {
        public OrderingRecord()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String stringconn = "Data Source = 127.0.0.1; userid='root'; password=''; Initial Catalog =hotelsystem";
            MySqlConnection sqlconn = new MySqlConnection(stringconn);
            MySqlCommand sqlcomm = new MySqlCommand();
            MySqlDataAdapter sqlDA = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            sqlconn.Open();
            sqlcomm.CommandText = "SELECT * FROM hotelordering";
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandType = CommandType.Text;
            sqlDA.SelectCommand = sqlcomm;
            sqlDA.Fill(ds, "Result");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Result";
            sqlconn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String stringconn = "Data Source = 127.0.0.1; userid='root'; password=''; Initial Catalog =hotelsystem";
            MySqlConnection sqlconn = new MySqlConnection(stringconn);
            MySqlCommand sqlcomm = new MySqlCommand();
            MySqlDataAdapter sqlDA = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            sqlconn.Open();
            sqlcomm.CommandText = "SELECT * FROM hotelordering";
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandType = CommandType.Text;
            sqlDA.SelectCommand = sqlcomm;
            sqlDA.Fill(ds, "Result");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Result";
            sqlconn.Close();
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    row.Height = 80;
            //}
        }
    }
}
