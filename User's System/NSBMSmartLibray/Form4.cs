using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSBMSmartLibray
{
    public partial class Form4 : Form
    {
       
        public Form4()
        {
            InitializeComponent();
        }
            

        

       

        

        private void button12_Click(object sender, EventArgs e)
        {
            Form6 openForm = new Form6();
            openForm.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
            Visible = false;
        }

    

        

        private void button14_Click(object sender, EventArgs e)
        {
            Form17 openForm = new Form17("Translation");
            openForm.ShowDialog();
            Visible = false;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form17 openForm = new Form17("Zoology");
            openForm.ShowDialog();
            Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form17 openForm = new Form17("Novel");
            openForm.ShowDialog();
            Visible = false;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form17 openForm = new Form17("Poetry");
            openForm.ShowDialog();
            Visible = false;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Form17 openForm = new Form17("Science");
            openForm.ShowDialog();
            Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form17 openForm = new Form17("Non-Fiction");
            openForm.ShowDialog();
            Visible = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form17 openForm = new Form17("Bussiness");
            openForm.ShowDialog();
            Visible = false;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Form17 openForm = new Form17("Computer");
            openForm.ShowDialog();
            Visible = false;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form17 openForm = new Form17("Fiction");
            openForm.ShowDialog();
            Visible = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form17 openForm = new Form17("Religion");
            openForm.ShowDialog();
            Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form17 openForm = new Form17("Comic");
            openForm.ShowDialog();
            Visible = false;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Form17 openForm = new Form17("Biography");
            openForm.ShowDialog();
            Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form17 openForm = new Form17("Encyclopedia");
            openForm.ShowDialog();
            Visible = false;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Form17 openForm = new Form17("Maths");
            openForm.ShowDialog();
            Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form17 openForm = new Form17("Web");
            openForm.ShowDialog();
            Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form17 openForm = new Form17("Other");
            openForm.ShowDialog();
            Visible = false;
        }
    }
}
