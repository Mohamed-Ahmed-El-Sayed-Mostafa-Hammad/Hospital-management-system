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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PatientRegistration pp = new PatientRegistration();
            pp.Show();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PatientINFO p = new PatientINFO();
            p.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Sections s2 = new Sections();
            s2.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PatientCheckOut p = new PatientCheckOut();
            p.Show();
        }
    }
}
