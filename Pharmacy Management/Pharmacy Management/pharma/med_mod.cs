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
    public partial class med_mod : Form
    {
        public med_mod()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            phar_manag pa = new phar_manag();
            pa.Show();
            this.Close();
        }
    }
}
