
namespace Dev_FormStock
{
    partial class FM_Main
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
            this.BarMenu = new System.Windows.Forms.MenuStrip();
            this.CustomerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FM_CpCd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.FM_Option = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.FM_Seed = new System.Windows.Forms.ToolStripMenuItem();
            this.FM_Portfolio = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FM_Port2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.space = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssNowDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.FM_PORT = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FM_STOCK = new System.Windows.Forms.ToolStripMenuItem();
            this.MyTabControl1 = new Dev_FormStock.MyTabControler();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BarMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarMenu
            // 
            this.BarMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BarMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustomerMenu,
            this.ManagerMenu});
            this.BarMenu.Location = new System.Drawing.Point(0, 0);
            this.BarMenu.Name = "BarMenu";
            this.BarMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.BarMenu.Size = new System.Drawing.Size(832, 24);
            this.BarMenu.TabIndex = 11;
            this.BarMenu.Text = "메뉴";
            // 
            // CustomerMenu
            // 
            this.CustomerMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FM_CpCd,
            this.toolStripSeparator4,
            this.FM_Option,
            this.toolStripSeparator3,
            this.FM_Seed,
            this.FM_Portfolio});
            this.CustomerMenu.Name = "CustomerMenu";
            this.CustomerMenu.Size = new System.Drawing.Size(71, 20);
            this.CustomerMenu.Text = "고객 메뉴";
            // 
            // FM_CpCd
            // 
            this.FM_CpCd.Name = "FM_CpCd";
            this.FM_CpCd.Size = new System.Drawing.Size(180, 22);
            this.FM_CpCd.Text = "오늘의 주가";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // FM_Option
            // 
            this.FM_Option.Name = "FM_Option";
            this.FM_Option.Size = new System.Drawing.Size(180, 22);
            this.FM_Option.Text = "전체 주식";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // FM_Seed
            // 
            this.FM_Seed.Name = "FM_Seed";
            this.FM_Seed.Size = new System.Drawing.Size(180, 22);
            this.FM_Seed.Text = "예수금 입금";
            // 
            // FM_Portfolio
            // 
            this.FM_Portfolio.Name = "FM_Portfolio";
            this.FM_Portfolio.Size = new System.Drawing.Size(180, 22);
            this.FM_Portfolio.Text = "나의 주식";
            // 
            // ManagerMenu
            // 
            this.ManagerMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FM_Port2});
            this.ManagerMenu.Name = "ManagerMenu";
            this.ManagerMenu.Size = new System.Drawing.Size(83, 20);
            this.ManagerMenu.Text = "관리자 메뉴";
            // 
            // FM_Port2
            // 
            this.FM_Port2.Name = "FM_Port2";
            this.FM_Port2.Size = new System.Drawing.Size(180, 22);
            this.FM_Port2.Text = "고객 관리";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.space,
            this.tssUserName,
            this.tssNowDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 570);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.statusStrip1.Size = new System.Drawing.Size(832, 26);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // space
            // 
            this.space.AutoSize = false;
            this.space.Name = "space";
            this.space.Size = new System.Drawing.Size(416, 21);
            this.space.Spring = true;
            this.space.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tssUserName
            // 
            this.tssUserName.AutoSize = false;
            this.tssUserName.Name = "tssUserName";
            this.tssUserName.Size = new System.Drawing.Size(152, 21);
            this.tssUserName.Text = "toolStripStatusLabel2";
            // 
            // tssNowDate
            // 
            this.tssNowDate.AutoSize = false;
            this.tssNowDate.Name = "tssNowDate";
            this.tssNowDate.Size = new System.Drawing.Size(252, 21);
            this.tssNowDate.Text = "toolStripStatusLabel3";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnClose,
            this.toolStripSeparator2,
            this.btnHome});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(832, 32);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = global::Dev_FormStock.Properties.Resources.close_512;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 29);
            this.btnExit.Text = "종료";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnClose
            // 
            this.btnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClose.Image = global::Dev_FormStock.Properties.Resources.reply_512;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 29);
            this.btnClose.Text = "닫기";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // btnHome
            // 
            this.btnHome.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHome.Image = global::Dev_FormStock.Properties.Resources.dashboard_512;
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Margin = new System.Windows.Forms.Padding(1, 1, 10, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(34, 29);
            this.btnHome.Text = "홈화면";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // FM_PORT
            // 
            this.FM_PORT.Name = "FM_PORT";
            this.FM_PORT.Size = new System.Drawing.Size(157, 26);
            this.FM_PORT.Text = "나의 주식";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // FM_STOCK
            // 
            this.FM_STOCK.Name = "FM_STOCK";
            this.FM_STOCK.Size = new System.Drawing.Size(157, 26);
            this.FM_STOCK.Text = "전체 주식";
            // 
            // MyTabControl1
            // 
            this.MyTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyTabControl1.Location = new System.Drawing.Point(0, 56);
            this.MyTabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MyTabControl1.Name = "MyTabControl1";
            this.MyTabControl1.SelectedIndex = 0;
            this.MyTabControl1.Size = new System.Drawing.Size(832, 514);
            this.MyTabControl1.TabIndex = 19;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 596);
            this.Controls.Add(this.MyTabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BarMenu);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FM_Main";
            this.Text = "메인 화면";
            this.BarMenu.ResumeLayout(false);
            this.BarMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip BarMenu;
        private System.Windows.Forms.ToolStripMenuItem CustomerMenu;
        private System.Windows.Forms.ToolStripMenuItem ManagerMenu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel space;
        private System.Windows.Forms.ToolStripStatusLabel tssUserName;
        private System.Windows.Forms.ToolStripStatusLabel tssNowDate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem FM_PORT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem FM_STOCK;
        private System.Windows.Forms.ToolStripMenuItem FM_Port2;
        private System.Windows.Forms.ToolStripMenuItem FM_Option;
        private MyTabControler MyTabControl1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem FM_Seed;
        private System.Windows.Forms.ToolStripMenuItem FM_Portfolio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem FM_CpCd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}