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
    public partial class Rooms_Buildings : Form
    {
        public Rooms_Buildings()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Rooms r = new Rooms();
            r.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Buildings bb = new Buildings();
            bb.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Sections ss = new Sections();
            ss.Show();
        }
    }
}
