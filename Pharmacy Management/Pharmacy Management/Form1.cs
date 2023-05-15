using Pharmacy_Management.admin;
using Pharmacy_Management.customer;
using Pharmacy_Management.pharma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "phar" && textBox2.Text == "1234")
            {
                phar p=new phar();
                p.Show();
                this.Hide();
           
            }
            else if(textBox1.Text == "Customer" && textBox2.Text == "1234")
            {
                custo cu=new custo();
                cu.Show();
                this.Hide();
            }
            else if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
            {
                Administor adm = new Administor();
                adm.Show();
                this.Hide();
            }





            else
            {
                MessageBox.Show("Wrong Username Or Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
    
}
