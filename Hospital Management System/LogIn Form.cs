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

namespace Hospital_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
    }     
        private void Button2_Click(object sender, EventArgs e)
        {
            string x = "Hospital Management System";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A2BU9MO;Initial Catalog='"+x+"';Integrated Security=True");
            SqlCommand com = new SqlCommand();
            if (textBox1.Text != "" && textBox2.Text != "") {
                con.Open();
                com.Connection = con;
                com.CommandText = "select * from Users";
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    if (textBox1.Text.Equals(dr["userName"].ToString()) && textBox2.Text.Equals(dr["pass"].ToString()))
                    {
                        MessageBox.Show("LogIn Done Sucessfully", "Done Message");
                        Sections se = new Sections();
                        this.Visible = false;
                        se.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error Check Your Email Or Password!!", "Error Messsage");
                    }
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("You must fill all fields with data", "Error message");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
