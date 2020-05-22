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
    public partial class DoctorRegistration : Form
    {
        public string conString = "Data Source=DESKTOP-A2BU9MO;Initial " + "Catalog=" + "Hospital Management System" + ";Integrated Security=True";
        public DoctorRegistration()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string name = nameBox.Text;
            string age = AgeBox.Text;
            string date = dateTimePicker1.Text;
            string phone = ContactBox.Text;
            string address = AddressBox.Text;
            string availableTime = textBox3.Text;
            string section = textBox1.Text;
            string salary = textBox2.Text;
            string Gender = "";

            if (nameBox.Text != "" && ContactBox.Text != "" && AddressBox.Text != "" && AgeBox.Text != "" && dateTimePicker1.Text != "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                //check if patient male or female
                if (Mcheck.Checked == false && Fcheck.Checked == false || Mcheck.Checked == true && Fcheck.Checked == true)
                {
                    MessageBox.Show("you should choose one < male or female >", "error message");
                }

                else
                {

                    if (Mcheck.Checked == true)
                    {
                        //gender is male
                        Gender = "male";
                      
                        try
                        {
                            string str = "INSERT INTO Doctor(name,gender,age,contact,address,date,section,salary,availableTime) VALUES('" + name + "','" + Gender + "','" + age + "','" + phone + "','" + address + "','" + date + "','" + section + "','" + salary + "','" + availableTime + "')";

                            SqlCommand cmd = new SqlCommand(str, con);
                            cmd.ExecuteNonQuery();
                            string str1 = "select max(doctorID) from Doctor;";

                            SqlCommand cmd1 = new SqlCommand(str1, con);
                            SqlDataReader dr = cmd1.ExecuteReader();

                            if (dr.Read())
                            {
                                MessageBox.Show("Doctor Information Saved Successfully.." ,"Done Message");
                            }
                        }

                        catch (SqlException excep)
                        {
                            MessageBox.Show(excep.Message);
                        }

                        con.Close();

                    }

                    else if (Fcheck.Checked == true)
                    {
                        //gender is female
                        Gender = "female";
                      
                        try
                        {
                            string str = "INSERT INTO Doctor(name,gender,age,contact,address,date,section,salary,availableTime) VALUES('" + name + "','" + Gender + "','" + age + "','" + phone + "','" + address + "','" + date + "','" + section + "','" + salary + "','" + availableTime + "')";

                            SqlCommand cmd = new SqlCommand(str, con);
                            cmd.ExecuteNonQuery();
                            string str1 = "select max(doctorID) from Doctor;";

                            SqlCommand cmd1 = new SqlCommand(str1, con);
                            SqlDataReader dr = cmd1.ExecuteReader();
                            if (dr.Read())
                            {
                                MessageBox.Show("Doctor Information Saved Successfully.." , "Done Message");

                            }
                        }

                        catch (SqlException excep)
                        {
                            MessageBox.Show(excep.Message);
                        }

                        con.Close();
                    }
                }
            }
            // if text boxes are empty
            else
            {
                // show this meesage to user
                MessageBox.Show("You must fill all fields with data", "Error message");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Doctors d = new Doctors();
            d.Show();
        }
    }
}
