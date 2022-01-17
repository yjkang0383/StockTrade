using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace SP_PJT_3
{
    public partial class FM_Login : Form
    {
        private SqlConnection Connect = null;

        public FM_Login()
        {
            InitializeComponent();
            this.Tag = "FAIL";
        }
        private int PwFailCount = 0;       

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Visible = true;
                string strConn = "Data Source=222.235.141.8; Initial Catalog=AppDev;User ID=kfqs1;Password=1234";               
                Connect = new SqlConnection(strConn);
                
                Connect.Open();
                if (Connect.State != System.Data.ConnectionState.Open) MessageBox.Show("데이터 베이스 연결에 실패 하였습니다.");
                string sLogInId = txtID.Text;
                string sPassWord = txtPassword.Text;                
                
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT txtPWD,txtUserName FROM KFQ_3_UserTB WHERE txtID = '" + sLogInId + "'", Connect);
                DataTable DtTemp = new DataTable();
                Adapter.Fill(DtTemp);

                if (DtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("로그인 ID가 잘못되었습니다.");
                    txtPassword.Focus();
                    return;
                }
                else if (txtPassword.Text != DtTemp.Rows[0]["txtPWD"].ToString())
                {
                    txtPassword.Text = "";
                    txtPassword.Focus();
                    PwFailCount += 1;
                    MessageBox.Show("비밀번호가 잘못되었습니다. 누적 횟수 : " + PwFailCount.ToString());
                    if (PwFailCount == 3)
                    {
                        MessageBox.Show("3회 이상 비밀번호를 잘못입력하여 프로그램을 종료합니다.");
                        this.Close();
                    }
                    return;
                }
                else
                {
                    Common.LogInId = txtID.Text;
                    Common.LogInName = DtTemp.Rows[0]["txtUserName"].ToString();
                    this.Tag = DtTemp.Rows[0]["txtUserName"].ToString();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("로그인 작업중 오류가 발생하였습니다." + ex.ToString());
            }
            finally
            {
                Connect.Close();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_Click_1(null, null);
            }
        }

        private void btnPWChang_Click(object sender, EventArgs e)
        {
            this.Visible = false;  
            FM_PassWord FmPassWord = new FM_PassWord();
            FmPassWord.ShowDialog();
            this.Visible = true;
        }
    }
}
    
        
