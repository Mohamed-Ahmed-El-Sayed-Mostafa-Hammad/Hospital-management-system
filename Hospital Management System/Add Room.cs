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
    public partial class Add_Room : Form
    {
        public string conString = "Data Source=DESKTOP-A2BU9MO;Initial " + "Catalog=" + "Hospital Management System" + ";Integrated Security=True";
        public Add_Room()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Rooms r = new Rooms();
            r.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string buildingNo = textBox1.Text;
            string roomNo = textBox2.Text;
            string noOfBeds = textBox3.Text;
            string floor = textBox4.Text;



            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {                         
                        try
                        {
                            string str = "INSERT INTO Room(buildingNo,roomNo,noOfBeds,floor) VALUES('" + buildingNo + "','" + roomNo + "','" + noOfBeds + "','" + floor + "')";

                            SqlCommand cmd = new SqlCommand(str, con);
                            cmd.ExecuteNonQuery();
                            string str1 = "select max(roomID) from Room;";

                            SqlCommand cmd1 = new SqlCommand(str1, con);
                            SqlDataReader dr = cmd1.ExecuteReader();

                            if (dr.Read())
                            {
                                MessageBox.Show("Room Information Saved Successfully.." , "Done Message");

                            }
                        }

                        catch (SqlException excep)
                        {
                            MessageBox.Show(excep.Message);
                        }

                        con.Close();   
            }       
            // if text boxes are empty
            else
            {
                // show this meesage to user
                MessageBox.Show("You must fill all fields with data", "Error message");
            }
        }      
    }
}
