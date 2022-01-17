
namespace SP_PJT_3
{
    partial class FM_Portfolio
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOwn = new System.Windows.Forms.TextBox();
            this.txtSeed2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodeName = new System.Windows.Forms.TextBox();
            this.labe1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboStock = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoKospi = new System.Windows.Forms.RadioButton();
            this.rdoKosdaq = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAccountHidden = new System.Windows.Forms.TextBox();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtOwn);
            this.groupBox3.Controls.Add(this.txtSeed2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtCodeName);
            this.groupBox3.Controls.Add(this.labe1);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.cboStock);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1067, 167);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "고객 포트폴리오";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(523, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "예수금";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(755, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "보유자산";
            // 
            // txtOwn
            // 
            this.txtOwn.Location = new System.Drawing.Point(830, 117);
            this.txtOwn.Name = "txtOwn";
            this.txtOwn.Size = new System.Drawing.Size(168, 27);
            this.txtOwn.TabIndex = 21;
            // 
            // txtSeed2
            // 
            this.txtSeed2.Location = new System.Drawing.Point(583, 117);
            this.txtSeed2.Name = "txtSeed2";
            this.txtSeed2.Size = new System.Drawing.Size(166, 27);
            this.txtSeed2.TabIndex = 20;
            this.txtSeed2.TextChanged += new System.EventHandler(this.txtSeed2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "종목이름, 종목코드";
            // 
            // txtCodeName
            // 
            this.txtCodeName.Location = new System.Drawing.Point(634, 66);
            this.txtCodeName.Name = "txtCodeName";
            this.txtCodeName.Size = new System.Drawing.Size(256, 27);
            this.txtCodeName.TabIndex = 18;
            this.txtCodeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodeName_KeyDown);
            // 
            // labe1
            // 
            this.labe1.AutoSize = true;
            this.labe1.Location = new System.Drawing.Point(27, 39);
            this.labe1.Name = "labe1";
            this.labe1.Size = new System.Drawing.Size(39, 20);
            this.labe1.TabIndex = 9;
            this.labe1.Text = "섹터";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(904, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboStock
            // 
            this.cboStock.FormattingEnabled = true;
            this.cboStock.Items.AddRange(new object[] {
            "",
            "1차 비철금속 제조업",
            "1차 철강 제조업",
            "건축기술, 엔지니어링 및 관련 기술 서비스업",
            "기초 의약물질 및 생물학적 제제 제조업",
            "기초 화학물질 제조업",
            "기타 금융업",
            "기타 비금속 광물제품 제조업",
            "기타 전문 도매업",
            "기타 정보 서비스업",
            "기타 화학제품 제조업",
            "나무제품 제조업",
            "내화, 비내화 요업제품 제조업",
            "담배 제조업",
            "반도체 제조업",
            "보험업",
            "석유 정제품 제조업",
            "선박 및 보트 건조업",
            "소프트웨어 개발 및 공급업",
            "영화, 비디오물, 방송프로그램 제작 및 배급업",
            "오디오물 출판 및 원판 녹음업",
            "유원지 및 기타 오락관련 서비스업",
            "은행 및 저축기관",
            "의료용 기기 제조업",
            "의료용품 및 기타 의약 관련제품 제조업",
            "의약품 제조업",
            "일반 목적용 기계 제조업",
            "일차전지 및 축전지 제조업",
            "자동차 신품 부품 제조업",
            "자동차용 엔진 및 자동차 제조업",
            "자료처리, 호스팅, 포털 및 기타 인터넷 정보매개 서비스업",
            "자연과학 및 공학 연구개발업",
            "전기 통신업",
            "전기업",
            "전자부품 제조업",
            "컴퓨터 프로그래밍, 시스템 통합 및 관리업",
            "텔레비전 방송업",
            "통신 및 방송 장비 제조업",
            "특수 목적용 기계 제조업",
            "플라스틱제품 제조업",
            "항공 여객 운송업",
            "해상 운송업"});
            this.cboStock.Location = new System.Drawing.Point(27, 62);
            this.cboStock.Name = "cboStock";
            this.cboStock.Size = new System.Drawing.Size(234, 28);
            this.cboStock.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdoAll);
            this.groupBox4.Controls.Add(this.rdoKospi);
            this.groupBox4.Controls.Add(this.rdoKosdaq);
            this.groupBox4.Location = new System.Drawing.Point(284, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(276, 69);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "분류";
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Checked = true;
            this.rdoAll.Location = new System.Drawing.Point(6, 26);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(90, 24);
            this.rdoAll.TabIndex = 3;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "전체조회";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // rdoKospi
            // 
            this.rdoKospi.AutoSize = true;
            this.rdoKospi.Location = new System.Drawing.Point(102, 26);
            this.rdoKospi.Name = "rdoKospi";
            this.rdoKospi.Size = new System.Drawing.Size(75, 24);
            this.rdoKospi.TabIndex = 0;
            this.rdoKospi.Text = "코스피";
            this.rdoKospi.UseVisualStyleBackColor = true;
            // 
            // rdoKosdaq
            // 
            this.rdoKosdaq.AutoSize = true;
            this.rdoKosdaq.Location = new System.Drawing.Point(195, 26);
            this.rdoKosdaq.Name = "rdoKosdaq";
            this.rdoKosdaq.Size = new System.Drawing.Size(75, 24);
            this.rdoKosdaq.TabIndex = 2;
            this.rdoKosdaq.Text = "코스닥";
            this.rdoKosdaq.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.dgvGrid);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1067, 455);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "나의 주식 보유 현황";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAccountHidden);
            this.groupBox1.Controls.Add(this.btnSearch2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSeed);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.txtSum);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1061, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주식 매수 * 매도";
            // 
            // txtAccountHidden
            // 
            this.txtAccountHidden.Location = new System.Drawing.Point(729, 91);
            this.txtAccountHidden.Name = "txtAccountHidden";
            this.txtAccountHidden.Size = new System.Drawing.Size(191, 27);
            this.txtAccountHidden.TabIndex = 21;
            this.txtAccountHidden.Visible = false;
            // 
            // btnSearch2
            // 
            this.btnSearch2.Location = new System.Drawing.Point(533, 56);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(64, 28);
            this.btnSearch2.TabIndex = 20;
            this.btnSearch2.Text = "조회";
            this.btnSearch2.UseVisualStyleBackColor = true;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(669, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "예수금";
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(729, 57);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(191, 27);
            this.txtSeed.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "종목이름";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(27, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(223, 27);
            this.txtName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(634, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "거래금 총합";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "수량";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(926, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 59);
            this.button2.TabIndex = 6;
            this.button2.Text = "매수";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "현재가";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(982, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "매도";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(256, 58);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(174, 27);
            this.txtPrice.TabIndex = 12;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(436, 58);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(80, 27);
            this.txtNum.TabIndex = 8;
            this.txtNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNum_KeyDown);
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(729, 22);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(191, 27);
            this.txtSum.TabIndex = 7;
            // 
            // dgvGrid
            // 
            this.dgvGrid.AllowUserToAddRows = false;
            this.dgvGrid.AllowUserToDeleteRows = false;
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrid.Location = new System.Drawing.Point(3, 23);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.RowHeadersWidth = 51;
            this.dgvGrid.RowTemplate.Height = 29;
            this.dgvGrid.Size = new System.Drawing.Size(1061, 429);
            this.dgvGrid.TabIndex = 0;
            this.dgvGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrid_CellClick);
            // 
            // FM_Portfolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FM_Portfolio";
            this.Text = "나의 주식";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodeName;
        private System.Windows.Forms.Label labe1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboStock;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoKospi;
        private System.Windows.Forms.RadioButton rdoKosdaq;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAccountHidden;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOwn;
        private System.Windows.Forms.TextBox txtSeed2;
    }
}