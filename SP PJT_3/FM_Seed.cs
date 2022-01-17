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
using SP_PJT_3;

namespace SP_PJT_3
{
    public partial class FM_Seed : Form
    {
        private SqlConnection Conn = null;
        private SqlConnection Connect = null;
        private SqlTransaction Tran;
        private SqlCommand cmd = new SqlCommand();
        private string ConnInfo = Common.DbPath;


        public FM_Seed()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Conn = new SqlConnection(ConnInfo);
                Conn.Open();

                if (Conn.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패 하였습니다.");
                    return;
                }

                string stxtAccount = txtAccount.Text;
                string txtSeed = "";

                string sSql = "SELECT txtSeed " +
                              "FROM  KFQ_3_UserTB WITH(NOLOCK) " +
                              $"WHERE txtAccount LIKE '%{stxtAccount}%' "; 
                SqlDataAdapter Adapter = new SqlDataAdapter(sSql, Conn);
                DataTable DtTemp = new DataTable();
                Adapter.Fill(DtTemp);
                if (DtTemp.Rows.Count == 0) return;
                this.txtSeed.Text = DtTemp.Rows[0]["txtSeed"].ToString();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Conn.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strCon = "Data Source=222.235.141.8; Initial Catalog=AppDev;User ID=kfqs1;Password=1234";
            Connect = new SqlConnection(strCon);

            Connect.Open();

            if (Connect.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("데이터 베이스 연결에 실패하였습니다.");
                return;
            }

            string stxtAccount = string.Empty;
            string stxtAdd = string.Empty;
            stxtAccount = txtAccount.Text;
            stxtAdd = txtAdd.Text;

            
                       
            if (MessageBox.Show("해당 예수금을 추가하시겠습니까?",
                                "예수금 추가", MessageBoxButtons.YesNo)
                               == DialogResult.No) return;
            Tran = Connect.BeginTransaction("TEST_Tran");
            cmd.Transaction = Tran;
            cmd.Connection = Connect;
            cmd.CommandText = "UPDATE KFQ_3_UserTB SET txtSeed = txtSeed + '" + stxtAdd + "' WHERE txtaccount = '" + stxtAccount + "'";
            cmd.ExecuteNonQuery();
            Tran.Commit();

            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT txtSeed FROM KFQ_3_UserTB WHERE txtAccount = '" + stxtAccount + "'", Connect);

            DataTable DtTemp = new DataTable();
            Adapter.Fill(DtTemp);
            txtMyTotalSeed.Text = DtTemp.Rows[0]["txtSeed"].ToString();
            MessageBox.Show("정상적으로 변경 하였습니다.");
                this.Close();
            }
        }
    }

