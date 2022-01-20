using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace csharpproject
{
    public partial class adminuser : Form
    {
        public adminuser()
        {
            InitializeComponent();
        }

        

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            if (rbtadmin.Checked)
            {
                ADDITEMS a = new ADDITEMS();
                a.Show();
                this.Hide();
            }
            else if (rbtuser.Checked)
            {
                Mainpage m = new Mainpage();
                m.Show();
                this.Hide();
            }
        }

        private void rbtadmin_CheckedChanged(object sender, EventArgs e)
        {

        }

      
    }
}
