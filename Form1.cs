using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace csharpproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=medicinepointofsale;Data Source=ABBASI\SQLEXPRESS");
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from log_in where Name='" + txtname.Text + "'and Password='" + txtpassword.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    this.Hide();
                    adminuser b = new adminuser();
                    b.Show();

                }
                else
                {
                    MessageBox.Show("Please enter correct username and password", MessageBoxButtons.RetryCancel.ToString());
                }
            }
            catch (Exception)
            { 
            
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        
    }
}
