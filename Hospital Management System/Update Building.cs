using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Update_Building : Form
    {
        public string conString = "Data Source=DESKTOP-A2BU9MO;Initial " + "Catalog=" + "Hospital Management System" + ";Integrated Security=True";
        public Update_Building()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Building where buildingNo = '" + textBox5.Text + "'", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                textBox2.Text = da.GetValue(2).ToString();
                textBox1.Text = da.GetValue(1).ToString();




            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            try
            {
                string str = " UPDATE Building SET buildingNo = '" + textBox1.Text + "', noOfRooms ='" + textBox2.Text + "' WHERE buildingNo = '"+textBox5.Text+"'";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                string str1 = "select max(buildingID) from Building;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Building Information Updated Successfully..");

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
            Building_Info i = new Building_Info();
            i.Show();
        }
    }
}
