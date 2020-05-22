using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Sections : Form
    {
        public Sections()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Patients p = new Patients();
            p.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void NurseButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            nurses nn = new nurses();
            nn.Show();
        }

        private void DoctorButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Doctors d = new Doctors();
            d.Show();
        }

        private void RoomsButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Rooms_Buildings r = new Rooms_Buildings();
            r.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
