using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pharmacy_Management.pharma
{
    public partial class Add_ph : Form
    {
        public Add_ph()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            phar p=new phar();
            p.Show();
            this.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string ConnectionString = " Data Source=DESKTOP-SRAA8NA;Initial Catalog=phar;Integrated Security=True\r\n";

            //establish connection
            SqlConnection con = new SqlConnection(ConnectionString);

            //open connection

            con.Open();

            //prepare query

            string MedicineName = textBox1.Text;
            string MedicineGeneticName = textBox2.Text;
            string Quantity = textBox3.Text;
            string MagDate = textBox5.Text;
            string ExpDate = textBox4.Text;


            string Query = "INSERT INTO PHARMACY ( MedicineName,MedicineGeneticName, Quantity,MagDate,ExpDate) VALUES('" + MedicineName + "','" + MedicineGeneticName + "' ,'" + Quantity + "','" + MagDate + "','" + ExpDate + "')";


            //excute query
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            //close Connection
            con.Close();

            MessageBox.Show("DAte Has Been Saved");

        }
    }
}
