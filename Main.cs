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
    public partial class Main : Form
    {
        FoodList model = new FoodList();
        private string imgLocation;

        public Main()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_Admin_RestoDataSet.FoodList' table. You can move, or remove it, as needed.
            this.foodListTableAdapter.Fill(this.db_Admin_RestoDataSet.FoodList);
            clear();
       
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Save
        {

            model.Food_ID = textBox1.Text.Trim();
            model.Nama = textBox2.Text.Trim();
            model.Category = textBox3.Text.Trim();
            model.Harga = textBox4.Text.Trim();
            model.Description = textBox5.Text.Trim();
            


            using (DBAdmin db = new DBAdmin())
            {
                if (model.Food_ID == null)
                    db.FoodLists.Add(model);
                else
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            clear();
            PopulateDataGridView();
            MessageBox.Show("Submitted Successfully");
        }
        
        void PopulateDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (DBAdmin db = new DBAdmin())
            {
                dataGridView1.DataSource = db.FoodLists.ToList<FoodList>();
            }
        }
        
        private void button2_Click(object sender, EventArgs e) //Delete
        {
            if(MessageBox.Show("Apakah anda yakin?","Yes or No", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                using(DBAdmin db = new DBAdmin())
                {
                    var entry = db.Entry(model);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.FoodLists.Attach(model);
                    db.FoodLists.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    clear();
                    MessageBox.Show("Delete Successful");
                }
        }
        void clear()
        { //pictureBox1.Image 
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
            button1.Text = "Save";
            button2.Enabled = false;
            model.Food_ID = null;
        }

        private void button5_Click(object sender, EventArgs e) //Update
        {
           
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            dataGridView1 = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = dataGridView1.Rows[dataGridView1];

            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();
            textBox6.Text = row.Cells[5].Value.ToString();
            */
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != 0)
            {
                model.Food_ID = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                using(DBAdmin db = new DBAdmin())
                {
                    model = db.FoodLists.Where(x => x.Food_ID == model.Food_ID).FirstOrDefault();
                    textBox1.Text = model.Food_ID;
                    textBox2.Text =model.Nama;
                    textBox3.Text = model.Category;
                    textBox4.Text = model.Harga;
                    textBox5.Text = model.Description;
                   // textBox6.Text = model.Gambar;
                }
                button1.Text = "Update";
                button2.Enabled = true;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hello objFrm = new Hello();
            this.Hide();
            objFrm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var OpenFileDialog = new OpenFileDialog())
            {
                OpenFileDialog dialog = new OpenFileDialog();
                OpenFileDialog.Filter = "Image files | *.jpg";
                OpenFileDialog.CheckPathExists = true;
                OpenFileDialog.CheckFileExists = true;
                OpenFileDialog.Multiselect = false;
                OpenFileDialog.FileName = "";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.pictureBox1.Load(OpenFileDialog.FileName);
                    this.pictureBox1.Tag = OpenFileDialog.FileName;
                }
            }
        }
    }
}
