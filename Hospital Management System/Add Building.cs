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
    public partial class Add_Building : Form
    {
        public string conString = "Data Source=DESKTOP-A2BU9MO;Initial " + "Catalog=" + "Hospital Management System" + ";Integrated Security=True";
        public Add_Building()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Buildings b = new Buildings();
            b.Show();

        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string buildingNo = textBox1.Text;
            string noOfRooms = textBox2.Text;

            if (textBox1.Text != "" && textBox2.Text != "" )
            {
                try
                {
                    string str = "INSERT INTO Building(buildingNo,noOfRooms) VALUES('" + buildingNo + "','" + noOfRooms + "')";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    string str1 = "select max(buildingID) from Building;";

                    SqlCommand cmd1 = new SqlCommand(str1, con);
                    SqlDataReader dr = cmd1.ExecuteReader();

                    if (dr.Read())
                    {
                        MessageBox.Show("Building Information Saved Successfully..", "Done Message");

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
