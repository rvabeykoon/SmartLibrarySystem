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

namespace Library_Management_System
{
    public partial class Form5 : Form
    {
        string accesscon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + @"C:\NSBMSmartLibray\Library1.mdb";

        public Form5()
        {
            InitializeComponent();
        }



        private void abbtn_Click_1(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(accesscon);
            String query = "INSERT INTO Books([B_Name],[ISBN],[B_discptn],[B_Price(Rs)],[A_Name],[B_Category],[B_Publisher]) VALUES ('" + abttb.Text + "','" + abisbntb.Text + "','" + abdtb.Text + "'," + abctb.Text + ",'" + abatb.Text + "','" + abscb.Text + "','" + abptb.Text + "')";
            OleDbCommand cmd = new OleDbCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Database updated. Process successful.");
            }

            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                abttb.Clear();
                abisbntb.Clear();
                abdtb.Clear();
                abctb.Clear();
                abatb.Clear();
                abptb.Clear();

                con.Close();
            }
        }


        private void dbbtn_Click_1(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(accesscon);
            string query = "DELETE * FROM Books WHERE B_ID = " + dbbidtb.Text + "";
            OleDbCommand cmd = new OleDbCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Database updated. Process successful.");
            }

            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                dbbidtb.Clear();
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 openForm = new Form4();
            openForm.ShowDialog();
            Visible = false;
        }

        private void umdbtn_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(accesscon);
            String query = "UPDATE Books SET " + ubdccb.Text.ToString() + " = '" + ubdttb.Text.ToString() + "' WHERE B_ID = " + ubdbidtb.Text.ToString() + "";
            OleDbCommand cmd = new OleDbCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Database updated. Process successful.");
            }

            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                ubdttb.Clear();
                ubdbidtb.Clear();


                con.Close();
            }
        }
    }
}

