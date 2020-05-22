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
    public partial class UpdatePatient : Form
    {
        public string conString = "Data Source=DESKTOP-A2BU9MO;Initial " + "Catalog=" + "Hospital Management System" + ";Integrated Security=True";
        public UpdatePatient()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PatientINFO p = new PatientINFO();
            p.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            try
            {
                string str = " UPDATE Patient SET name = '" + nameBox.Text + "'," +
                    " age ='" + AgeBox.Text + "' , date ='" + dateTimePicker1.Text + "'" +
                    " , address ='" + AddressBox.Text + "', roomNo ='" + textBox3.Text + "'" +
                    ", contact ='" + ContactBox.Text + "', buildingNo ='" + textBox1.Text + "'" +
                    ", price ='" + textBox2.Text + "' , disease ='" + textBox5.Text + 
                    "' WHERE name = '" + textBox4.Text + "'";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                string str1 = "select max(patientID) from Patient;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Patient Information Updated Successfully..","Done Message");

                }
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Patient where name = '" + textBox4.Text + "'", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                nameBox.Text = da.GetValue(1).ToString();
                AgeBox.Text = da.GetValue(3).ToString();
                ContactBox.Text = da.GetValue(4).ToString();
                textBox5.Text = da.GetValue(5).ToString();
                AddressBox.Text = da.GetValue(6).ToString();
                textBox2.Text = da.GetValue(7).ToString();
                textBox1.Text = da.GetValue(8).ToString();
                textBox3.Text = da.GetValue(9).ToString();
                dateTimePicker1.Text = da.GetValue(10).ToString();
            }
        }
    }
}
