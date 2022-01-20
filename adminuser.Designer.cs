namespace csharpproject
{
    partial class adminuser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminuser));
            this.rbtadmin = new System.Windows.Forms.RadioButton();
            this.rbtuser = new System.Windows.Forms.RadioButton();
            this.btnenter = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtadmin
            // 
            this.rbtadmin.AutoSize = true;
            this.rbtadmin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rbtadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbtadmin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rbtadmin.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbtadmin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbtadmin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtadmin.ForeColor = System.Drawing.Color.Black;
            this.rbtadmin.Location = new System.Drawing.Point(68, 100);
            this.rbtadmin.Name = "rbtadmin";
            this.rbtadmin.Size = new System.Drawing.Size(85, 24);
            this.rbtadmin.TabIndex = 1;
            this.rbtadmin.TabStop = true;
            this.rbtadmin.Text = "ADMIN";
            this.rbtadmin.UseVisualStyleBackColor = false;
            this.rbtadmin.CheckedChanged += new System.EventHandler(this.rbtadmin_CheckedChanged);
            // 
            // rbtuser
            // 
            this.rbtuser.AutoSize = true;
            this.rbtuser.BackColor = System.Drawing.Color.LightBlue;
            this.rbtuser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtuser.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.rbtuser.Location = new System.Drawing.Point(156, 99);
            this.rbtuser.Name = "rbtuser";
            this.rbtuser.Size = new System.Drawing.Size(83, 25);
            this.rbtuser.TabIndex = 2;
            this.rbtuser.TabStop = true;
            this.rbtuser.Text = "USER";
            this.rbtuser.UseVisualStyleBackColor = false;
            // 
            // btnenter
            // 
            this.btnenter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnenter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenter.ForeColor = System.Drawing.Color.Brown;
            this.btnenter.Location = new System.Drawing.Point(68, 139);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(75, 33);
            this.btnenter.TabIndex = 3;
            this.btnenter.Text = "ENTER";
            this.btnenter.UseVisualStyleBackColor = false;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Brown;
            this.btnexit.Location = new System.Drawing.Point(157, 139);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 33);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // adminuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(538, 287);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.rbtuser);
            this.Controls.Add(this.rbtadmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminuser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminuser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtadmin;
        private System.Windows.Forms.RadioButton rbtuser;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.Button btnexit;
    }
}