using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SP_PJT_3
{
    public partial class FM_Port2 : Form
    {
        private SqlConnection Connect = null;
        private string strConn = "Data Source=222.235.141.8; Initial Catalog=AppDev;User ID=kfqs1;Password=1234";
        public FM_Port2()
        {
            InitializeComponent();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
        #region 조회
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Connect = new SqlConnection(strConn);
                Connect.Open();
                if (Connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패하였습니다.");
                    return;
                }
                string stxtID = txtID.Text;

                // 전체 검색
                if (checkBox1.Checked == true) stxtID = "";

                string sSql = "SELECT txtID,  " +
                                                            "       txtPWD,       " +
                                                            "       txtUserName,  " +
                                                            "       txtAccount,   " +
                                                            "       txtSeed,      " +
                                                            "       txtOwn,       " +
                                                            "       SUBSTRING(convert(varchar,datetime,120),1,10) as datetime       " +
                                                            "       FROM KFQ_3_UserTB WITH(NOLOCK)" +
                                                           $" WHERE txtID LIKE '%{stxtID}%' ";
                SqlDataAdapter adapter = new SqlDataAdapter(sSql, Connect);

                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);

                if (dtTemp.Rows.Count == 0)
                {   // 조회할 데이터 없을 때 초기화
                    MessageBox.Show("검색 조건에 맞는 데이터가 없습니다.");
                    dataGridView1.DataSource = null;
                    return;
                }

                dataGridView1.DataSource = dtTemp;

                // 그리드뷰 칼럼명칭지정
                dataGridView1.Columns["txtID"].HeaderText = "아이디";
                dataGridView1.Columns["txtPWD"].HeaderText = "비밀번호";
                dataGridView1.Columns["txtUserName"].HeaderText = "이름";
                dataGridView1.Columns["txtAccount"].HeaderText = "계좌";
                dataGridView1.Columns["txtSeed"].HeaderText = "예수금";
                dataGridView1.Columns["txtOwn"].HeaderText = "보유자산";
                dataGridView1.Columns["datetime"].HeaderText = "가입 날짜";

                // 그리드뷰 폭 지정
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].Width = 80;
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].Width = 300;
                dataGridView1.Columns[4].Width = 150;

                //// 칼럼 수정 여부
                dataGridView1.Columns["txtID"].ReadOnly = true;
                dataGridView1.Columns["txtUserName"].ReadOnly = true;
                dataGridView1.Columns["txtAccount"].ReadOnly = true;
                dataGridView1.Columns["datetime"].ReadOnly = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connect.Close();
            }
        }
        #endregion


        #region 추가버튼클릭
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count == 0) 
            {
                DataTable Temp_datatable = new DataTable();
                Temp_datatable.Columns.Add("txtID");
                Temp_datatable.Columns.Add("txtPWD");
                Temp_datatable.Columns.Add("txtUserName");
                Temp_datatable.Columns.Add("txtAccount");
                Temp_datatable.Columns.Add("txtSeed");
                Temp_datatable.Columns.Add("txtOwn");
                Temp_datatable.Columns.Add("datetime");

                dataGridView1.DataSource = Temp_datatable;
                DataRow dr_temp = ((DataTable)dataGridView1.DataSource).NewRow();
                ((DataTable)dataGridView1.DataSource).Rows.Add(dr_temp);
            }
            else
            {
                DataRow dr = ((DataTable)dataGridView1.DataSource).NewRow();
                ((DataTable)dataGridView1.DataSource).Rows.Add(dr);
            }

            dataGridView1.Columns["txtID"].ReadOnly = false;
            dataGridView1.Columns["txtUserName"].ReadOnly = false;
            dataGridView1.Columns["txtAccount"].ReadOnly = false;

            dataGridView1.Columns["txtID"].HeaderText = "아이디";
            dataGridView1.Columns["txtPWD"].HeaderText = "비밀번호";
            dataGridView1.Columns["txtUserName"].HeaderText = "이름";
            dataGridView1.Columns["txtAccount"].HeaderText = "계좌";
            dataGridView1.Columns["txtSeed"].HeaderText = "예수금";
            dataGridView1.Columns["txtOwn"].HeaderText = "보유자산";
            dataGridView1.Columns["datetime"].HeaderText = "가입 날짜";

            // 추가된 행 선택
            int MaxRow = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[MaxRow].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[MaxRow].Cells[0];
        }
        #endregion


        #region 저장버튼클릭
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 데이터를 저장하시겠습니까??", "Save", MessageBoxButtons.YesNo) == DialogResult.No) return;

            string stxtID = dataGridView1.CurrentRow.Cells["txtID"].Value.ToString();
            string stxtPWD = dataGridView1.CurrentRow.Cells["txtPWD"].Value.ToString();
            string stxtUserName = dataGridView1.CurrentRow.Cells["txtUserName"].Value.ToString();
            string stxtAccount = dataGridView1.CurrentRow.Cells["txtAccount"].Value.ToString();
            string stxtSeed = dataGridView1.CurrentRow.Cells["txtSeed"].Value.ToString();
            string stxtOwn = dataGridView1.CurrentRow.Cells["txtOwn"].Value.ToString();

            if (stxtID == "" || stxtPWD == "" || stxtAccount == "")
            {
                MessageBox.Show("'아이디', '비밀번호', '계좌' 는 빈칸으로 남겨둘 수 없습니다.");
                return;
            }

            SqlCommand Cmd = new SqlCommand();
            SqlTransaction tran;

            Connect = new SqlConnection(strConn);
            Connect.Open();

            tran = Connect.BeginTransaction("Test Transaction");
            Cmd.Transaction = tran;
            Cmd.Connection = Connect;

            Cmd.CommandText = "UPDATE KFQ_3_UserTB                     " +
                             $"   SET txtID        = '{stxtID}',       " +
                             $"       txtPWD       = '{stxtPWD}',      " +
                             $"       txtUserName  = '{stxtUserName}', " +
                             $"       txtAccount   = '{stxtAccount}',  " +
                             $"       txtSeed      = '{stxtSeed}',     " +
                             $"       txtOwn       = '{stxtOwn}',      " +
                             $"       datetime     = GETDATE()         " +
                             $" where txtAccount =  '{stxtAccount}'    " +
                             " IF (@@ROWCOUNT =0)                      " +
                             " INSERT INTO KFQ_3_UserTB (   txtID,       txtPWD,     txtUserName,  txtAccount,        txtSeed,     txtOwn,      datetime) " +
                             $"VALUES (               '{stxtID}', '{stxtPWD}', '{stxtUserName}', '{stxtAccount}', '{stxtSeed}', '{stxtOwn}', GETDATE())";
            Cmd.ExecuteNonQuery();
            tran.Commit();

            MessageBox.Show("성공적으로 저장하였습니다.");
            Connect.Close();
        }
        #endregion


        #region 삭제버튼클릭
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 데이터를 삭제하시겠습니까", "데이터삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;

            SqlCommand cmd = new SqlCommand();
            SqlTransaction tran;

            Connect = new SqlConnection(strConn);
            Connect.Open();

            // 트랜잭션시작
            tran = Connect.BeginTransaction("TranStart");
            cmd.Transaction = tran;
            cmd.Connection = Connect;

            try
            {
                string stxtID = dataGridView1.CurrentRow.Cells["txtID"].Value.ToString();
                cmd.CommandText = "DELETE KFQ_3_UserTB WHERE txtID = '" + stxtID + "'";

                cmd.ExecuteNonQuery();

                // 성공시 DB Commit
                tran.Commit();
                MessageBox.Show("정상적으로 삭제하였습니다.");
                button3_Click(null, null);
            }
            catch
            {
                tran.Rollback();
                MessageBox.Show("데이터삭제에 실패하였습니다.");
            }
            finally
            {
                Connect.Close();
            }
        }
        #endregion

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3_Click(null, null);
            }
        }
    }
}
