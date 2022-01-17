using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_PJT_3
{
    public partial class FM_CpCd : Form
    {

        private SqlConnection Connect = null;
        private string strConn = "Data Source=222.235.141.8;Initial Catalog=AppDev; User ID = kfqs1; Password=1234";

        public FM_CpCd()
        {
            InitializeComponent();
        }

        private void FM_CpCd_Load(object sender, EventArgs e)
        {
            pictureBox1.LoadAsync(@"https://ssl.pstatic.net/imgfinance/chart/mobile/day/KOSPI_search.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.LoadAsync(@"https://ssl.pstatic.net/imgfinance/chart/mobile/day/KOSDAQ_search.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void btn_kospi1day_Click(object sender, EventArgs e)
        {
            pictureBox1.LoadAsync(@"https://ssl.pstatic.net/imgfinance/chart/mobile/day/KOSPI_search.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_kospi3months_Click(object sender, EventArgs e)
        {
            pictureBox1.LoadAsync(@"https://ssl.pstatic.net/imgfinance/chart/mobile/area/month3/KOSPI_search.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_kospi1year_Click(object sender, EventArgs e)
        {
            pictureBox1.LoadAsync(@"https://ssl.pstatic.net/imgfinance/chart/mobile/area/year/KOSPI_search.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_kosdak1day_Click(object sender, EventArgs e)
        {
            pictureBox2.LoadAsync(@"https://ssl.pstatic.net/imgfinance/chart/mobile/day/KOSDAQ_search.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_kosdak3months_Click(object sender, EventArgs e)
        {
            pictureBox2.LoadAsync(@"https://ssl.pstatic.net/imgfinance/chart/mobile/area/month3/KOSDAQ_search.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_kosdak1year_Click(object sender, EventArgs e)
        {
            pictureBox2.LoadAsync(@"https://ssl.pstatic.net/imgfinance/chart/mobile/area/year/KOSDAQ_search.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_kospi_refresh_Click(object sender, EventArgs e)
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("headless");
            List<Webdata> testdata01 = new List<Webdata>();

            using (IWebDriver driver = new ChromeDriver(service, option))
            {
                //for (int i = 1; i < 11; i++)
                //{
                    driver.Url = $"https://finance.naver.com/sise/sise_market_sum.nhn?sosok=0&page=1";
                    List<IWebElement> list = driver.FindElements(By.CssSelector("body div div div div table tbody tr")).ToList();

                    foreach (IWebElement x in list)
                    {
                        try
                        {
                            List<IWebElement> list1 = x.FindElements(By.CssSelector("td")).ToList();
                            testdata01.Add(new Webdata()
                            {
                                Com_Name = list1[1].Text,
                                Price_now = list1[2].Text,
                                date_time = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")
                            });
                            Thread.Sleep(100);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("error : " + ex);
                        }
                    }
                //}
                Console.WriteLine("데이터 조회 완료");
                //  }

                SqlCommand cmd = new SqlCommand();
                SqlTransaction Tran;

                Connect = new SqlConnection(strConn);
                Connect.Open();

                //foreach (Webdata g in testdata01)
                for (int i = 0; i < testdata01.Count; i++)
                {

                    Tran = Connect.BeginTransaction("TESTTRAN");
                    cmd.Transaction = Tran;
                    cmd.Connection = Connect;
                    try
                    {
                        cmd.CommandText = "UPDATE KFQ_3_StockTB                        " +
                                          "   SET   txtPrice = '" + testdata01[i].Price_now + "',   " +
                                          "         datetime = '" + testdata01[i].date_time + "'   " +
                                          "  WHERE txtName = '" + testdata01[i].Com_Name + "'     " +
                                           " IF (@@ROWCOUNT =0) " +
                                              "INSERT INTO KFQ_3_StockTB (txtName ,txtPrice, datetime )" +
                                              "VALUES ('" + testdata01[i].Com_Name + "','" + testdata01[i].Price_now + "','" + testdata01[i].date_time +"')";
                        cmd.ExecuteNonQuery();

                        Tran.Commit();
                        if (i == testdata01.Count - 1)
                            MessageBox.Show("정상적으로 등록 하였습니다.");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error  : " + ex);
                        Tran.Rollback(); //MessageBox.Show("데이터 저장에 실패했습니다.");
                    }
                }
                Connect.Close();
            }
        }

        private void btn_kosdak_refresh_Click(object sender, EventArgs e)
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("headless");
            List<Webdata> testdata02 = new List<Webdata>();

            using (IWebDriver driver = new ChromeDriver(service, option))
            {
             //   for (int i = 1; i < 11; i++)
              //  {
                    driver.Url = $"https://finance.naver.com/sise/sise_market_sum.nhn?sosok=1&page=1";
                    List<IWebElement> list = driver.FindElements(By.CssSelector("body div div div div table tbody tr")).ToList();

                    foreach (IWebElement x in list)
                    {
                        try
                        {
                            List<IWebElement> list1 = x.FindElements(By.CssSelector("td")).ToList();
                            testdata02.Add(new Webdata()
                            {
                                Com_Name = list1[1].Text,
                                Price_now = list1[2].Text,
                                date_time = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")

                            });
                            Thread.Sleep(100);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("error : " + ex);
                        }
                    }
              //  }
                Console.WriteLine("데이터 조회 완료");

                SqlCommand cmd = new SqlCommand();
                SqlTransaction Tran;

                Connect = new SqlConnection(strConn);
                Connect.Open();

                //foreach (Webdata g in testdata01)
                for (int i = 0; i < testdata02.Count; i++)
                {

                    Tran = Connect.BeginTransaction("TESTTRAN");
                    cmd.Transaction = Tran;
                    cmd.Connection = Connect;
                    try
                    {
                        cmd.CommandText = "UPDATE KFQ_3_StockTB                        " +
                                          "   SET   txtPrice = '" + testdata02[i].Price_now + "',   " +
                                          "          datetime = '" + testdata02[i].date_time + "'   " +
                                          "  WHERE txtName = '" + testdata02[i].Com_Name + "'     " +
                                           " IF (@@ROWCOUNT =0) " +
                                              "INSERT INTO KFQ_3_StockTB (txtName ,txtPrice, datetime )" +
                                              "VALUES ('" + testdata02[i].Com_Name + "','" + testdata02[i].Price_now + "','" + testdata02[i].date_time + "')";
                        cmd.ExecuteNonQuery();

                        Tran.Commit();
                        if (i == testdata02.Count - 1)
                            MessageBox.Show("정상적으로 등록 하였습니다.");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error  : " + ex);
                        Tran.Rollback(); 
                    }
                }
                Connect.Close();
            }
        }
    }
}
