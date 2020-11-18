using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UTS_Business_Programming
{
    public partial class Order : Form
    {
        const double Harga_NasiAyam = 15000;
        const double Harga_MieRebusSpecial = 15000;
        const double Harga_IndomieBasah = 10000;
        const double Harga_GulaiIkan = 13000;
        const double Harga_NasiGorengTelur = 20000;
        const double Harga_PaketHemat = 25000;
        const double Harga_JusJeruk = 11000;
        const double Harga_MinumanBadak = 8000;
        const double Harga_TehManis = 5000;
        const double Harga_TehPahit = 4000;
        const double Harga_AirPutih = 3000;

        string A1 = "Nasi Ayam";
        string A2 = "Mie Rebus Special";
        string A3 = "Indomie Basah";
        string A4 = "Gulai Ikan";
        string A5 = "Nasi Goreng Telur";
        string A6 = "Paket Hemat";
        string DR1 = "Jus Jeruk";
        string DR2 = "Minuman Badak Sirsa";
        string DR3 = "Teh Manis";
        string DR4 = "Teh Pahit";
        string DR5 = "Air Putih";

        public string ListF { get; private set; }

        public Order()
        {
            InitializeComponent();
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "Nasi Ayam";
            if(checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";
            }
        }
        private void RestTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        private void EnabledTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        private void TextBox()
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Order_Load(object sender, EventArgs e)
        {
            EnabledTextBoxes();
            RestTextBoxes();
        }

        private void N(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Text = "Mie Rebus Spesial";
            if (checkBox2.Checked == true)
            {
                textBox8.Enabled = true;
                textBox8.Text = "";
                textBox8.Focus();
            }
            else
            {
                textBox8.Enabled = false;
                textBox8.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Text = "Indomie Basah";
            if (checkBox3.Checked == true)
            {
                textBox9.Enabled = true;
                textBox9.Text = "";
                textBox9.Focus();
            }
            else
            {
                textBox9.Enabled = false;
                textBox9.Text = "0";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.Text = "Gulai Ikan";
            if (checkBox4.Checked == true)
            {
                textBox10.Enabled = true;
                textBox10.Text = "";
                textBox10.Focus();
            }
            else
            {
                textBox10.Enabled = false;
                textBox10.Text = "0";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox11.Enabled = true;
                textBox11.Text = "";
                textBox11.Focus();
            }
            else
            {
                textBox11.Enabled = false;
                textBox11.Text = "0";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                textBox12.Enabled = true;
                textBox12.Text = "";
                textBox12.Focus();
            }
            else
            {
                textBox12.Enabled = false;
                textBox12.Text = "0";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                textBox14.Enabled = true;
                textBox14.Text = "";
                textBox14.Focus();
            }
            else
            {
                textBox14.Enabled = false;
                textBox14.Text = "0";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                textBox19.Enabled = true;
                textBox19.Text = "";
                textBox19.Focus();
            }
            else
            {
                textBox19.Enabled = false;
                textBox19.Text = "0";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                textBox20.Enabled = true;
                textBox20.Text = "";
                textBox20.Focus();
            }
            else
            {
                textBox20.Enabled = false;
                textBox20.Text = "0";
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                textBox22.Enabled = true;
                textBox22.Text = "";
                textBox22.Focus();
            }
            else
            {
                textBox22.Enabled = false;
                textBox22.Text = "0";
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                textBox21.Enabled = true;
                textBox21.Text = "";
                textBox21.Focus();
            }
            else
            {
                textBox21.Enabled = false;
                textBox21.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbPayment.Text == "")
            {
                MessageBox.Show("Mohon Pilih Metode Pembayaran");
            }
            else if (lblTotal.Text == "Rp."+ " " + "0")
                {
                MessageBox.Show("Mohon Memilih Makanan / Minuman Yang Tersedia");

            }
            else if (cmbPayment.Text == "Tunai")
            {
                if (MessageBox.Show("Apakah anda yakin?", "Yes or No", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Payment Successful");
               
                Hello objFrm = new Hello();
                

            }
            
            }
            else if (cmbPayment.Text == "Credit Card")
            {
                Payment_Credit objFrm = new Payment_Credit();
                this.Hide();
                objFrm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] ListFood = new string[11];
            ListFood[0] = Convert.ToString(A1 + " " + textBox1.Text + " " +  "Rp. 15.000/px" + "\n");
            ListFood[1] = Convert.ToString(A2 + " " + textBox8.Text + " " + "Rp. 15.000/px" + "\n");
            ListFood[2] = Convert.ToString(A3 + " " + textBox9.Text + " " + "Rp. 10.000/px" + "\n");
            ListFood[3] = Convert.ToString(A4 + " " + textBox10.Text + " " + "Rp. 13.000/px" + "\n");
            ListFood[4] = Convert.ToString(A5 + " " + textBox11.Text + " " + "Rp. 20.000/px" + "\n");
            ListFood[5] = Convert.ToString(A6 + " " + textBox12.Text + " " + "Rp. 25.000/px" + "\n"); 
            ListFood[6] = Convert.ToString(DR1 + " " + textBox14.Text + " " + "Rp. 11.000/px" + "\n"); 
            ListFood[7] = Convert.ToString(DR2 + " " + textBox19.Text + " " + "Rp. 8.000/px" + "\n");
            ListFood[8] = Convert.ToString(DR3 + " " + textBox20.Text + " " + "Rp. 5.000/px" + "\n");
            ListFood[9] = Convert.ToString(DR4 + " " + textBox22.Text + " " + "Rp. 4.000/px" + "\n");
            ListFood[10] = Convert.ToString(DR5 + " " + textBox21.Text + " " + "Rp. 3.000/px" + "\n");


            double[] itemcost = new double[11];
            itemcost[0] = Convert.ToDouble(textBox1.Text) * Harga_NasiAyam;
            itemcost[1] = Convert.ToDouble(textBox8.Text) * Harga_MieRebusSpecial;
            itemcost[2] = Convert.ToDouble(textBox9.Text) * Harga_IndomieBasah;
            itemcost[3] = Convert.ToDouble(textBox10.Text) * Harga_GulaiIkan;
            itemcost[4] = Convert.ToDouble(textBox11.Text) * Harga_NasiGorengTelur;
            itemcost[5] = Convert.ToDouble(textBox12.Text) * Harga_PaketHemat;
            itemcost[6] = Convert.ToDouble(textBox14.Text) * Harga_JusJeruk;
            itemcost[7] = Convert.ToDouble(textBox19.Text) * Harga_MinumanBadak;
            itemcost[8] = Convert.ToDouble(textBox20.Text) * Harga_TehManis;
            itemcost[9] = Convert.ToDouble(textBox22.Text) * Harga_TehPahit;
            itemcost[10] = Convert.ToDouble(textBox21.Text) * Harga_AirPutih;

            double cost;
            iTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6]
                    + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10];
            lblTotal.Text = Convert.ToString("Rp."+ " " + iTotal);

            ListF = ListFood[0] + ListFood[1] + ListFood[2] + ListFood[3] + ListFood[4] + ListFood[5] + ListFood[6]
                    + ListFood[7] + ListFood[8] + ListFood[9] + ListFood[10];
            label46.Text = Convert.ToString(ListF);

            if (cmbPayment.Text == "Tunai")
            {
                MessageBox.Show("Pembayaran Berhasil");
                this.Close();

            }
            else if(cmbPayment.Text == "Debit")
            {
                Payment_Debit objFrm = new Payment_Debit();
                this.Hide();
                objFrm.Show();
            }
            else if(cmbPayment.Text == "Credit")
            {
                Payment_Credit objFrm = new Payment_Credit();
                this.Hide();
                objFrm.Show();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            comboBox1.Items.Add("Tunai");
            comboBox1.Items.Add("Debit Card");
            comboBox1.Items.Add("Credit Card");
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2");
            string[] ListFood = new string[11];
            ListFood[0] = Convert.ToString(A1 + " " + textBox1.Text + "\n");
            ListFood[1] = Convert.ToString(A2 + " " + textBox8.Text + "\n");
            ListFood[2] = Convert.ToString(A3 + " " + textBox9.Text + "\n");
            ListFood[3] = Convert.ToString(A4 + " " + textBox10.Text + "\n");
            ListFood[4] = Convert.ToString(A5 + " " + textBox11.Text + "\n");
            ListFood[5] = Convert.ToString(A6 + " " + textBox12.Text + "\n");
            ListFood[6] = Convert.ToString(DR1 + " " + textBox14.Text + "\n");
            ListFood[7] = Convert.ToString(DR2 + " " + textBox19.Text + "\n");
            ListFood[8] = Convert.ToString(DR3 + " " + textBox20.Text + "\n");
            ListFood[9] = Convert.ToString(DR4 + " " + textBox22.Text + "\n");
            ListFood[10] = Convert.ToString(DR5 + " " + textBox21.Text + "\n");


            double[] itemcost = new double[11];
            itemcost[0] = Convert.ToDouble(textBox1.Text) * Harga_NasiAyam;
            itemcost[1] = Convert.ToDouble(textBox8.Text) * Harga_MieRebusSpecial;
            itemcost[2] = Convert.ToDouble(textBox9.Text) * Harga_IndomieBasah;
            itemcost[3] = Convert.ToDouble(textBox10.Text) * Harga_GulaiIkan;
            itemcost[4] = Convert.ToDouble(textBox11.Text) * Harga_NasiGorengTelur;
            itemcost[5] = Convert.ToDouble(textBox12.Text) * Harga_PaketHemat;
            itemcost[6] = Convert.ToDouble(textBox14.Text) * Harga_JusJeruk;
            itemcost[7] = Convert.ToDouble(textBox19.Text) * Harga_MinumanBadak;
            itemcost[8] = Convert.ToDouble(textBox20.Text) * Harga_TehManis;
            itemcost[9] = Convert.ToDouble(textBox22.Text) * Harga_TehPahit;
            itemcost[10] = Convert.ToDouble(textBox21.Text) * Harga_AirPutih;

            double cost;
            iTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6]
                    + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10];
            lblTotal.Text = Convert.ToString("Rp." + " " + iTotal);

            ListF = ListFood[0] + ListFood[1] + ListFood[2] + ListFood[3] + ListFood[4] + ListFood[5] + ListFood[6]
                    + ListFood[7] + ListFood[8] + ListFood[9] + ListFood[10];
            label46.Text = Convert.ToString(ListF);
        }
    }
}
