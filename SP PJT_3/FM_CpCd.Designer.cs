
namespace SP_PJT_3
{
    partial class FM_CpCd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_kospi1year = new System.Windows.Forms.Button();
            this.btn_kospi3months = new System.Windows.Forms.Button();
            this.btn_kospi1day = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_kosdak1day = new System.Windows.Forms.Button();
            this.btn_kosdak3months = new System.Windows.Forms.Button();
            this.btn_kosdak1year = new System.Windows.Forms.Button();
            this.btn_kospi_refresh = new System.Windows.Forms.Button();
            this.btn_kosdak_refresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_kospi1year);
            this.groupBox1.Controls.Add(this.btn_kospi3months);
            this.groupBox1.Controls.Add(this.btn_kospi1day);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 445);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "코스피";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 319);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_kospi1year
            // 
            this.btn_kospi1year.Location = new System.Drawing.Point(300, 44);
            this.btn_kospi1year.Name = "btn_kospi1year";
            this.btn_kospi1year.Size = new System.Drawing.Size(94, 29);
            this.btn_kospi1year.TabIndex = 2;
            this.btn_kospi1year.Text = "1년";
            this.btn_kospi1year.UseVisualStyleBackColor = true;
            this.btn_kospi1year.Click += new System.EventHandler(this.btn_kospi1year_Click);
            // 
            // btn_kospi3months
            // 
            this.btn_kospi3months.Location = new System.Drawing.Point(163, 44);
            this.btn_kospi3months.Name = "btn_kospi3months";
            this.btn_kospi3months.Size = new System.Drawing.Size(94, 29);
            this.btn_kospi3months.TabIndex = 1;
            this.btn_kospi3months.Text = "3개월";
            this.btn_kospi3months.UseVisualStyleBackColor = true;
            this.btn_kospi3months.Click += new System.EventHandler(this.btn_kospi3months_Click);
            // 
            // btn_kospi1day
            // 
            this.btn_kospi1day.Location = new System.Drawing.Point(30, 44);
            this.btn_kospi1day.Name = "btn_kospi1day";
            this.btn_kospi1day.Size = new System.Drawing.Size(94, 29);
            this.btn_kospi1day.TabIndex = 0;
            this.btn_kospi1day.Text = "1일";
            this.btn_kospi1day.UseVisualStyleBackColor = true;
            this.btn_kospi1day.Click += new System.EventHandler(this.btn_kospi1day_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.btn_kosdak1day);
            this.groupBox2.Controls.Add(this.btn_kosdak3months);
            this.groupBox2.Controls.Add(this.btn_kosdak1year);
            this.groupBox2.Location = new System.Drawing.Point(501, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 445);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "코스닥";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(18, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(442, 314);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btn_kosdak1day
            // 
            this.btn_kosdak1day.Location = new System.Drawing.Point(56, 44);
            this.btn_kosdak1day.Name = "btn_kosdak1day";
            this.btn_kosdak1day.Size = new System.Drawing.Size(94, 29);
            this.btn_kosdak1day.TabIndex = 3;
            this.btn_kosdak1day.Text = "1일";
            this.btn_kosdak1day.UseVisualStyleBackColor = true;
            this.btn_kosdak1day.Click += new System.EventHandler(this.btn_kosdak1day_Click);
            // 
            // btn_kosdak3months
            // 
            this.btn_kosdak3months.Location = new System.Drawing.Point(203, 44);
            this.btn_kosdak3months.Name = "btn_kosdak3months";
            this.btn_kosdak3months.Size = new System.Drawing.Size(94, 29);
            this.btn_kosdak3months.TabIndex = 4;
            this.btn_kosdak3months.Text = "3개월";
            this.btn_kosdak3months.UseVisualStyleBackColor = true;
            this.btn_kosdak3months.Click += new System.EventHandler(this.btn_kosdak3months_Click);
            // 
            // btn_kosdak1year
            // 
            this.btn_kosdak1year.Location = new System.Drawing.Point(337, 44);
            this.btn_kosdak1year.Name = "btn_kosdak1year";
            this.btn_kosdak1year.Size = new System.Drawing.Size(94, 29);
            this.btn_kosdak1year.TabIndex = 5;
            this.btn_kosdak1year.Text = "1년";
            this.btn_kosdak1year.UseVisualStyleBackColor = true;
            this.btn_kosdak1year.Click += new System.EventHandler(this.btn_kosdak1year_Click);
            // 
            // btn_kospi_refresh
            // 
            this.btn_kospi_refresh.Location = new System.Drawing.Point(136, 508);
            this.btn_kospi_refresh.Name = "btn_kospi_refresh";
            this.btn_kospi_refresh.Size = new System.Drawing.Size(156, 63);
            this.btn_kospi_refresh.TabIndex = 1;
            this.btn_kospi_refresh.Text = "실시간 코스피";
            this.btn_kospi_refresh.UseVisualStyleBackColor = true;
            this.btn_kospi_refresh.Click += new System.EventHandler(this.btn_kospi_refresh_Click);
            // 
            // btn_kosdak_refresh
            // 
            this.btn_kosdak_refresh.Location = new System.Drawing.Point(675, 508);
            this.btn_kosdak_refresh.Name = "btn_kosdak_refresh";
            this.btn_kosdak_refresh.Size = new System.Drawing.Size(156, 63);
            this.btn_kosdak_refresh.TabIndex = 2;
            this.btn_kosdak_refresh.Text = "실시간 코스닥";
            this.btn_kosdak_refresh.UseVisualStyleBackColor = true;
            this.btn_kosdak_refresh.Click += new System.EventHandler(this.btn_kosdak_refresh_Click);
            // 
            // FM_CpCd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 631);
            this.Controls.Add(this.btn_kosdak_refresh);
            this.Controls.Add(this.btn_kospi_refresh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FM_CpCd";
            this.Text = "오늘의 주가";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FM_CpCd_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_kospi1year;
        private System.Windows.Forms.Button btn_kospi3months;
        private System.Windows.Forms.Button btn_kospi1day;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_kosdak1day;
        private System.Windows.Forms.Button btn_kosdak3months;
        private System.Windows.Forms.Button btn_kosdak1year;
        private System.Windows.Forms.Button btn_kospi_refresh;
        private System.Windows.Forms.Button btn_kosdak_refresh;
    }
}