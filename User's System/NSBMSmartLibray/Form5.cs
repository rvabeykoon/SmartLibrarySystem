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
    public partial class Form5 : Form
    {
        string accesscon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = " + @"C:\NSBMSmartLibray\Library1.mdb";
        public Form5(string str_value)
        {
            InitializeComponent();
            textBox1.Text = str_value;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            panel8.BackColor = Color.FromArgb(150, 0, 210, 10);
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            panel12.BackColor = Color.FromArgb(150, 0, 13, 250);
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            panel13.BackColor = Color.FromArgb(150, 192, 38, 19);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 openForm = new Form6();
            openForm.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
            Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(accesscon);
            con.Open();
            try
            {

                OleDbCommand cmd = new OleDbCommand("select * from Users where Username='" + textBox2.Text + "' and Password='" + textBox3.Text + "'", con);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    {
                        MessageBox.Show("Borrowing Successful");
                    }
                    
                    {
                        Form1 openForm = new Form1();
                        openForm.Show();
                        Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credentials, Please Re-Enter");
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                con.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
