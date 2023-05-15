using Pharmacy_Management.admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management.customer
{
    public partial class custo : Form
    {
        public custo()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_add au= new admin_add();
            au.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           Form1 fm = new Form1();
            fm.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_me am=new Add_me();
            am.Show();
            this.Close();
           
            
        }

        private void customer_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administor a=new Administor();
            a.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_v av = new add_v();
            av.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
