using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace dbtp
{
    public partial class AdminForm : Form
    {
        OleDbConnection conn;
        string connectionString = "Provider=OraOLEDB.Oracle;Password=1q2w3e;User ID=system";    // oracle 서버 연결

        OleDbDataAdapter adapter;
        DataSet ds;

        Image image = null;
        Image thumnail_img = null;

        private void init()
        {
            ds = new DataSet("승인여부");

            conn = new OleDbConnection(connectionString);
            conn.Open();
            adapter = new OleDbDataAdapter("select 회원이름, 승인여부 from 회원", conn);
            adapter.Fill(ds);
            joingrid.DataSource = ds.Tables[0];

            conn.Close(); // 데이터베이스 연결 해제

            ds = new DataSet("등급");

            conn = new OleDbConnection(connectionString);
            conn.Open();
            adapter = new OleDbDataAdapter("select 회원이름, 등급 from 회원", conn);
            adapter.Fill(ds);
            gradegrid.DataSource = ds.Tables[0];

            conn.Close(); // 데이터베이스 연결 해제

            ds = new DataSet("할인율");

            conn = new OleDbConnection(connectionString);
            conn.Open();
            adapter = new OleDbDataAdapter("select * from 할인율 order by 할인율", conn);
            adapter.Fill(ds);
            dcgrid.DataSource = ds.Tables[0];

            conn.Close(); // 데이터베이스 연결 해제
        }

        public AdminForm()
        {
            InitializeComponent();

            Panel_init();

            try
            {
                init();
            }
           
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // 에러 메세지
            }
        }

        private void ybtn1_Click(object sender, EventArgs e)
        {
            String name = namebox1.Text;

            if (name != "")
            {
                try
                {
                    conn.Open(); //데이터베이스 연결

                    OleDbCommand cmd = new OleDbCommand();
                    String query = $"update 회원 set 승인여부 ='" + 'Y' + "' where 회원이름 ='" + name + "'";

                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text; // 검색명령을 쿼리 형태로
                    cmd.Connection = conn;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("회원가입이 승인되었습니다.", "회원가입 승인");
                }

                catch (System.Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); // 에러 메세지
                }
            }

            conn.Close(); // 데이터베이스 연결 해제

            init();
        }

        private void nbtn_Click(object sender, EventArgs e)
        {
            String name = namebox1.Text;

            if (name != "")
            {
                try
                {
                    conn.Open(); //데이터베이스 연결

                    OleDbCommand cmd = new OleDbCommand();
                    String query = $"update 회원 set 승인여부 ='" + 'N' + "' where 회원이름 ='" + name + "'";

                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text; // 검색명령을 쿼리 형태로
                    cmd.Connection = conn;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("회원가입이 거절되었습니다.", "회원가입 거절");
                }

                catch (System.Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); // 에러 메세지
                }
            }

            conn.Close(); // 데이터베이스 연결 해제

            init();
        }

        private void ybtn2_Click(object sender, EventArgs e)
        {
            String name = namebox2.Text;
            String grade = gradebox1.Text;

            try
            {
                conn.Open(); //데이터베이스 연결

                OleDbCommand cmd = new OleDbCommand();
                String query = $"update 회원 set 등급 ='" + grade + "' where 회원이름 ='" + name + "'";

                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; // 검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();
                MessageBox.Show("등급이 변경되었습니다.", "회원등급 변경완료");
            }

            catch (System.Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // 에러 메세지
            }

            conn.Close(); // 데이터베이스 연결 해제

            init();
        }

        private void ybtn3_Click(object sender, EventArgs e)
        {
            String grade = gradebox2.Text;
            String dc = dcbox.Text;

            try
            {
                conn.Open(); //데이터베이스 연결

                OleDbCommand cmd = new OleDbCommand();
                String query = $"update 할인율 set 할인율 ='" + dc + "' where 등급 ='" + grade + "'";

                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; // 검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();
                MessageBox.Show("할인율이 변경되었습니다.", "할인율 변경완료");
            }

            catch (System.Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // 에러 메세지
            }

            conn.Close(); // 데이터베이스 연결 해제

            init();
        }

        private void ybtn4_Click(object sender, EventArgs e)
        {
            String title = moviebox1.Text;
            String genre = moviebox2.Text;
            String director = moviebox3.Text;
            String actor = moviebox4.Text;

            try
            {
                conn.Open();    //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                String query = $"select count(*) from 영화";

                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; // 검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader(); // select 아이디 from 회원 결과

                read.Read();

                String num = (int.Parse(read.GetValue(0).ToString()) + 1).ToString();

                read.Close();

                if (image == null)
                    cmd.CommandText = $"insert into 영화 values ('{num}', '{title}', '{genre}', '{director}', '{actor}', NULL)";

                else
                {
                    cmd.CommandText = $"insert into 영화 values ('{num}', '{title}', '{genre}', '{director}', '{actor}', :image_var)";

                    byte[] bytes = imageToByteArray(image);
                    OleDbParameter para = new OleDbParameter();
                    para.OleDbType = OleDbType.LongVarBinary;
                    para.ParameterName = ":image_var";
                    para.Direction = ParameterDirection.Input;
                    para.SourceColumn = "poster";
                    para.Size = bytes.Length;
                    para.Value = bytes;
                    cmd.Parameters.Add(para);
                }

                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();  // 쿼리문을 실행하고 영향받는 행의 수를 반환
                cmd.Parameters.Clear();

                MessageBox.Show("영화 정보가 등록되었습니다.", "영화 정보 등록완료");
            }

            catch (System.Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // 에러 메세지
            }

            conn.Close();   // 데이터베이스 연결 해제
        }

        private void grid_Click(object sender, DataGridViewCellEventArgs e) // 그리드뷰의 셀을 클릭했을때
        {
            namebox1.Text = joingrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            namebox2.Text = gradegrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            gradebox1.Text = gradegrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            gradebox2.Text = dcgrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            dcbox.Value = int.Parse(dcgrid.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        public bool ThumbnailCallback()
        {
            return true;
        }

        private void imgbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string image_file = string.Empty;
                image_file = dialog.FileName;
                image = Bitmap.FromFile(image_file);
                Image.GetThumbnailImageAbort callback = new Image.GetThumbnailImageAbort(ThumbnailCallback);    // 썸네일 만들기
                thumnail_img = image.GetThumbnailImage(400, 400, callback, new IntPtr());   // 썸네일 만들기
                imgbox.Image = thumnail_img;
                imgbox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else return;
        }

        private void ybtn5_Click(object sender, EventArgs e)
        {
            String num = timebox1.Text;
            String date = datebox1.Text + " " + datebox2.Text;
            String cinema = timebox2.Text;
            cinema = cinema.Substring(0, cinema.Length - 1);

            try
            {
                conn.Open(); //데이터베이스 연결

                OleDbCommand cmd = new OleDbCommand();
                String query = $"insert into 상영스케줄 values ('{num}', '{date}', '{cinema}', '{timebox3.Text}')";

                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; // 검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();

                MessageBox.Show("상영스케줄이 등록되었습니다.", "상영스케줄 등록완료");
            }

            catch (System.Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // 에러 메세지
            }

            conn.Close(); // 데이터베이스 연결 해제
        }

        private void combo_Changed(object sender, EventArgs e)
        {
            switch (timebox2.Text)
            {
                case "1관":
                    timebox3.Text = "8000";
                    break;
                case "2관":
                    timebox3.Text = "12000";
                    break;
                case "3관":
                    timebox3.Text = "15000";
                    break;
                default:
                    break;
            }
        }

        private void Tab1_Click(object sender, EventArgs e)
        {
            Panel_init();
            Panel1.Visible = true;

            reset();
        }

        private void Tab2_Click(object sender, EventArgs e)
        {
            Panel_init();
            Panel2.Visible = true;
            
            reset();
        }

        private void Tab3_Click(object sender, EventArgs e)
        {
            Panel_init();
            Panel3.Visible = true;

            reset();
        }

        private byte[] imageToByteArray(Image img)
        {
            ImageConverter imageConverter = new ImageConverter();
            byte[] b = (byte[])imageConverter.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reset()
        {
            namebox1.Clear();
            namebox2.Clear();

            dcbox.Value = 0;

            moviebox1.Clear();
            moviebox2.Clear();
            moviebox3.Clear();
            moviebox4.Clear();

            imgbox.Image = null;

            timebox1.Clear();
            timebox2.SelectedIndex = 0;

            datebox1.Text = null;
            datebox2.Text = null;
        }

        private void Panel_init()
        {
            Panel1.Visible=false;
            Panel2.Visible=false;
            Panel3.Visible=false;
        }
    }
}
