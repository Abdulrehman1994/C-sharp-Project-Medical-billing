using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace csharpproject
{
    public partial class ADDITEMS : Form
    {
        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=medicinepointofsale;Data Source=ABBASI\SQLEXPRESS");
        SqlCommand cmd;
       
        public ADDITEMS()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            try
            {
                string query = "insert into adminitem1(itemname,Code,Price,Date,Time,Company)values('" + txtitemname.Text + "','" + textBox1.Text + "','" + txtprice.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + dateTimePicker1.Value.ToShortTimeString() + "','" + textBox2.Text + "')";
                if(con.State!= ConnectionState.Open)
                {
                    con.Open();
                }
                cmd = new SqlCommand(query,con);
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() +" Saved ");
                txtitemname.Text = "";
                txtprice.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                
            }
            catch (Exception)
            {
                MessageBox.Show("error");

            }






        }

       
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminuser a = new adminuser();
            a.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
