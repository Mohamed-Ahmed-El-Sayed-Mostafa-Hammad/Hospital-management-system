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
    public partial class Rooms : Form
    {
        public string conString = "Data Source=DESKTOP-A2BU9MO;Initial " + "Catalog=" + "Hospital Management System" + ";Integrated Security=True";
        public Rooms()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Add_Room r = new Add_Room();
            r.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Rooms_Buildings rb = new Rooms_Buildings();
            rb.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Room_Info r = new Room_Info();
            r.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd;

            //create a command
            string query = "SELECT COUNT(roomID) FROM Room";


            try
            {
                con.Open();

                cmd = new SqlCommand(query, con);

                //read from db
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                //Display data on the page
                label3.Text = rows_count.ToString();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
