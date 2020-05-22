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
    public partial class DoctorInfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A2BU9MO;Initial " + "Catalog=" + "Hospital Management System" + ";Integrated Security=True");
        public DoctorInfo()
        {
            InitializeComponent();
        }
        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                con.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from Doctor where name ='" + textBox1.Text + "'", con);
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
            con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from Doctor", con);
            DataTable dtb1 = new DataTable();
            sqlda.Fill(dtb1);
            dgv.DataSource = dtb1;
            con.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Doctors dd = new Doctors();
            dd.Show();
        }

        private void DoctorInfo_Load(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdateDoctor u = new UpdateDoctor();
            u.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A2BU9MO;Initial " + "Catalog=" + "Hospital Management System" + ";Integrated Security=True");
                con.Open();

                try
                {
                    string str = "DELETE FROM Doctor WHERE name ='" + textBox1.Text + "';";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    string str1 = "select max(doctorID) from Doctor;";

                    SqlCommand cmd1 = new SqlCommand(str1, con);
                    SqlDataReader dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Doctor Information Deleted Successfully..","Done Message");

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
                MessageBox.Show("Search about what you want to delete ","Error Message");
            }
        } 
    }

}

