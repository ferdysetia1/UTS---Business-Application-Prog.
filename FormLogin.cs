using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UTS_Business_Programming
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Sqlcon = new SqlConnection(@"Data Source=FERDYSETIAWAN\SQL2019EXPRESS;Initial Catalog=db_Admin_Resto;Integrated Security=True");
            string query = "SELECT * FROM Admin WHERE username='" + textBox1.Text.Trim() + "' AND password='" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count == 1)
            {
                Main objFrm = new Main();
                this.Hide();
                objFrm.Show();

            }
            else
            {
                MessageBox.Show("Username or Password Incorrect");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hello objFrm = new Hello();
            this.Hide();
            objFrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
