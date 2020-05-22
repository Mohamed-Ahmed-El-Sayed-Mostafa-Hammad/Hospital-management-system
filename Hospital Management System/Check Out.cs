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
    public partial class PatientCheckOut : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A2BU9MO;Initial " + "Catalog=" + "Hospital Management System" + ";Integrated Security=True");
        public PatientCheckOut()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                con.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from Patient where name ='" + textBox1.Text + "'", con);
                DataTable dtb1 = new DataTable();
                sqlda.Fill(dtb1);
                dgv.DataSource = dtb1;
                con.Close();
            }
            else
            {
                MessageBox.Show("please write a name to search", "Error Message");
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "") {
                string name = textBox1.Text;
                string medicinePrice = textBox2.Text;
                string servicesPrice = textBox3.Text;
                string other = textBox4.Text;
                int medicine_Price = Int32.Parse(medicinePrice);
                int services_Price = Int32.Parse(servicesPrice);
                int Other = Int32.Parse(other);
                int totalMoney = (medicine_Price + services_Price + Other);
                string total_money = totalMoney.ToString();
                label5.Text = total_money;
                con.Open();
                try
                {
                    string str = "UPDATE Patient SET totalMoneyCheckOut ='" + total_money + "' WHERE name = '" + name + "'";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    string str1 = "select max(patientID) from Patient;";

                    SqlCommand cmd1 = new SqlCommand(str1, con);
                    SqlDataReader dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Check Out Done Successfully..","Done Message");

                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("You must fill all data", "Error Message");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Patients pp = new Patients();
            pp.Show();
        }
    }
}
