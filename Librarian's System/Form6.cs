using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void libtn_Click(object sender, EventArgs e)
        {
            if (liutb.Text == "admin")
            {
                if (liptb.Text == "admin")
                {
                    Form4 openForm = new Form4();
                    openForm.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Invalid Username and/or Password. Please check it and try again.");
                    Form6 openForm = new Form6();
                    openForm.Show();
                    Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Invalid Username and/or Password. Please check it and try again.");
                Form6 openForm = new Form6();
                openForm.Show();
                Visible = false;
            }

        }
    }
}
