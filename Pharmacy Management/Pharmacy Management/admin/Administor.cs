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

namespace Pharmacy_Management.admin
{
    public partial class Administor : Form
    {
        public Administor()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            custo cu=new custo();
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            phar p = new phar();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            custo c=new custo();
            c.Show();
            this.Close();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            phar p =new phar();
            p.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_vieuser av = new add_vieuser();
            av.Show();
            this.Close();   


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_user av = new Add_user();
            av.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_man av = new add_man();
            av.Show();
            this.Close();
        }
    }
}
