
namespace SP_PJT_3
{
    partial class FM_JustSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSystemLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJustSystem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSystemLogin
            // 
            this.btnSystemLogin.Location = new System.Drawing.Point(214, 169);
            this.btnSystemLogin.Name = "btnSystemLogin";
            this.btnSystemLogin.Size = new System.Drawing.Size(105, 32);
            this.btnSystemLogin.TabIndex = 0;
            this.btnSystemLogin.Text = "관리자 입장";
            this.btnSystemLogin.UseVisualStyleBackColor = true;
            this.btnSystemLogin.Click += new System.EventHandler(this.btnSystemLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "비밀번호";
            // 
            // txtJustSystem
            // 
            this.txtJustSystem.Location = new System.Drawing.Point(153, 115);
            this.txtJustSystem.Name = "txtJustSystem";
            this.txtJustSystem.PasswordChar = '*';
            this.txtJustSystem.Size = new System.Drawing.Size(166, 27);
            this.txtJustSystem.TabIndex = 2;
            this.txtJustSystem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJustSystem_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "관리자 영역입니다.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "2차 관리자 비밀번호를 입력하세요.";
            // 
            // FM_JustSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 244);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJustSystem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSystemLogin);
            this.Name = "FM_JustSystem";
            this.Text = "FM_JustSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSystemLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJustSystem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}