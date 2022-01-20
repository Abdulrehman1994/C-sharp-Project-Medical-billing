using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace csharpproject
{
    public partial class Veiwalldet : Form
    {
        public Veiwalldet()
        {
            InitializeComponent();
        }

        private void Veiwalldet_Load(object sender, EventArgs e)
        {
            string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=medicinepointofsale;Data Source=ABBASI\SQLEXPRESS";
            SqlConnection con = new SqlConnection(strCon);
            DataSet ds = new DataSet();

            try
            {

                con.Open();

                string query = "select * from itemsave2";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds);
                con.Close();
                dataGridView1.DataSource = ds.Tables[0];
                

            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblsales.Left += 10;
            if (lblsales.Left >= this.Width)
            {
                lblsales.Left = lblsales.Width * -1;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainpage m = new Mainpage();
            m.Show();
        }

        private void lblsales_Click(object sender, EventArgs e)
        {

        }
    }
}
