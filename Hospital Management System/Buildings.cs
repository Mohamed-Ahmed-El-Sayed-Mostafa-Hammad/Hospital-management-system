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
    public partial class Buildings : Form
    {
        public string conString = "Data Source=DESKTOP-A2BU9MO;Initial " + "Catalog=" + "Hospital Management System" + ";Integrated Security=True";

        public Buildings()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Add_Building c = new Add_Building();
            c.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Rooms_Buildings rm = new Rooms_Buildings();
            rm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Building_Info ii = new Building_Info();
            ii.Show();
        }

        private void Buildings_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd;

            //create a command
            string query = "SELECT COUNT(buildingID) FROM Building";


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
    }
}
