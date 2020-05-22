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
    public partial class Doctors : Form
    {
        public Doctors()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Sections s = new Sections();
            s.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DoctorRegistration d = new DoctorRegistration();
            d.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DoctorInfo di = new DoctorInfo();
            di.Show();

        }
    }
}
