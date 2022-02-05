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
    public partial class Form17 : Form
    {
        string accesscon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = "+@"C:\NSBMSmartLibray\Library1.mdb";
        public Form17(string category)
        {
            InitializeComponent();
            string name = category;
            textBox1.Text = category;
            OleDbConnection con = new OleDbConnection(accesscon);
            con.Open();
            string query = "SELECT * FROM Books WHERE B_Category = '" + category + "'";

            OleDbDataAdapter adapt = new OleDbDataAdapter(query, accesscon);
            DataSet set = new DataSet();

            adapt.Fill(set, "Books");
            dataGridView1.DataSource = set.Tables["Books"];
            dataGridView1.ReadOnly = true;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 openForm = new Form4();
            openForm.Show();
            Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 openForm = new Form5(textBox2.Text);
            openForm.Show();
            Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
