using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SP_PJT_3
{
    public partial class FM_JustSystem : Form
    {
        private SqlConnection Connect = null;

        public FM_JustSystem()
        {
            InitializeComponent();
            this.Tag = "FAIL";
        }
        private int PwFailCount = 0;
        private void txtJustSystem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSystemLogin_Click(null, null);
            }
        }

        private void btnSystemLogin_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = true;
                string strConn = "Data Source=222.235.141.8; Initial Catalog=AppDev;User ID=kfqs1;Password=1234";
                Connect = new SqlConnection(strConn);

                Connect.Open();
                if (Connect.State != System.Data.ConnectionState.Open) MessageBox.Show("데이터 베이스 연결에 실패 하였습니다.");
                string stxtJustSystem = txtJustSystem.Text;

                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT txtSystemPW FROM KFQ_3_UserTB WHERE txtSystemPW = '" + stxtJustSystem + "'", Connect);
                DataTable DtTemp = new DataTable();
                Adapter.Fill(DtTemp);

                if (DtTemp.Rows.Count == 0)
                {                    
                    txtJustSystem.Text = "";
                    txtJustSystem.Focus();
                    PwFailCount += 1;
                    MessageBox.Show("비밀번호가 잘못되었습니다. 누적 횟수 : " + PwFailCount.ToString());
                    if (PwFailCount == 3)
                    {
                        MessageBox.Show("3회 이상 비밀번호를 잘못입력하여 프로그램을 종료합니다.");
                        this.Close();
                        return;
                    }
                    else
                    {
                        Common.LogInSystem = txtJustSystem.Text; 
                    }
                }
                else
                {
                    MessageBox.Show("관리자로 접속하셨습니다.");
                    this.Tag = "SUCCESS";
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("관리자 로그인 작업중 오류가 발생하였습니다." + ex.ToString());
            }
            finally
            {
                Connect.Close();
            }
        }
    }
  }

