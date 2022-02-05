using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NSBMSmartLibray
{
    public partial class Form3 : Form
    {
        string accesscon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = " + @"C:\NSBMSmartLibray\Library1.mdb";
        public Form3()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form6 openForm = new Form6();
            openForm.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 openForm = new Form4();
            openForm.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 openForm = new Form5(textBox3.Text);
            openForm.Show();
            Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(accesscon);
            con.Open();
            string query = "SELECT * FROM Books  WHERE A_Name LIKE '%" + textBox2.Text.ToString() + "%'";

            OleDbDataAdapter adapt = new OleDbDataAdapter(query, accesscon);
            DataSet set = new DataSet();

            adapt.Fill(set, "Books");
            dataGridView2.DataSource = set.Tables["Books"];
            dataGridView2.ReadOnly = true;

            con.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(accesscon);
            con.Open();
            string query = "SELECT * FROM Books  WHERE B_Name LIKE '%" + textBox1.Text.ToString() + "%'";

            OleDbDataAdapter adapt = new OleDbDataAdapter(query, accesscon);
            DataSet set = new DataSet();

            adapt.Fill(set, "Books");
            dataGridView2.DataSource = set.Tables["Books"];
            dataGridView2.ReadOnly = true;

            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
