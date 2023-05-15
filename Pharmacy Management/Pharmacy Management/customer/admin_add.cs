using Pharmacy_Management.customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_Management.admin
{
    public partial class admin_add : Form
    {
        public admin_add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
           
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            custo cua = new custo();
            cua.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-SRAA8NA;Initial Catalog=view_adm;Integrated Security=True";

            //establish connection
            SqlConnection con = new SqlConnection(ConnectionString);

            //open connection

            con.Open();

            //prepare query

            string CustomerName = textBox1.Text;
            string Contact = textBox3.Text;
            string BirthDay = textBox5.Text;
            string EmergencyContactName = textBox4.Text;
            string EmergencyContact = textBox6.Text;


            string Query = "INSERT INTO adm ( CustomerName,Contact, BirthDay,EmergencyContactName,EmergencyContact) VALUES('"+ CustomerName + "','" + Contact + "' ,'" + BirthDay + "','" + EmergencyContactName + "','" + EmergencyContact + "')";


                //excute query
                SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            //close Connection
            con.Close();

            MessageBox.Show("Date Has Been Saved");


        }
    }
}
