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
    public partial class PatientRegistration : Form
    {
        public PatientRegistration()
        {
            InitializeComponent();
        }

        private void PhoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void AgeBox_TextChanged(object sender, EventArgs e)
        {

        }
        public string conString = "Data Source=DESKTOP-A2BU9MO;Initial " + "Catalog=" + "Hospital Management System" + ";Integrated Security=True";
        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string name = nameBox.Text;
            string age = AgeBox.Text;
            string date = dateTimePicker1.Text;
            string phone = ContactBox.Text;
            string address = AddressBox.Text;
            string disease = DiseaseBox.Text;
            string building_No = BuildingNoBox.Text;
            string room_No = RoomNoBox.Text;
            string price = PriceBox.Text;
            string Gender = "";
            // if condition to check if text boxes are not empty
            if (nameBox.Text != "" && ContactBox.Text != "" && AddressBox.Text != "" && AgeBox.Text != "" && dateTimePicker1.Text != "" && BuildingNoBox.Text !="" && RoomNoBox.Text != "" && DiseaseBox.Text != "" && PriceBox.Text != "")
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
                            string str = "INSERT INTO Patient(name,gender,age,contact,disease,address,price,buildingNo,roomNo,date) VALUES('" + name + "','" + Gender + "','" + age + "','" + phone + "','" + disease + "','" + address + "','" + price + "','" + building_No + "','" + room_No + "','" + date + "')";

                            SqlCommand cmd = new SqlCommand(str, con);
                            cmd.ExecuteNonQuery();
                            string str1 = "select max(PatientID) from Patient;";

                            SqlCommand cmd1 = new SqlCommand(str1, con);
                            SqlDataReader dr = cmd1.ExecuteReader();
                            if (dr.Read())
                            {
                                MessageBox.Show("Patient Information Saved Successfully..","Done Message");

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
                            string str = "INSERT INTO Patient(name,gender,age,contact,disease,address,price,buildingNo,roomNo,date) VALUES('" + name + "','" + Gender + "','" + age + "','" + phone + "','" + disease + "','" + address + "','" + price + "','" + building_No + "','" + room_No + "','" + date + "')";

                            SqlCommand cmd = new SqlCommand(str, con);
                            cmd.ExecuteNonQuery();
                            string str1 = "select max(PatientID) from Patient;";

                            SqlCommand cmd1 = new SqlCommand(str1, con);
                            SqlDataReader dr = cmd1.ExecuteReader();
                            if (dr.Read())
                            {
                                MessageBox.Show("Patient Information Saved Successfully.." , "Done Message");

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
            Patients p = new Patients();
            p.Show();
        }

        private void PatientRegistration_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenderLabel_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AgeLabel_Click(object sender, EventArgs e)
        {

        }

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ContactBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
