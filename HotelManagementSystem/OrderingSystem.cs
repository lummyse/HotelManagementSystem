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
    public partial class OrderingSystem : Form
    {
        int total = 0, final, a = 0;
        List<string> totaldish = new List<string>(); // <-- Add this

        public OrderingSystem()
        {
            InitializeComponent();
        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (panzenellaChB.Checked == true)
            {
                italianQtyNUD.Value = 1;
                italianTotalTB.Clear();
                brushettaChB.Checked = false;
                pizzaChB.Checked = false;
                focacciaChB.Checked = false;
                italianItemNameTB.Text = "Panzenella";
                italianPriceTB.Text = "130";
                italianTotalTB.Text = "130";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (brushettaChB.Checked == true)
            {
                italianQtyNUD.Value = 1;

                italianTotalTB.Clear();
                panzenellaChB.Checked = false;
                pizzaChB.Checked = false;
                focacciaChB.Checked = false;
                italianItemNameTB.Text = "Brushetta";
                italianPriceTB.Text = "140";
                italianTotalTB.Text = "140";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (pizzaChB.Checked == true)
            {
                italianQtyNUD.Value = 1;

                brushettaChB.Checked = false;
                panzenellaChB.Checked = false;
                focacciaChB.Checked = false;
                italianItemNameTB.Text = "Margherita Pizza";
                italianPriceTB.Text = "250";
                italianTotalTB.Text = "250";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (focacciaChB.Checked == true)
            {
                italianQtyNUD.Value = 1;

                brushettaChB.Checked = false;
                pizzaChB.Checked = false;
                panzenellaChB.Checked = false;
                italianItemNameTB.Text = "Focaccia Bread";
                italianPriceTB.Text = "120";
                italianTotalTB.Text = "120";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (menudoChB.Checked == true)
            {
                //     int a;
                pinoyQtyNUD.Value = 1;
                sinigangChB.Checked = false;
                adoboChB.Checked = false;
                bicolChB.Checked = false;
                pinoyItemNameTB.Text = "Filipino Menudo";
                pinoyPriceTB.Text = "120";
                pinoyTotalTB.Text = "120";
                // a = int.Parse(numericUpDown2.Text) * int.Parse(textBox9.Text);
                //textBox1.Text = a.ToString();

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (sinigangChB.Checked == true)
            {
                pinoyQtyNUD.Value = 1;
                menudoChB.Checked = false;
                adoboChB.Checked = false;
                bicolChB.Checked = false;
                pinoyItemNameTB.Text = "Sinigang";
                pinoyPriceTB.Text = "130";
                pinoyTotalTB.Text = "130";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (adoboChB.Checked == true)
            {
                pinoyQtyNUD.Value = 1;
                menudoChB.Checked = false;
                sinigangChB.Checked = false;
                bicolChB.Checked = false;
                pinoyItemNameTB.Text = "Adobo";
                pinoyPriceTB.Text = "140";
                pinoyTotalTB.Text = "140";
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (bicolChB.Checked == true)
            {
                pinoyQtyNUD.Value = 1;
                menudoChB.Checked = false;
                sinigangChB.Checked = false;
                adoboChB.Checked = false;
                pinoyItemNameTB.Text = "Bicol Express";
                pinoyPriceTB.Text = "140";
                pinoyTotalTB.Text = "140";
            }
        }

        private void pinoyCancelB_Click(object sender, EventArgs e)
        {
            pinoyQtyNUD.Value = 1;
            menudoChB.Checked = false;
            sinigangChB.Checked = false;
            adoboChB.Checked = false;
            bicolChB.Checked = false;
            pinoyItemNameTB.Clear();
            pinoyTotalTB.Clear();

            pinoyPriceTB.Clear();
        }

        private void italianCancelB_Click(object sender, EventArgs e)
        {
            italianQtyNUD.Value = 1;

            focacciaChB.Checked = false;
            pizzaChB.Checked = false;
            brushettaChB.Checked = false;
            panzenellaChB.Checked = false;
            italianTotalTB.Clear();
            italianItemNameTB.Clear();
            italianPriceTB.Clear();
        }

        private void italianAddB_Click(object sender, EventArgs e)
        {
            int a = int.Parse(italianTotalTB.Text) + int.Parse(totalTB.Text);
            totalTB.Text = a.ToString();
            int numeric1 = (int)italianQtyNUD.Value;
            int numeric2 = (int)pinoyQtyNUD.Value;
            italianAddB.Enabled = false;
            italianCancelB.Enabled = false;
            orderLB.Items.Add("Name:" + roomNoCB.Text + "      Dish: " + italianItemNameTB.Text + "    Quantity: " + numeric1 + "    price: " + italianPriceTB.Text + "      Total:  " + italianTotalTB.Text);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int numeric1 = (int)italianQtyNUD.Value;
            int numeric2 = (int)pinoyQtyNUD.Value;

            italianTotalTB.Text = (int.Parse(italianPriceTB.Text) * numeric1) + "";
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int numeric1 = (int)italianQtyNUD.Value;
            int numeric2 = (int)pinoyQtyNUD.Value;

            pinoyTotalTB.Text = (int.Parse(pinoyPriceTB.Text) * numeric2) + "";
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dessertCB.SelectedIndex == 0)
            {

                dessertItemNameTB.Text = "Sundae";
                dessertPriceTB.Text = "35";
                dessertTotalTB.Text = "35";
                dessertSmallChB.Checked = true;
                dessertLargeChB.Enabled = true;
                dessertExLargeChB.Enabled = true;
                dessertMediumChB.Enabled = true;
                dessertSmallChB.Enabled = true;
            }
            if (dessertCB.SelectedIndex == 1)
            {
                dessertItemNameTB.Text = "Cookies'n Cream";
                dessertPriceTB.Text = "45";
                dessertTotalTB.Text = "45";
                dessertSmallChB.Checked = true;
                dessertLargeChB.Enabled = true;
                dessertExLargeChB.Enabled = true;
                dessertMediumChB.Enabled = true;
                dessertSmallChB.Enabled = true;
            }
            if (dessertCB.SelectedIndex == 2)
            {
                dessertItemNameTB.Text = "Black Forest";
                dessertPriceTB.Text = "55";
                dessertTotalTB.Text = "55";
                dessertSmallChB.Checked = true;
                dessertLargeChB.Enabled = true;
                dessertExLargeChB.Enabled = true;
                dessertMediumChB.Enabled = true;
                dessertSmallChB.Enabled = true;
            }
            if (dessertCB.SelectedIndex == 3)
            {
                dessertItemNameTB.Text = "Double Dutch";
                dessertPriceTB.Text = "55";
                dessertTotalTB.Text = "55";
                dessertSmallChB.Checked = true;
                dessertLargeChB.Enabled = true;
                dessertExLargeChB.Enabled = true;
                dessertMediumChB.Enabled = true;
                dessertSmallChB.Enabled = true;
            }
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drinksCB.SelectedIndex == 0)
            {
                drinksTotalTB.Text = "15";
                drinksPriceTB.Text = "15";
                drinksItemNameTB.Text = "Coke";
                drinksSmallChB.Checked = true;
                drinksSmallChB.Enabled = true;
                drinksMediumChB.Enabled = true;
                drinksExLargeChB.Enabled = true;
                drinksLargeChB.Enabled = true;
            }

            if (drinksCB.SelectedIndex == 1)
            {
                drinksTotalTB.Text = "15";
                drinksPriceTB.Text = "15";
                drinksItemNameTB.Text = "Sprite";
                drinksSmallChB.Checked = true;
                drinksSmallChB.Checked = true;
                drinksSmallChB.Enabled = true;
                drinksMediumChB.Enabled = true;
                drinksExLargeChB.Enabled = true;
                drinksLargeChB.Enabled = true;
            }

            if (drinksCB.SelectedIndex == 2)
            {
                drinksTotalTB.Text = "15";
                drinksPriceTB.Text = "15";
                drinksItemNameTB.Text = "Royal";
                drinksSmallChB.Checked = true;
                drinksSmallChB.Checked = true;
                drinksSmallChB.Enabled = true;
                drinksMediumChB.Enabled = true;
                drinksExLargeChB.Enabled = true;
                drinksLargeChB.Enabled = true;
            }
            if (drinksCB.SelectedIndex == 3)
            {
                drinksPriceTB.Text = "5";
                drinksTotalTB.Text = "5";
                drinksItemNameTB.Text = "Water";
                drinksSmallChB.Checked = true;
                drinksSmallChB.Checked = true;
                drinksSmallChB.Enabled = true;
                drinksMediumChB.Enabled = true;
                drinksExLargeChB.Enabled = true;
                drinksLargeChB.Enabled = true;
            }
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (extraCB.SelectedIndex == 0)
            {
                extraTotalTB.Text = "35";
                extraPriceTB.Text = "35";
                extraItemNameTB.Text = "Fries";
                extraSmallChB.Checked = true;
                extraSmallChB.Enabled = true;
                extraMediumChB.Enabled = true;
                extraExLargeChB.Enabled = true;
                extraLargeChB.Enabled = true;
            }
            if (extraCB.SelectedIndex == 1)
            {
                extraTotalTB.Text = "15";
                extraPriceTB.Text = "15";
                extraItemNameTB.Text = "Rice";
                extraCB.Enabled = false;
            }
        }
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            int numeric1 = (int)dessertQtyNUD.Value;


            dessertTotalTB.Text = (int.Parse(dessertPriceTB.Text) * numeric1) + "";
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            int numeric1 = (int)extraQtyNUD.Value;


            extraTotalTB.Text = (int.Parse(extraPriceTB.Text) * numeric1) + "";
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            int numeric1 = (int)drinksQtyNUD.Value;


            drinksTotalTB.Text = (int.Parse(drinksPriceTB.Text) * numeric1) + "";
        }

        private void dessertAddB_Click(object sender, EventArgs e)
        {
            int a = int.Parse(dessertTotalTB.Text) + int.Parse(totalTB.Text);
            totalTB.Text = a.ToString();
            int numeric1 = (int)dessertQtyNUD.Value;
            Object selectedItem = dessertCB.SelectedItem;
            Object chekitem = dessertCB.SelectedItem;
            button6.Enabled = false;
            dessertCancelB.Enabled = false;
            orderLB.Items.Add("Name:" + roomNoCB.Text + "      Deserts: " + selectedItem.ToString() + "      Size: " + dessertSizeTB.Text + "      Quantity: " + numeric1 + "     price: " + dessertPriceTB.Text + "      Total:  " + dessertTotalTB.Text);

        }

        private void pinoyAddB_Click(object sender, EventArgs e)
        {
            int a = int.Parse(pinoyTotalTB.Text) + int.Parse(totalTB.Text);
            totalTB.Text = a.ToString();
            int numeric1 = int.Parse(italianQtyNUD.Text);
            int numeric2 = int.Parse(pinoyQtyNUD.Text);
            pinoyAddB.Enabled = false;
            pinoyCancelB.Enabled = false;
            orderLB.Items.Add("Name:" + roomNoCB.Text + "      Dish: " + pinoyItemNameTB.Text + "      Quantity: " + numeric2 + "     price: " + pinoyPriceTB.Text + "      Total:  " + pinoyTotalTB.Text);

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

            if (dessertSmallChB.Checked == true)
            {
                dessertQtyNUD.Value = 1;
                dessertSizeTB.Text = "Small";
                dessertMediumChB.Checked = false;
                dessertExLargeChB.Checked = false;
                dessertLargeChB.Checked = false;
                dessertPriceTB.Text = (int.Parse(dessertPriceTB.Text) + 0) + "";
                dessertCB.Enabled = false;

            }

            else
            {
                dessertPriceTB.Text = (int.Parse(dessertPriceTB.Text) - 0 + "");

            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (extraLargeChB.Checked == true)
            {
                extraSizeTB.Text = "Large";
                extraQtyNUD.Value = 1;
                extraMediumChB.Checked = false;
                extraExLargeChB.Checked = false;
                extraSmallChB.Checked = false;
                extraPriceTB.Text = (int.Parse(extraPriceTB.Text) + 10) + "";
                extraTotalTB.Text = (int.Parse(extraTotalTB.Text) + 10) + "";

                extraCB.Enabled = false;

            }

            else
            {
                extraPriceTB.Text = (int.Parse(extraPriceTB.Text) - 10 + "");
                extraTotalTB.Text = (int.Parse(extraTotalTB.Text) - 10) + "";


            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (dessertLargeChB.Checked == true)
            {
                dessertQtyNUD.Value = 1;
                dessertSizeTB.Text = "Large";
                dessertMediumChB.Checked = false;
                dessertExLargeChB.Checked = false;
                dessertSmallChB.Checked = false;
                dessertPriceTB.Text = (int.Parse(dessertPriceTB.Text) + 15) + "";
                dessertTotalTB.Text = (int.Parse(dessertTotalTB.Text) + 15) + "";
                dessertCB.Enabled = false;


            }

            else
            {
                dessertPriceTB.Text = (int.Parse(dessertPriceTB.Text) - 15 + "");
                dessertTotalTB.Text = (int.Parse(dessertTotalTB.Text) - 15) + "";


            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (dessertMediumChB.Checked == true)
            {
                dessertQtyNUD.Value = 1;
                dessertSizeTB.Text = "Medium";
                dessertSmallChB.Checked = false;
                dessertExLargeChB.Checked = false;
                dessertLargeChB.Checked = false;
                dessertPriceTB.Text = (int.Parse(dessertPriceTB.Text) + 10) + "";
                dessertTotalTB.Text = (int.Parse(dessertTotalTB.Text) + 10) + "";
                dessertCB.Enabled = false;

            }

            else
            {
                dessertPriceTB.Text = (int.Parse(dessertPriceTB.Text) - 10 + "");
                dessertTotalTB.Text = (int.Parse(dessertTotalTB.Text) - 10) + "";


            }
        }

        private void checkBox11_CheckedChanged_1(object sender, EventArgs e)
        {
            if (dessertExLargeChB.Checked == true)
            {
                dessertQtyNUD.Value = 1;
                dessertSizeTB.Text = "Extra Large";
                dessertSmallChB.Checked = false;
                dessertMediumChB.Checked = false;
                dessertLargeChB.Checked = false;
                dessertPriceTB.Text = (int.Parse(dessertPriceTB.Text) + 20) + "";
                dessertTotalTB.Text = (int.Parse(dessertTotalTB.Text) + 20) + "";
                dessertCB.Enabled = false;

            }

            else
            {
                dessertPriceTB.Text = (int.Parse(dessertPriceTB.Text) - 20 + "");
                dessertTotalTB.Text = (int.Parse(dessertTotalTB.Text) - 20) + "";

            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (drinksSmallChB.Checked == true)
            {

                drinksQtyNUD.Value = 1;
                drinksSizeTB.Text = "Small";
                drinksExLargeChB.Checked = false;
                drinksMediumChB.Checked = false;
                drinksLargeChB.Checked = false;
                drinksPriceTB.Text = (int.Parse(drinksPriceTB.Text) + 0) + "";
                drinksCB.Enabled = false;


            }

            else
            {
                drinksPriceTB.Text = (int.Parse(drinksPriceTB.Text) - 0 + "");


            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (drinksMediumChB.Checked == true)
            {
                drinksSizeTB.Text = "Medium";
                drinksQtyNUD.Value = 1;
                drinksLargeChB.Checked = false;
                drinksExLargeChB.Checked = false;
                drinksSmallChB.Checked = false;
                drinksPriceTB.Text = (int.Parse(drinksPriceTB.Text) + 10) + "";
                drinksTotalTB.Text = (int.Parse(drinksTotalTB.Text) + 10) + "";
                drinksCB.Enabled = false;


            }

            else
            {
                drinksPriceTB.Text = (int.Parse(drinksPriceTB.Text) - 10 + "");
                drinksTotalTB.Text = (int.Parse(drinksTotalTB.Text) - 10) + "";


            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (drinksLargeChB.Checked == true)
            {
                drinksSizeTB.Text = "Large";
                drinksQtyNUD.Value = 1;
                drinksMediumChB.Checked = false;
                drinksExLargeChB.Checked = false;
                drinksSmallChB.Checked = false;
                drinksPriceTB.Text = (int.Parse(drinksPriceTB.Text) + 15) + "";
                drinksTotalTB.Text = (int.Parse(drinksTotalTB.Text) + 15) + "";
                drinksCB.Enabled = false;


            }

            else
            {
                drinksPriceTB.Text = (int.Parse(drinksPriceTB.Text) - 15 + "");
                drinksTotalTB.Text = (int.Parse(drinksTotalTB.Text) - 15) + "";


            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (drinksExLargeChB.Checked == true)
            {
                drinksSizeTB.Text = "Extra Large";
                drinksQtyNUD.Value = 1;
                drinksMediumChB.Checked = false;
                drinksLargeChB.Checked = false;
                drinksSmallChB.Checked = false;
                drinksPriceTB.Text = (int.Parse(drinksPriceTB.Text) + 20) + "";
                drinksTotalTB.Text = (int.Parse(drinksTotalTB.Text) + 20) + "";
                drinksCB.Enabled = false;


            }

            else
            {
                drinksPriceTB.Text = (int.Parse(drinksPriceTB.Text) - 20 + "");
                drinksTotalTB.Text = (int.Parse(drinksTotalTB.Text) - 20) + "";

            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (extraSmallChB.Checked == true)
            {
                extraSizeTB.Text = "Small";
                extraQtyNUD.Value = 1;
                extraMediumChB.Checked = false;
                extraExLargeChB.Checked = false;
                extraLargeChB.Checked = false;
                extraPriceTB.Text = (int.Parse(extraPriceTB.Text) + 0) + "";
                extraCB.Enabled = false;

            }

            else
            {
                extraPriceTB.Text = (int.Parse(extraPriceTB.Text) - 0 + "");

            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (extraExLargeChB.Checked == true)
            {
                extraSizeTB.Text = "Extra Large";
                extraQtyNUD.Value = 1;
                extraMediumChB.Checked = false;
                extraSmallChB.Checked = false;
                extraLargeChB.Checked = false;
                extraPriceTB.Text = (int.Parse(extraPriceTB.Text) + 20) + "";
                extraTotalTB.Text = (int.Parse(extraTotalTB.Text) + 20) + "";

                extraCB.Enabled = false;

            }

            else
            {
                extraPriceTB.Text = (int.Parse(extraPriceTB.Text) - 20 + "");
                extraTotalTB.Text = (int.Parse(extraTotalTB.Text) - 20) + "";

            }
        }

        private void checkBox15_CheckedChanged_1(object sender, EventArgs e)
        {
            if (extraMediumChB.Checked == true)
            {
                extraSizeTB.Text = "Medium";
                extraQtyNUD.Value = 1;
                extraSmallChB.Checked = false;
                extraExLargeChB.Checked = false;
                extraLargeChB.Checked = false;
                extraPriceTB.Text = (int.Parse(extraPriceTB.Text) + 5) + "";
                extraTotalTB.Text = (int.Parse(extraTotalTB.Text) + 5) + "";
                extraCB.Enabled = false;

            }

            else
            {
                extraPriceTB.Text = (int.Parse(extraPriceTB.Text) - 5 + "");
                extraTotalTB.Text = (int.Parse(extraTotalTB.Text) - 5) + "";

            }
        }

        private void dessertCancelB_Click(object sender, EventArgs e)
        {
            dessertQtyNUD.Value = 1;
            dessertCB.SelectedIndex = -1;

            dessertCB.Enabled = true;
            dessertLargeChB.Enabled = false;
            dessertExLargeChB.Enabled = false;
            dessertMediumChB.Enabled = false;
            dessertSmallChB.Enabled = false;
            dessertLargeChB.Checked = false;
            dessertExLargeChB.Checked = false;
            dessertMediumChB.Checked = false;
            dessertSmallChB.Checked = false;
            dessertPriceTB.Clear();
            dessertTotalTB.Clear();
            dessertSizeTB.Clear();
            dessertItemNameTB.Clear();

        }

        private void drinksCancelB_Click(object sender, EventArgs e)
        {
            drinksQtyNUD.Value = 1;
            drinksCB.SelectedIndex = -1;
            drinksCB.Enabled = true;
            drinksSmallChB.Enabled = false;
            drinksMediumChB.Enabled = false;
            drinksExLargeChB.Enabled = false;
            drinksLargeChB.Enabled = false;

            drinksSmallChB.Checked = false;
            drinksMediumChB.Checked = false;
            drinksExLargeChB.Checked = false;
            drinksLargeChB.Checked = false;
            drinksPriceTB.Clear();
            drinksTotalTB.Clear();

        }

        private void extraCancelB_Click(object sender, EventArgs e)
        {
            extraQtyNUD.Value = 1;
            extraCB.Enabled = true;
            extraCB.SelectedIndex = -1;
            extraSmallChB.Enabled = false;
            extraMediumChB.Enabled = false;
            extraExLargeChB.Enabled = false;
            extraLargeChB.Enabled = false;

            extraSmallChB.Checked = false;
            extraMediumChB.Checked = false;
            extraExLargeChB.Checked = false;
            extraLargeChB.Checked = false;
            extraPriceTB.Clear();
            extraTotalTB.Clear();
            extraSizeTB.Clear();
            extraItemNameTB.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OrderingRecord form2 = new OrderingRecord();
            form2.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                orderLB.Items.Add("item:" + i.ToString());
            }
        }

        private void extraAddB_Click(object sender, EventArgs e)
        {
            int a = int.Parse(extraTotalTB.Text) + int.Parse(totalTB.Text);
            totalTB.Text = a.ToString();
            int numeric1 = (int)extraQtyNUD.Value;
            Object selectedItem = extraCB.SelectedItem;
            Object chekitem = extraCB.SelectedItem;
            extraAddB.Enabled = false;
            extraCancelB.Enabled = false;
            orderLB.Items.Add("Name:" + roomNoCB.Text + "      Extra: " + selectedItem.ToString() + "      Quantity: " + numeric1 + "     price: " + extraPriceTB.Text + "      Total:  " + extraTotalTB.Text);

        }

        private void drinksAddB_Click(object sender, EventArgs e)
        {
            int a = int.Parse(drinksTotalTB.Text) + int.Parse(totalTB.Text);
            totalTB.Text = a.ToString();
            int numeric1 = (int)drinksQtyNUD.Value;
            Object selectedItem = drinksCB.SelectedItem;
            Object chekitem = drinksCB.SelectedItem;
            drinksCancelB.Enabled = false;

            drinksAddB.Enabled = false;
            orderLB.Items.Add("Name:" + roomNoCB.Text + "      Drinks: " + selectedItem.ToString() + "      Quantity: " + numeric1 + "     price: " + drinksPriceTB.Text + "      Total:  " + drinksTotalTB.Text);

        }
        private void button12_Click(object sender, EventArgs e)
        {
            pinoyQtyNUD.Value = 1;
            menudoChB.Checked = false;
            sinigangChB.Checked = false;
            adoboChB.Checked = false;
            bicolChB.Checked = false;
            pinoyItemNameTB.Clear();
            pinoyTotalTB.Clear();
            pinoyPriceTB.Clear();
            italianQtyNUD.Value = 1;
            focacciaChB.Checked = false;
            pizzaChB.Checked = false;
            brushettaChB.Checked = false;
            panzenellaChB.Checked = false;
            italianTotalTB.Clear();
            italianItemNameTB.Clear();
            italianPriceTB.Clear();
            dessertQtyNUD.Value = 1;
            dessertCB.SelectedIndex = 4;
            dessertCB.Enabled = true;
            dessertLargeChB.Enabled = false;
            dessertExLargeChB.Enabled = false;
            dessertMediumChB.Enabled = false;
            dessertSmallChB.Enabled = false;
            dessertLargeChB.Checked = false;
            dessertExLargeChB.Checked = false;
            dessertMediumChB.Checked = false;
            dessertSmallChB.Checked = false;
            dessertPriceTB.Clear();
            dessertTotalTB.Clear();
            dessertSizeTB.Clear();
            dessertItemNameTB.Clear();
            extraQtyNUD.Value = 1;
            extraCB.Enabled = true;
            extraCB.SelectedIndex = 2;
            extraSmallChB.Enabled = false;
            extraMediumChB.Enabled = false;
            extraExLargeChB.Enabled = false;
            extraLargeChB.Enabled = false;
            extraSmallChB.Checked = false;
            extraMediumChB.Checked = false;
            extraExLargeChB.Checked = false;
            extraLargeChB.Checked = false;
            extraPriceTB.Clear();
            extraTotalTB.Clear();
            extraSizeTB.Clear();
            extraItemNameTB.Clear();
            drinksQtyNUD.Value = 1;
            drinksCB.SelectedIndex = 4;
            drinksCB.Enabled = true;
            drinksSmallChB.Enabled = false;
            drinksMediumChB.Enabled = false;
            drinksExLargeChB.Enabled = false;
            drinksLargeChB.Enabled = false;
            drinksSmallChB.Checked = false;
            drinksMediumChB.Checked = false;
            drinksExLargeChB.Checked = false;
            drinksLargeChB.Checked = false;
            drinksPriceTB.Clear();
            drinksTotalTB.Clear();
            pinoyAddB.Enabled = true;
            pinoyCancelB.Enabled = true;
            italianCancelB.Enabled = true;
            italianAddB.Enabled = true;
            dessertCancelB.Enabled = true;
            button6.Enabled = true;
            drinksCancelB.Enabled = true;
            drinksAddB.Enabled = true;
            extraCancelB.Enabled = true;
            extraAddB.Enabled = true;
            orderLB.Items.Clear();

        }

        void m_savestock()
        {

            String stringconn = "Data Source = 127.0.0.1; userid='root'; password=''; Initial Catalog =hotelorder";
            MySqlConnection sqlconn = new MySqlConnection(stringconn);
            MySqlCommand sqlcomm = new MySqlCommand();

            sqlconn.Open();
            sqlcomm.CommandText = "INSERT INTO hotelordering VALUES('" + roomNoCB.Text + "','" + pinoyItemNameTB.Text + "','" + pinoyTotalTB.Text + "','" + italianItemNameTB.Text + "','" + italianTotalTB.Text + "','" + dessertItemNameTB.Text + "','" + dessertTotalTB.Text + "','" + drinksItemNameTB.Text + "','" + drinksTotalTB.Text + "','" + extraItemNameTB.Text + "','" + extraTotalTB.Text + "','" + totalTB.Text + "')";
            sqlcomm.CommandType = CommandType.Text;
            sqlcomm.Connection = sqlconn;
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            m_savestock();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
