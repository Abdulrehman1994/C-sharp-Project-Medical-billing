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
    public partial class Mainpage : Form
    {

        double nettotal = 0;
        

        public Mainpage()
        {
            InitializeComponent();
            
        }

        private void Mainpage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbltime.Text = DateTime.Now.ToLongTimeString();

            string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=medicinepointofsale;Data Source=ABBASI\SQLEXPRESS";
            SqlConnection con = new SqlConnection(strCon);
            DataSet ds = new DataSet();
            try
            {

                con.Open();

                string query = "select itemname from adminitem1";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds);
                con.Close();
                comboproduct.DataSource = ds.Tables[0];
                comboproduct.ValueMember = "itemname";
            }
            catch (Exception)
            {
                //MessageBox.Show("Error");
            }
        }

    





    private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            lbldate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            lblmarquee.Left += 10;
            if (lblmarquee.Left >= this.Width)
            {
                lblmarquee.Left = lblmarquee.Width * -1;
            }
        }

        private void lbllogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

       
        private void comboproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=medicinepointofsale;Data Source=ABBASI\SQLEXPRESS";
            SqlConnection con = new SqlConnection(strCon);
            //DataSet ds = new DataSet();
            DataTable ds= new DataTable();
            try
            {

                con.Open();

                string query = "select price from adminitem1 where itemname='" + comboproduct.Text + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds);
                con.Close();
                txtprice.Text = ds.Rows[0][0].ToString();
                
            }
            catch (Exception)
            {
                //MessageBox.Show("Error");
            }
        }

      
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                //double invoice;
                //invoice = 1;
                double v1, v2, v3;
                
                v1 = double.Parse(txtprice.Text);

                v2 = double.Parse(txtquantity.Text);
             
                v3 = v1 * v2;

                dataGridView1.Rows.Add(comboproduct.Text, txtquantity.Text, txtprice.Text, v3);
                
                nettotal = nettotal + v3;
                totalbill.Text = nettotal.ToString() + " /RS ";
               
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            comboproduct.Text = "";
       
            txtpaid.Text = "";
            txtprice.Text = "";
            txtquantity.Text = "";
                  totalbill.Text = "";
            dataGridView1.Rows.Clear(); 
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            
            try
            {
                int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(selectedIndex);
                dataGridView1.Refresh();


                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                string val = Convert.ToString(selectedRow.Cells[4].Value);

                dataGridView1.Rows.RemoveAt(selectedIndex);
                nettotal = nettotal - int.Parse(val);
                totalbill.Text = nettotal.ToString() + "  /RS";
                dataGridView1.Refresh();
            }
            catch (Exception)
            {
                
            }
                        
        }
        //private int a = 0;
        private void btnsave_Click(object sender, EventArgs e)
        {
            //a++;
            //txtbillnum.Text = a.ToString();
            string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=medicinepointofsale;Data Source=ABBASI\SQLEXPRESS";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {


                string query = "insert into itemsave2 values('" + dataGridView1[0, i].Value + "'," + dataGridView1[1, i].Value + "," + dataGridView1[2, i].Value + "," + dataGridView1[2, i].Value + ")";


                SqlCommand cmd = new SqlCommand(query, con);

                //for insert delete and update

                int rA = cmd.ExecuteNonQuery();
                Mainpage_Load(sender, e);

            }


            con.Close();
            dataGridView1.Rows.Clear();
            comboproduct.Text = "";
            txtpaid.Text = "";
            txtprice.Text = "";
            txtquantity.Text = "";
            totalbill.Text = "";
                
           


        }

         private void btnveiwdet_Click(object sender, EventArgs e)
        {
            this.Hide();
            Veiwalldet v = new Veiwalldet();
           
            v.Show();

        }

        private void btncash_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                int  v4;
                int paid, total;
                total = int.Parse(totalbill.Text.Split('/')[0]);
                paid = int.Parse(txtpaid.Text);
                v4 = paid - total; 
                MessageBox.Show("      Change :)   :"+v4.ToString());
            }
            catch (Exception)
            {
            }
        }

        
        

       

        
    }
    
}
