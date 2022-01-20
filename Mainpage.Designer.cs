namespace csharpproject
{
    partial class Mainpage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbltime = new System.Windows.Forms.Label();
            this.lbllogout = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblbilldetail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.marquee = new System.Windows.Forms.Panel();
            this.lblmarquee = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btncash = new System.Windows.Forms.Button();
            this.btnveiwdet = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.comboproduct = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.lblproductname = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblquantity = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalbill = new System.Windows.Forms.TextBox();
            this.lbltotalbill = new System.Windows.Forms.Label();
            this.txtpaid = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.lblamountpaid = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.marquee.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.MintCream;
            this.lbltime.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(560, 12);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(48, 20);
            this.lbltime.TabIndex = 2;
            this.lbltime.Text = "TIME";
            // 
            // lbllogout
            // 
            this.lbllogout.AutoSize = true;
            this.lbllogout.BackColor = System.Drawing.Color.MintCream;
            this.lbllogout.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogout.ForeColor = System.Drawing.Color.Black;
            this.lbllogout.Location = new System.Drawing.Point(566, 63);
            this.lbllogout.Name = "lbllogout";
            this.lbllogout.Size = new System.Drawing.Size(54, 20);
            this.lbllogout.TabIndex = 20;
            this.lbllogout.Text = "Log out";
            this.lbllogout.Click += new System.EventHandler(this.lbllogout_Click);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.MintCream;
            this.lbldate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbldate.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(284, 65);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(35, 20);
            this.lbldate.TabIndex = 23;
            this.lbldate.Text = "Date";
            // 
            // lblbilldetail
            // 
            this.lblbilldetail.AutoSize = true;
            this.lblbilldetail.BackColor = System.Drawing.Color.MintCream;
            this.lblbilldetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbilldetail.Location = new System.Drawing.Point(246, 21);
            this.lblbilldetail.Name = "lblbilldetail";
            this.lblbilldetail.Size = new System.Drawing.Size(93, 20);
            this.lblbilldetail.TabIndex = 20;
            this.lblbilldetail.Text = "Bill Detail";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.lbldate);
            this.panel1.Controls.Add(this.marquee);
            this.panel1.Controls.Add(this.lblbilldetail);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbllogout);
            this.panel1.Location = new System.Drawing.Point(11, -53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 749);
            this.panel1.TabIndex = 8;
            // 
            // marquee
            // 
            this.marquee.Controls.Add(this.lblmarquee);
            this.marquee.Location = new System.Drawing.Point(3, 709);
            this.marquee.Name = "marquee";
            this.marquee.Size = new System.Drawing.Size(635, 33);
            this.marquee.TabIndex = 24;
            // 
            // lblmarquee
            // 
            this.lblmarquee.AutoSize = true;
            this.lblmarquee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarquee.Location = new System.Drawing.Point(177, 3);
            this.lblmarquee.Name = "lblmarquee";
            this.lblmarquee.Size = new System.Drawing.Size(331, 24);
            this.lblmarquee.TabIndex = 0;
            this.lblmarquee.Text = "Welcome to the medicine Point of sale";
            // 
            // panel3
            // 
            this.panel3.AccessibleDescription = "";
            this.panel3.AccessibleName = "";
            this.panel3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel3.AutoScroll = true;
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btncash);
            this.panel3.Controls.Add(this.btnveiwdet);
            this.panel3.Controls.Add(this.btnremove);
            this.panel3.Controls.Add(this.btnsave);
            this.panel3.Controls.Add(this.comboproduct);
            this.panel3.Controls.Add(this.btnadd);
            this.panel3.Controls.Add(this.txtprice);
            this.panel3.Controls.Add(this.txtquantity);
            this.panel3.Controls.Add(this.lblproductname);
            this.panel3.Controls.Add(this.lblprice);
            this.panel3.Controls.Add(this.lblquantity);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.totalbill);
            this.panel3.Controls.Add(this.lbltotalbill);
            this.panel3.Controls.Add(this.txtpaid);
            this.panel3.Controls.Add(this.btnclear);
            this.panel3.Controls.Add(this.lblamountpaid);
            this.panel3.Location = new System.Drawing.Point(79, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 586);
            this.panel3.TabIndex = 10;
            this.panel3.AutoSizeChanged += new System.EventHandler(this.Mainpage_Load);
            this.panel3.Resize += new System.EventHandler(this.Mainpage_Load);
            // 
            // btncash
            // 
            this.btncash.BackColor = System.Drawing.Color.RosyBrown;
            this.btncash.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btncash.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncash.ForeColor = System.Drawing.Color.GreenYellow;
            this.btncash.Location = new System.Drawing.Point(8, 526);
            this.btncash.Name = "btncash";
            this.btncash.Size = new System.Drawing.Size(97, 35);
            this.btncash.TabIndex = 33;
            this.btncash.Text = "Checkout";
            this.btncash.UseVisualStyleBackColor = false;
            this.btncash.Click += new System.EventHandler(this.btncash_Click);
            // 
            // btnveiwdet
            // 
            this.btnveiwdet.BackColor = System.Drawing.Color.RosyBrown;
            this.btnveiwdet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnveiwdet.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnveiwdet.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnveiwdet.Location = new System.Drawing.Point(310, 476);
            this.btnveiwdet.Name = "btnveiwdet";
            this.btnveiwdet.Size = new System.Drawing.Size(159, 35);
            this.btnveiwdet.TabIndex = 32;
            this.btnveiwdet.Text = "Veiw all Detail";
            this.btnveiwdet.UseVisualStyleBackColor = false;
            this.btnveiwdet.Click += new System.EventHandler(this.btnveiwdet_Click);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.RosyBrown;
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnremove.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnremove.Location = new System.Drawing.Point(339, 437);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(122, 35);
            this.btnremove.TabIndex = 31;
            this.btnremove.Text = "Remove item";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.RosyBrown;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnsave.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnsave.Location = new System.Drawing.Point(169, 526);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(97, 35);
            this.btnsave.TabIndex = 30;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // comboproduct
            // 
            this.comboproduct.FormattingEnabled = true;
            this.comboproduct.Location = new System.Drawing.Point(140, 19);
            this.comboproduct.Name = "comboproduct";
            this.comboproduct.Size = new System.Drawing.Size(279, 21);
            this.comboproduct.TabIndex = 29;
            this.comboproduct.SelectedIndexChanged += new System.EventHandler(this.comboproduct_SelectedIndexChanged);
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.BackColor = System.Drawing.Color.RosyBrown;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnadd.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnadd.Location = new System.Drawing.Point(303, 76);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(158, 35);
            this.btnadd.TabIndex = 28;
            this.btnadd.Text = "Add To Cart";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(140, 54);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(135, 20);
            this.txtprice.TabIndex = 26;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(140, 89);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(135, 20);
            this.txtquantity.TabIndex = 25;
            // 
            // lblproductname
            // 
            this.lblproductname.AutoSize = true;
            this.lblproductname.BackColor = System.Drawing.Color.MintCream;
            this.lblproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductname.Location = new System.Drawing.Point(18, 22);
            this.lblproductname.Name = "lblproductname";
            this.lblproductname.Size = new System.Drawing.Size(105, 17);
            this.lblproductname.TabIndex = 23;
            this.lblproductname.Text = "medicine Name";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.BackColor = System.Drawing.Color.MintCream;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(18, 57);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(40, 17);
            this.lblprice.TabIndex = 22;
            this.lblprice.Text = "Price";
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.BackColor = System.Drawing.Color.MintCream;
            this.lblquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantity.Location = new System.Drawing.Point(18, 92);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(61, 17);
            this.lblquantity.TabIndex = 21;
            this.lblquantity.Text = "Quantity";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(5, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(464, 286);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Totalamont";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // totalbill
            // 
            this.totalbill.Location = new System.Drawing.Point(104, 434);
            this.totalbill.Name = "totalbill";
            this.totalbill.ReadOnly = true;
            this.totalbill.Size = new System.Drawing.Size(192, 20);
            this.totalbill.TabIndex = 12;
            // 
            // lbltotalbill
            // 
            this.lbltotalbill.AutoSize = true;
            this.lbltotalbill.BackColor = System.Drawing.Color.MintCream;
            this.lbltotalbill.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalbill.Location = new System.Drawing.Point(5, 437);
            this.lbltotalbill.Name = "lbltotalbill";
            this.lbltotalbill.Size = new System.Drawing.Size(57, 20);
            this.lbltotalbill.TabIndex = 11;
            this.lbltotalbill.Text = "Total bill";
            // 
            // txtpaid
            // 
            this.txtpaid.Location = new System.Drawing.Point(104, 476);
            this.txtpaid.Name = "txtpaid";
            this.txtpaid.Size = new System.Drawing.Size(192, 20);
            this.txtpaid.TabIndex = 14;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.RosyBrown;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnclear.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnclear.Location = new System.Drawing.Point(310, 526);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(97, 35);
            this.btnclear.TabIndex = 17;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lblamountpaid
            // 
            this.lblamountpaid.AutoSize = true;
            this.lblamountpaid.BackColor = System.Drawing.Color.MintCream;
            this.lblamountpaid.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamountpaid.Location = new System.Drawing.Point(5, 478);
            this.lblamountpaid.Name = "lblamountpaid";
            this.lblamountpaid.Size = new System.Drawing.Size(78, 20);
            this.lblamountpaid.TabIndex = 13;
            this.lblamountpaid.Text = "Amount paid";
            // 
            // Mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 705);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltime);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mainpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainpage";
            this.Load += new System.EventHandler(this.Mainpage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.marquee.ResumeLayout(false);
            this.marquee.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbllogout;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblbilldetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel marquee;
        private System.Windows.Forms.Label lblmarquee;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btncash;
        private System.Windows.Forms.Button btnveiwdet;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox comboproduct;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label lblproductname;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox totalbill;
        private System.Windows.Forms.Label lbltotalbill;
        private System.Windows.Forms.TextBox txtpaid;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lblamountpaid;
    }
}