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
using System.Reflection;

namespace SP_PJT_3
{
    public partial class FM_PassWord : Form
    {
        private SqlConnection  Connect = null;  
        private SqlTransaction  Tran;           
        private SqlCommand  cmd = new SqlCommand(); 
        public FM_PassWord()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChPw_Click(object sender, EventArgs e)
        {
            string strCon = "Data Source=222.235.141.8; Initial Catalog=AppDev;User ID=kfqs1;Password=1234";
            Connect = new SqlConnection(strCon);

            Connect.Open(); 

            if (Connect.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("데이터 베이스 연결에 실패하였습니다.");
                return;
            }
            
            string sLoinid = string.Empty; 
            string sPerPw  = string.Empty; 
            string sNewPw  = string.Empty; 

            sLoinid = txtUserID.Text;
            sPerPw  = txtPerPw.Text;
            sNewPw  = txtChPw.Text;
                        
            SqlDataAdapter Adapter = new SqlDataAdapter(
                "SELECT txtPWD FROM KFQ_3_UserTB WHERE txtID = '" + sLoinid  + "'", Connect);
                        
            DataTable DtTemp = new DataTable();
                       
            Adapter.Fill(DtTemp);

            if (DtTemp.Rows.Count == 0)
            {
                MessageBox.Show("등록되지 않은 사용자 입니다.");
                return;
            }
                        
            else if (DtTemp.Rows[0]["txtPWD"].ToString() != sPerPw)
            {
                MessageBox.Show("이전 비밀번호가 일치하지 않습니다.");
                return;
            }
           
            else
            {               
                if (MessageBox.Show("해당 비밀번호로 변경 하시겠습니까?",
                                    "비밀번호 변경", MessageBoxButtons.YesNo)
                                   == DialogResult.No) return;
                Tran = Connect.BeginTransaction("TEST_Tran"); 
                cmd.Transaction = Tran;   
                cmd.Connection = Connect; 
                cmd.CommandText = "UPDATE KFQ_3_UserTB SET txtPWD = '" + sNewPw + "' WHERE txtID = '" + sLoinid + "'";
                cmd.ExecuteNonQuery(); 

                Tran.Commit();  
                MessageBox.Show("정상적으로 변경 하였습니다.");
                this.Close();
            }
        }

        private void txtChPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChPw_Click(null, null);
            }
        }
    }
}
