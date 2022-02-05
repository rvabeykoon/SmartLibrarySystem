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
    public partial class Form1 : Form
    {
        string accesscon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+@"C:\NSBMSmartLibray\Library1.mdb";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDatabaseDataSet.MemberDetails' table. You can move, or remove it, as needed.
            this.memberDetailsTableAdapter.Fill(this.libraryDatabaseDataSet.MemberDetails);

        }

        private void ambtn_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(accesscon);
            String query = "INSERT INTO Users([U_FullName],[U_Bdy],[U_NIC],[U_Address],[U_Email],[U_Tel],[U_Gender],[Password],[Username]) VALUES ('"+amfntb.Text+"','"+amdp.Text+"','"+amnictb.Text+ "','"+amratb.Text+ "','" + ameatb.Text + "','" + amctb.Text + "','" + amgcb.Text + "','" + amptb.Text + "','" + amutb.Text + "')";
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
                amfntb.Clear();
                //amdp.ResetText();
                amnictb.Clear();
                amratb.Clear();
                ameatb.Clear();
                amptb.Clear();
                amutb.Clear();
                amctb.Clear();
                con.Close();
            }
        }

        private void umdbtn_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(accesscon);
            String query = "UPDATE Users SET [" + umdccb.Text.ToString() + "] = '" + umdttb.Text.ToString()+ "' WHERE U_ID = " + umdmidtb.Text.ToString() + "";
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
                umdttb.Clear();
                umdmidtb.Clear();
                con.Close();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dmbtn_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(accesscon);
            string query = "DELETE * FROM Users WHERE U_ID = " + dmmidtb.Text + "";
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
                dmmidtb.Clear();
                con.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 openForm = new Form4();
            openForm.ShowDialog();
            Visible = false;
        }
    }
}

