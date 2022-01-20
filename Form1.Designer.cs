namespace csharpproject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblname.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Black;
            this.lblname.Location = new System.Drawing.Point(218, 57);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(57, 19);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Font = new System.Drawing.Font("Kristen ITC", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.Location = new System.Drawing.Point(212, 94);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(235, 23);
            this.txtname.TabIndex = 1;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblpassword.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.Black;
            this.lblpassword.Location = new System.Drawing.Point(218, 135);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(105, 19);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "Password";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.SlateBlue;
            this.btnlogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.Location = new System.Drawing.Point(212, 213);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(101, 37);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "LOG IN";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("Kristen ITC", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.Location = new System.Drawing.Point(212, 174);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(235, 23);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.SlateBlue;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Location = new System.Drawing.Point(335, 213);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(101, 37);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(459, 305);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN FORM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnexit;
    }
}

