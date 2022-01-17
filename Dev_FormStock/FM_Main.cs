using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SP_PJT_3;
using System.Reflection;

namespace Dev_FormStock
{
    public partial class FM_Main : Form
    {
        public FM_Main()
        {
            InitializeComponent();
            SP_PJT_3.FM_Login login = new SP_PJT_3.FM_Login();
            login.ShowDialog();

            tssUserName.Text = login.Tag.ToString();
            if (login.Tag.ToString() == "FAIL")
            {
                System.Environment.Exit(0);
            }
            // 버튼 종료이벤트 추가
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // 버튼 닫기이벤트 추가
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // 버튼 홈 이벤트 추가
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);

            // 메뉴 이벤트 추가
            this.CustomerMenu.DropDownItemClicked +=
                new System.Windows.Forms.ToolStripItemClickedEventHandler(BarMenu_DropDownItemClicked);

            // 메뉴 이벤트 추가
            this.ManagerMenu.DropDownItemClicked +=
                new System.Windows.Forms.ToolStripItemClickedEventHandler(BarMenu_DropDownItemClicked);
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            tssNowDate.Text = DateTime.Now.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            // 열려있는 화면이 있는지 확인
            if (MyTabControl1.TabPages.Count == 0) return;

            // 선택된 탭페이지를 닫는다.
            MyTabControl1.SelectedTab.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CustomerMenu_DropDownItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
        }
        private void ManagerMenu_DropDownItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
        }
        private void BarMenu_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Assembly assemb = Assembly.LoadFrom(Application.StartupPath + @"\" + "SP_PJT_3.DLL");
            Type typeForm = assemb.GetType("SP_PJT_3." + e.ClickedItem.Name.ToString(), true);
            Form ShowForm = (Form)Activator.CreateInstance(typeForm);

            // 해당되는 폼이 이미 오픈되어 있는지 확인 후 활성화 또는 신규 오픈 한다.
            for (int i = 0; i < MyTabControl1.TabPages.Count; i++)
            {
                if (MyTabControl1.TabPages[i].Name == e.ClickedItem.Name.ToString())
                {
                    MyTabControl1.SelectedTab = MyTabControl1.TabPages[i];
                    return;
                }
            }
            if (e.ClickedItem.Name.ToString() == "FM_Port2")
            {
                FM_JustSystem JustSystem = new FM_JustSystem();
                JustSystem.ShowDialog();
                if (JustSystem.Tag.ToString() == "FAIL")
                {
                    return;
                }
            }
            MyTabControl1.AddForm(ShowForm);
        }
               

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }

    public partial class MDIForm : TabPage
    { }

    public partial class MyTabControler : TabControl
    {
        public void AddForm(Form NewForm)
        {
            if (NewForm == null) return;  // 인자로 받은 폼이 없을경우 실행 중지
            NewForm.TopLevel = false;     // 인자로 받은 폼이 최상위 개체가 아님을 선언 
            MDIForm page = new MDIForm(); // 탭 페이지 객체 생성 
            page.Controls.Clear();        // 페이지 초기화
            page.Controls.Add(NewForm);   // 페이지에 폼 추가
            page.Text = NewForm.Text;     // 폼에서 지정한 명칭으로 탭 페이지 설정
            page.Name = NewForm.Name;     // 폼에서 설정한 이름으로 탭 페이지 설정
            base.TabPages.Add(page);      // 탭 컨트롤에 페이지를 추가한다.
            NewForm.Show();               // 인자로 받은 폼을 보여준다
            base.SelectedTab = page;      // 현재 선택된 페이지를 호출한 폼의 페이지로 설정한다.
        }
    }
}
