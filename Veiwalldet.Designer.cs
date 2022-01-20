namespace csharpproject
{
    partial class Veiwalldet
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblsales = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblsales);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 48);
            this.panel1.TabIndex = 1;
            // 
            // lblsales
            // 
            this.lblsales.AutoSize = true;
            this.lblsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsales.Location = new System.Drawing.Point(185, 15);
            this.lblsales.Name = "lblsales";
            this.lblsales.Size = new System.Drawing.Size(158, 20);
            this.lblsales.TabIndex = 0;
            this.lblsales.Text = "Veiw all the sales";
            this.lblsales.Click += new System.EventHandler(this.lblsales_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(277, 363);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 28);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Veiwalldet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Veiwalldet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veiwalldet";
            this.Load += new System.EventHandler(this.Veiwalldet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblsales;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button button1;
    }
}