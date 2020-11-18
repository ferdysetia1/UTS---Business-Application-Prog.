using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_Business_Programming
{
    public partial class Payment_Credit : Form
    {
        public Payment_Credit()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                   (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Please Fill in the details");
                Payment_Credit objFrm = new Payment_Credit();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Please Fill in the details");
                Payment_Credit objFrm = new Payment_Credit();
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Please Fill in the details");
                Payment_Credit objFrm = new Payment_Credit();
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Please Fill in the details");
                Payment_Credit objFrm = new Payment_Credit();
            }
            else if (MessageBox.Show("Apakah anda yakin?", "Yes or No", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { 
                    MessageBox.Show("Payment Successful");
                
                this.Hide();
                Hello objFrm = new Hello();
            }
            

        }
    }
}
