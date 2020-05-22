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
    public partial class nurses : Form
    {
        public nurses()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            NurseRegistration f = new NurseRegistration();
            f.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            nurseInfo n = new nurseInfo();
            n.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Sections s = new Sections();
            s.Show();
        }
    }
}
