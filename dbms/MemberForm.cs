using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbtp
{
    public partial class MemberForm : Form
    {
        OleDbConnection conn;
        string connectionString = "Provider=OraOLEDB.Oracle;Password=1q2w3e;User ID=system";    // oracle 서버 연결

        OleDbDataAdapter adapter;
        DataSet ds;

        Image image = null;
        Image thumnail_img = null;

        public MemberForm()
        {
            InitializeComponent();

            init();
        }

        private void Loginbtn1_Click(object sender, EventArgs e)
        {
            String id = idbox1.Text;
            String pw = pwbox1.Text;

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open(); // 데이터베이스 연결

                OleDbCommand cmd = new OleDbCommand();
                String query = "select * from 회원 where 아이디 ='" + id + "'";

                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; // 검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader();

                if (!read.Read())
                    MessageBox.Show("회원으로 등록되지 않은 정보입니다.", "로그인 불가");

                else
                {
                    // SHA256 해시 생성
                    SHA256 hash1 = new SHA256Managed();
                    byte[] bytes1 = hash1.ComputeHash(Encoding.ASCII.GetBytes(pw));

                    // 16진수 형태로 문자열 결합
                    StringBuilder sb1 = new StringBuilder();
                    foreach (byte b1 in bytes1)
                        sb1.AppendFormat("{0:x2}", b1);

                    // 입력값의 해시결과
                    String hash_value = sb1.ToString();

                    if (read.GetValue(1).ToString() != hash_value)
                        MessageBox.Show("비밀번호가 일치하지 않습니다.", "로그인 불가");

                    else
                    {
                        init();
                        Panel2.Visible = true;

                        idbox2.Text = read.GetValue(0).ToString();
                        namebox.Text = read.GetValue(2).ToString();
                        numbox.Text = read.GetValue(3).ToString();
                        cardbox.Text = read.GetValue(5).ToString();
                    }
                }

                read.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지
            }

            conn.Close(); // 데이터베이스 연결 해제
        }

        private void Pwbtn_Click(object sender, EventArgs e)
        {
            pwbox2.Enabled = true;
            repwbox.Enabled = true;
            pwbtn.Enabled = false;
        }

        private void ybtn1_Click(object sender, EventArgs e)
        {
            String name = namebox.Text;
            String num = numbox.Text;
            String card = cardbox.Text;
            String id = idbox2.Text;
            String pw = pwbox2.Text;

            if (pwbtn.Enabled == true)
            {
                conn = new OleDbConnection(connectionString);
                try
                {
                    conn.Open(); //데이터베이스 연결

                    OleDbCommand cmd = new OleDbCommand();
                    String query = $"update 회원 set 회원이름='{name}', 전화번호='{num}', 카드번호='{card}' where 아이디 ='" + id + "'";

                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("회원 정보가 변경되었습니다.", "회원정보 변경성공");

                    conn.Close(); // 데이터베이스 연결 해제
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "오류 발생"); // 에러 메세지
                }
            }

            else
            {
                if (pw.Length < 4)
                {
                    MessageBox.Show("비밀번호는 4자 이상이어야 합니다.", "회원정보 변경불가");
                    return;
                }

                if (pw != this.repwbox.Text)
                {
                    MessageBox.Show("비밀번호가 일치하지 않습니다.", "회원정보 변경불가");
                    return;
                }

                conn = new OleDbConnection(connectionString);
                try
                {
                    // SHA256 해시 생성
                    SHA256 hash1 = new SHA256Managed();
                    byte[] bytes1 = hash1.ComputeHash(Encoding.ASCII.GetBytes(pw));

                    // 16진수 형태로 문자열 결합
                    StringBuilder sb1 = new StringBuilder();
                    foreach (byte b1 in bytes1)
                        sb1.AppendFormat("{0:x2}", b1);

                    // 입력값의 해시결과
                    String hash_value = sb1.ToString();

                    conn.Open(); //데이터베이스 연결

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "select * from 회원 where 아이디 ='" + id + "'";
                    cmd.CommandType = CommandType.Text; // 검색명령을 쿼리 형태로
                    cmd.Connection = conn;

                    OleDbDataReader read = cmd.ExecuteReader();

                    if (read.Read())
                    {

                        if (hash_value == read.GetValue(1).ToString())
                        {
                            MessageBox.Show("기존 비밀번호와 같습니다.", "회원정보 변경불가");
                            return;
                        }

                        else
                        {
                            read.Close();
                            String query = $"update 회원 set 비밀번호='{hash_value}', 회원이름='{name}', 전화번호='{num}', 카드번호='{card}' where 아이디 ='" + id + "'";

                            cmd.CommandText = query;
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = conn;

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("회원 정보가 변경되었습니다.", "회원정보 변경성공");
                        }

                        read.Close();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "오류 발생"); // 에러 메세지
                }

                conn.Close(); // 데이터베이스 연결 해제
            }
        }

        private void quitbtn_Click(object sender, EventArgs e)
        {
            String id = idbox2.Text;

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open(); //데이터베이스 연결

                OleDbCommand cmd = new OleDbCommand();
                String query = $"delete from 회원 where 아이디 ='" + id + "'";

                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();

                MessageBox.Show("회원 탈퇴 완료되었습니다.", "회원탈퇴 성공");

                Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "오류 발생"); // 에러 메세지
            }

            conn.Close(); // 데이터베이스 연결 해제
        }

        private void Tab1_Click(object sender, EventArgs e)
        {
            init();
            Panel1.Visible = true;
        }

        private void Tab2_Click(object sender, EventArgs e)
        {
            init();

            ready();
            Panel3.Visible = true;
        }

        private void Tab3_Click(object sender, EventArgs e)
        {
            init();
            Panel8.Visible = true;
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ready()
        {
            conn = new OleDbConnection(connectionString);

            try
            {
                for (int i = 1; i <= 11; i++)
                {
                    conn.Open(); // 데이터베이스 연결
                    OleDbCommand cmd = new OleDbCommand();
                    String query = $"select * from 영화 where 영화번호 ='" + i + "'";

                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text; // 검색명령을 쿼리 형태로
                    cmd.Connection = conn;

                    OleDbDataReader read = cmd.ExecuteReader(); // select 영화 결과

                    if (read.Read())
                    {
                        if (read.GetValue(5).ToString() != "")  //이미지가 없으면
                        {
                            image = ByteArrayToImage((byte[])read.GetValue(5));
                            Image.GetThumbnailImageAbort callback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                            thumnail_img = image.GetThumbnailImage(400, 400, callback, new IntPtr());   //썸네일 만들기

                            switch (i)
                            {
                                case 1:
                                    imgbox01.Image = thumnail_img;
                                    imgbox01.SizeMode = PictureBoxSizeMode.StretchImage;
                                    break;
                                case 2:
                                    imgbox2.Image = thumnail_img;
                                    imgbox2.SizeMode = PictureBoxSizeMode.StretchImage;
                                    break;
                                case 3:
                                    imgbox3.Image = thumnail_img;
                                    imgbox3.SizeMode = PictureBoxSizeMode.StretchImage;
                                    break;
                                case 4:
                                    imgbox4.Image = thumnail_img;
                                    imgbox4.SizeMode = PictureBoxSizeMode.StretchImage;
                                    break;
                                case 5:
                                    imgbox5.Image = thumnail_img;
                                    imgbox5.SizeMode = PictureBoxSizeMode.StretchImage;
                                    break;
                                case 6:
                                    imgbox6.Image = thumnail_img;
                                    imgbox6.SizeMode = PictureBoxSizeMode.StretchImage;
                                    break;
                                case 7:
                                    imgbox7.Image = thumnail_img;
                                    imgbox7.SizeMode = PictureBoxSizeMode.StretchImage;
                                    break;
                                case 8:
                                    imgbox8.Image = thumnail_img;
                                    imgbox8.SizeMode = PictureBoxSizeMode.StretchImage;
                                    break;
                                case 9:
                                    imgbox9.Image = thumnail_img;
                                    imgbox9.SizeMode = PictureBoxSizeMode.StretchImage;
                                    break;
                                case 10:
                                    imgbox10.Image = thumnail_img;
                                    imgbox10.SizeMode = PictureBoxSizeMode.StretchImage;
                                    break;
                                default:
                                    imgbox11.Image = thumnail_img;
                                    imgbox11.SizeMode = PictureBoxSizeMode.StretchImage;
                                    break;
                            }
                        }

                        read.Close();
                        conn.Close(); // 데이터베이스 연결 해제
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "오류 발생"); // 에러 메세지
            }

            conn.Close(); // 데이터베이스 연결 해제
        }

        private void imgbox_Click(object sender, EventArgs e)
        {
            String status = ((PictureBox)sender).Name.ToString();

            if (status == "imgbox10" || status == "imgbox11")
            {
                if (status == "imgbox10")
                    status = "10";

                if (status == "imgbox11")
                    status = "11";
            }

            else
                status = status.Substring(status.Length - 1, 1);

            statusbox.Text = status;

            conn = new OleDbConnection(connectionString);

            try
            {
                conn.Open(); // 데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                String query = $"select * from 영화 where 영화번호 ='" + status + "'";

                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; // 검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader(); // select 영화 결과

                if (read.Read())
                {
                    infobox1.Text = read.GetValue(1).ToString();
                    infobox2.Text = read.GetValue(2).ToString();
                    infobox3.Text = read.GetValue(3).ToString();
                    infobox4.Text = read.GetValue(4).ToString();

                    if (read.GetValue(5).ToString() != "")  //이미지가 없으면
                    {
                        image = ByteArrayToImage((byte[])read.GetValue(5));
                        Image.GetThumbnailImageAbort callback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                        thumnail_img = image.GetThumbnailImage(400, 400, callback, new IntPtr());   //썸네일 만들기
                        imgbox9.Image = thumnail_img;
                        imgbox9.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                    read.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "오류 발생"); // 에러 메세지
            }

            conn.Close(); // 데이터베이스 연결 해제

            init();
            Panel4.Visible = true;
        }

        private void backbtn1_Click(object sender, EventArgs e)
        {
            init();
            Panel3.Visible = true;
        }

        private void frontbtn1_Click(object sender, EventArgs e)
        {
            grid_ready();
        }

        private void Loginbtn2_Click(object sender, EventArgs e)
        {
            String id = idbox3.Text;
            String pw = pwbox3.Text;

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open(); // 데이터베이스 연결

                OleDbCommand cmd = new OleDbCommand();
                String query = "select * from 회원 where 아이디 ='" + id + "'";

                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; // 검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader();

                if (!read.Read())
                    MessageBox.Show("회원으로 등록되지 않은 정보입니다.", "로그인 불가");

                else
                {
                    // SHA256 해시 생성
                    SHA256 hash1 = new SHA256Managed();
                    byte[] bytes1 = hash1.ComputeHash(Encoding.ASCII.GetBytes(pw));

                    // 16진수 형태로 문자열 결합
                    StringBuilder sb1 = new StringBuilder();
                    foreach (byte b1 in bytes1)
                        sb1.AppendFormat("{0:x2}", b1);

                    // 입력값의 해시결과
                    String hash_value = sb1.ToString();

                    if (read.GetValue(1).ToString() != hash_value)
                        MessageBox.Show("비밀번호가 일치하지 않습니다.", "로그인 불가");

                    else
                    {
                        init();

                        Panel6.Visible = true;
                    }
                }

                read.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지
            }

            conn.Close(); // 데이터베이스 연결 해제
        }

        private void grid_ready()
        {
            String status = statusbox.Text;

            ds = new DataSet("상영스케줄");

            conn = new OleDbConnection(connectionString);
            conn.Open();

            adapter = new OleDbDataAdapter("select 상영시간, 상영관번호, 요금 from 상영스케줄 where 영화번호 ='" + status + "' order by 상영시간", conn);
            adapter.Fill(ds);

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("상영 예정작입니다.", "영화예약 불가");

                Panel4.Visible = true;
            }

            else
            {
                timegrid.DataSource = ds.Tables[0];

                init();
                Panel5.Visible = true;
            }

            conn.Close(); // 데이터베이스 연결 해제
        }

        private void backbtn2_Click(object sender, EventArgs e)
        {
            init();
            Panel4.Visible = true;
        }

        private void frontbtn2_Click(object sender, EventArgs e)
        {
            headbox.Text = head.Value.ToString();

            init();

            switch (theaterbox.Text)
            {
                case "1":
                    theater1.Visible = true;
                    break;
                case "2":
                    theater2.Visible = true;
                    break;
                case "3":
                    theater3.Visible = true;
                    break;
                default:
                    Panel6.Visible = true;
                    MessageBox.Show("예약 시간을 선택해야 합니다.", "영화예약 불가");
                    break;
            }
        }

        private void nbtn_Click(object sender, EventArgs e)
        {
            init();
            Panel6.Visible = true;
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            init();

            pay_ready();
            Panel7.Visible = true;
        }

        private void pay_ready()
        {
            String time = timebox.Text;
            String date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            int head = int.Parse(headbox.Text);
            int price = int.Parse(pricebox.Text);

            paybox1.Text = theaterbox.Text + "-" + time + "-" + statusbox.Text;
            paybox2.Text = date;
            paybox4.Text = (head * price).ToString();
        }

        private void backbtn3_Click(object sender, EventArgs e)
        {
            init();

            switch (theaterbox.Text)
            {
                case "1":
                    theater1.Visible = true;
                    break;
                case "2":
                    theater2.Visible = true;
                    break;
                case "3":
                    theater3.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void frontbtn3_Click(object sender, EventArgs e)
        {
            String id = idbox3.Text;
            String num = paybox1.Text;
            String date = paybox2.Text;
            String seat = paybox3.Text;
            String price = paybox4.Text;

            if (paybox3.Text == "")
                MessageBox.Show("좌석을 선택해야 합니다.", "영화예약 불가");

            else
            {
                conn = new OleDbConnection(connectionString);
                try
                {
                    conn.Open();    // 데이터베이스 연결
                    OleDbCommand cmd = new OleDbCommand();

                    String query = $"select * from 회원 where 아이디='" + id + "'";

                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text; // 검색명령을 쿼리 형태로
                    cmd.Connection = conn;

                    OleDbDataReader read = cmd.ExecuteReader(); // select 아이디 from 회원 결과

                    read.Read();

                    String grade = read.GetValue(4).ToString();

                    read.Close();

                    switch (grade)
                    {
                        case "SILVER":
                            price = (int.Parse(price) * 0.9).ToString();
                            break;
                        case "GOLD":
                            price = (int.Parse(price) * 0.7).ToString();
                            break;
                        case "VIP":
                            price = (int.Parse(price) * 0.5).ToString();
                            break;
                        default:
                            break;
                    }

                    cmd.CommandText = $"insert into 예매좌석 values ('{statusbox.Text}', '{timebox.Text}', '{theaterbox.Text}', '{seat}', '{id}', '{date}', '{price}', '{num}')";

                    cmd.CommandType = CommandType.Text; // 검색명령을 쿼리 형태로
                    cmd.Connection = conn;

                    cmd.ExecuteNonQuery();
                    
                    if (cash1.Checked)
                    {
                        MessageBox.Show("예약 완료되었습니다. \n(결제 방법: 현금, 결제 금액: "+ price + "원)", "영화예약 성공");

                        init();
                        Panel3.Visible = true;
                    }

                    else if (cash2.Checked)
                    {
                        MessageBox.Show("예약 완료되었습니다. \n(결제 방법: 카드, 결제 금액: " + price + "원)", "영화예약 성공");

                        init();
                        Panel3.Visible = true;
                    }

                    else
                        MessageBox.Show("결제 방법을 선택해야 합니다.", "영화예약 실패");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "오류 발생"); // 에러 메세지
                }

                conn.Close(); // 데이터베이스 연결 해제
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            String num = rsvbox1.Text;

            if (rsvbox1.Text == "")
                MessageBox.Show("예약 번호를 입력해야 합니다.", "예약 정보 조회불가");

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();    // 데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();

                String query = $"select * from 예매좌석 where 예약번호='" + num + "'";

                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; // 검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader(); // select 예매좌석 결과

                if (!read.Read())
                    MessageBox.Show("등록되지 않은 정보입니다.", "예약 정보 조회불가");

                else
                {
                    rsvbox2.Text = read.GetValue(5).ToString();
                    rsvbox3.Text = read.GetValue(3).ToString();
                    rsvbox4.Text = read.GetValue(6).ToString();

                    rsvbox3.Enabled = true;
                    cancelbtn.Enabled = true;
                    modifybtn.Enabled = true;
                }

                read.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "오류 발생"); // 에러 메세지
            }

            conn.Close(); // 데이터베이스 연결 해제
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            String num = rsvbox1.Text;

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open(); //데이터베이스 연결

                OleDbCommand cmd = new OleDbCommand();
                String query = $"delete 예매좌석 where 예약번호 ='" + num + "'";

                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();

                MessageBox.Show("예약이 취소되었습니다.", "예약취소 성공");

                clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "오류 발생"); // 에러 메세지
            }

            conn.Close(); // 데이터베이스 연결 해제
        }

        private void modifybtn_Click(object sender, EventArgs e)
        {
            String num = rsvbox1.Text;
            String date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            String seat = rsvbox3.Text;

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open(); //데이터베이스 연결

                OleDbCommand cmd = new OleDbCommand();
                String query = $"update 예매좌석 set 좌석번호='{seat}', 예매일시='{date}' where 예약번호='" + num + "'";

                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();

                MessageBox.Show("예약이 변경되었습니다.", "예약변경 성공");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "오류 발생"); // 에러 메세지
            }

            conn.Close(); // 데이터베이스 연결 해제
        }

        private void clear()
        {
            idbox1.Clear();
            pwbox1.Clear();

            pwbox2.Clear();
            repwbox.Clear();
            pwbox2.Enabled = false;
            repwbox.Enabled = false;
            pwbtn.Enabled = true;

            namebox.Clear();
            numbox.Clear();
            cardbox.Clear();

            paybox3.Clear();

            rsvbox1.Clear();
            rsvbox2.Clear();
            rsvbox3.Clear();
            rsvbox4.Clear();

            rsvbox3.Enabled = false;

            cancelbtn.Enabled = false;
            modifybtn.Enabled = false;

            head.Value = 1;
        }

        public void Panel_init()
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Panel6.Visible = false;
            Panel7.Visible = false;
            Panel8.Visible = false;
            Panel8.Visible = false;

            theater1.Visible = false;
            theater2.Visible = false;
            theater3.Visible = false;
        }

        public void init()
        {
            clear();
            Panel_init();
        }

        public bool ThumbnailCallback()
        {
            return true;
        }

        private Image ByteArrayToImage(byte[] bytes)
        {
            ImageConverter imageConverter = new ImageConverter();
            Image img = (Image)imageConverter.ConvertFrom(bytes);
            return img;
        }

        private void grid_Click(object sender, DataGridViewCellEventArgs e) // 그리드뷰의 셀을 클릭했을때
        {
            timebox.Text = timegrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            theaterbox.Text = timegrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            pricebox.Text = timegrid.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
