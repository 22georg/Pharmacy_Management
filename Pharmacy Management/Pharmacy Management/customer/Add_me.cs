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
    public partial class Add_me : Form
    {
        public Add_me()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            custo custo = new custo();
            custo.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            String dashline = "----------------------------------------------------------------------------------------------------------------------------------------------------------";
            Bitmap bitmap = Properties.Resources.WhatsApp_Image_2023_05_03_at_09_00_41;
            Image image = bitmap;
            e.Graphics.DrawImage(image, 25, 25, 800, 150);


        }
    }
}
