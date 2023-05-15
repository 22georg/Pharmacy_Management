using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management.pharma
{
    public partial class phar_manag : Form
    {
        public phar_manag()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            phar pa=new phar();
            pa.Show();
            this.Close();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            phar p = new phar();
            p.Show();
            this.Close();
        }
    }
}
