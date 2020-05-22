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
    public partial class UpdateRoom : Form
    {
        public string conString = "Data Source=DESKTOP-A2BU9MO;Initial " + "Catalog=" + "Hospital Management System" + ";Integrated Security=True";
        public UpdateRoom()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            try
            {
                string str = " UPDATE Room SET buildingNo = '" + textBox1.Text + "', roomNo ='" + textBox2.Text + "' , noOfBeds ='" + textBox3.Text + "' , floor ='" + textBox4.Text + "'";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                string str1 = "select max(roomID) from Room;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Room Information Updated Successfully..");

                }
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Room_Info ri = new Room_Info();
            ri.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Room where roomNo = '" + textBox5.Text + "'", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                textBox2.Text = da.GetValue(1).ToString();
                textBox4.Text = da.GetValue(2).ToString();
                textBox3.Text = da.GetValue(3).ToString();
                textBox1.Text = da.GetValue(4).ToString();




            }
        }
    }
}
