using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SP_PJT_3;


namespace SP_PJT_3
{
    public partial class FM_Option : Form
    {
        public FM_Option()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //잘못누름
        }

        public void Inquire()
        {
            // DB HELPER 선언
            DBHelper helper = new DBHelper(false);
            try
            {
                string stxtCodeName = txtCodeName.Text;   //품목 코드
                string stxtSec = cboStock.Text; //섹터
                string stxtSort = "";  //분류
                if       (rdoKospi.Checked == true) stxtSort = "KOSPI";   //코스피 
                else if (rdoKosdaq.Checked == true) stxtSort = "KOSDAQ";   //코스닥
                else stxtSort = "";

                DataTable dtTemp = new DataTable();
                dtTemp = helper.FillTable("SP_3_MAINSEARCH_S1", CommandType.StoredProcedure
                                          , helper.CreateParameter("txtCode", stxtCodeName)
                                          , helper.CreateParameter("txtSec", stxtSec)
                                          , helper.CreateParameter("txtSort", stxtSort));
                if (dtTemp.Rows.Count == 0)
                {
                    dtTemp = helper.FillTable("SP_3_MAINSEARCH_S2", CommandType.StoredProcedure
                                          , helper.CreateParameter("txtName", stxtCodeName)
                                          , helper.CreateParameter("txtSec", stxtSec)
                                          , helper.CreateParameter("txtSort", stxtSort));
                    if (dtTemp.Rows.Count !=0)
                    {
                        dgvGrid.DataSource = dtTemp;
                        return;
                    }
                    dgvGrid.DataSource = null;
                    MessageBox.Show("조회할 데이터가 없습니다.");
                }
                else
                {
                    //그리드 뷰에 데이터 삽입.
                    dgvGrid.DataSource = dtTemp;
                }
            }
            catch (Exception ex) { }
            finally
            {
                helper.Close();
            }

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Inquire();
            if (dgvGrid.Rows.Count == 0) return;
            //그리드뷰의  헤더 명칭 선언
            dgvGrid.Columns["txtCode"].HeaderText = "종목 코드";
            dgvGrid.Columns["txtName"].HeaderText = "종목 명";
            dgvGrid.Columns["txtPrice"].HeaderText = "현재가";
            dgvGrid.Columns["datetime"].HeaderText = "현재가 지정시간";
            dgvGrid.Columns["txtSec"].HeaderText = "섹터";
            dgvGrid.Columns["txtSort"].HeaderText = "분류";
            dgvGrid.Columns["txtInfo"].HeaderText = "상세설명";

            //그리드 뷰의 폭 지정
            dgvGrid.Columns[0].Width = 120;
            dgvGrid.Columns[1].Width = 100;
            dgvGrid.Columns[2].Width = 100;
            dgvGrid.Columns[3].Width = 100;
            dgvGrid.Columns[4].Width = 150;
            dgvGrid.Columns[5].Width = 100;
            dgvGrid.Columns[6].Width = 800;

            //컬럼의 수정 여부를 지정 한다
            dgvGrid.Columns["txtCode"].ReadOnly = true;
            dgvGrid.Columns["txtName"].ReadOnly = true;
            dgvGrid.Columns["txtPrice"].ReadOnly = true;
            dgvGrid.Columns["datetime"].ReadOnly = true;
            dgvGrid.Columns["txtSec"].ReadOnly = true;
            dgvGrid.Columns["txtSort"].ReadOnly = true;
            dgvGrid.Columns["txtInfo"].ReadOnly = true;
        }
        private void dgvGrid_CellClick(object sender, DataGridViewCellEventArgs e)  // 셀 선택시 종목명, 가격 가져오기
        {
            txtName.Text = dgvGrid.CurrentRow.Cells["txtName"].Value.ToString();
            txtPrice.Text = dgvGrid.CurrentRow.Cells["txtPrice"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)  //거래금 총합, 보유 예수금 확인 이벤트
        {
            float stxtSum;
            stxtSum = float.Parse(txtPrice.Text) * float.Parse(txtNum.Text);
            txtSum.Text = stxtSum.ToString();

            DBHelper helper = new DBHelper(false);
            try
            {
                DataTable dtTemp = new DataTable();
                dtTemp = helper.FillTable("SP_3_USERSEED_s1", CommandType.StoredProcedure
                                             , helper.CreateParameter("txtid", Common.LogInId));
                if (dtTemp.Rows.Count == 0) return;
                txtOwn.Text = dtTemp.Rows[0]["txtSeed"].ToString();
            }
            catch (Exception ex){}
            finally
            {
                helper.Close();
            }
            
            DBHelper helper2 = new DBHelper(false);
            try
            {
                DataTable dtTemp = new DataTable();
                dtTemp = helper2.FillTable("SP_3_USERACCOUNT_s1", CommandType.StoredProcedure
                                             , helper2.CreateParameter("txtid", Common.LogInId));
                if (dtTemp.Rows.Count == 0) return;
                txtAccountHidden.Text = dtTemp.Rows[0]["txtAccount"].ToString();
            }
            catch (Exception ex) { }
            finally
            {
                helper2.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)  // 매수 버튼 클릭 이벤트
        {
            string stxtCode = dgvGrid.CurrentRow.Cells["txtCode"].Value.ToString();
            string stxtName = dgvGrid.CurrentRow.Cells["txtName"].Value.ToString();
            string stxtAccount = txtAccountHidden.Text.ToString();
            string sdatetime = string.Empty;
            string stxtResult = dgvGrid.CurrentRow.Cells["txtPrice"].Value.ToString();
            string stxtNum = txtNum.Text.ToString();
            string stxtSum = txtSum.Text.ToString();
            string stxtType = "매수";

            if (MessageBox.Show("매수를 진행하시겠습니까?", "데이터 저장",
                MessageBoxButtons.YesNo) == DialogResult.No) return;
            DBHelper helper = new DBHelper(true);
            try
            {
                helper.ExecuteNoneQuery("SP_3_MAINBUY_S1", CommandType.StoredProcedure
                                        , helper.CreateParameter("txtCode", stxtCode)
                                        , helper.CreateParameter("txtName", stxtName)
                                        , helper.CreateParameter("txtAccount", stxtAccount) 
                                        , helper.CreateParameter("txtResult", stxtResult)
                                        , helper.CreateParameter("txtNum", stxtNum)
                                        , helper.CreateParameter("txtSum", stxtSum)
                                        , helper.CreateParameter("txtType", stxtType)
                                        );
                //성공시 DB COMMIT
                helper.Commit();
                //메세지
                MessageBox.Show("매수가 채결되었습니다.");
            }
            catch (Exception ex)
            {
                //트랙잭션 롤백
                helper.Rollback();
                //메세지
                MessageBox.Show("매수에 실패 하였습니다.");
            }
            finally
            {
                //DB CLOSE
                helper.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e) // 매도 버튼 클릭 이벤트
        {
            string stxtCode = dgvGrid.CurrentRow.Cells["txtCode"].Value.ToString();
            string stxtName = dgvGrid.CurrentRow.Cells["txtName"].Value.ToString();
            string stxtAccount = txtAccountHidden.Text.ToString();
            string sdatetime = string.Empty;
            string stxtResult = dgvGrid.CurrentRow.Cells["txtPrice"].Value.ToString();
            string stxtNum = txtNum.Text.ToString();
            string stxtSum = txtSum.Text.ToString();
            string stxtType = "매도";

            if (MessageBox.Show("매도를 진행하시겠습니까?", "데이터 저장",
                MessageBoxButtons.YesNo) == DialogResult.No) return;
            DBHelper helper = new DBHelper(true);
            try
            {
                helper.ExecuteNoneQuery("SP_3_MAINCELL_S1", CommandType.StoredProcedure
                                        , helper.CreateParameter("txtCode", stxtCode)
                                        , helper.CreateParameter("txtName", stxtName)
                                        , helper.CreateParameter("txtAccount", stxtAccount)
                                        , helper.CreateParameter("txtResult", stxtResult)
                                        , helper.CreateParameter("txtNum", stxtNum)
                                        , helper.CreateParameter("txtSum", stxtSum)
                                        , helper.CreateParameter("txtType", stxtType)
                                        );
                //성공시 DB COMMIT
                helper.Commit();
                //메세지
                MessageBox.Show("매도가 채결되었습니다.");
            }
            catch (Exception ex)
            {
                //트랙잭션 롤백
                helper.Rollback();
                //메세지
                MessageBox.Show("매도에 실패 하였습니다.");
            }
            finally
            {
                //DB CLOSE
                helper.Close();
            }
        }

        private void txtCodeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button4_Click(null, null);
            }
        }
    }
}
