using System;
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
    public partial class LoginForm : Form
    {
        OleDbConnection conn;
        string connectionString = "Provider=OraOLEDB.Oracle;Password=1q2w3e;User ID=system";    // oracle 서버 연결

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            String id = idbox.Text;

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open(); // 데이터베이스 연결

                OleDbCommand cmd = new OleDbCommand();
                String query = "select * from 회원 where 아이디 ='" + id + "'";

                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; // 검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader(); // select 아이디 from 회원 결과

                if (!read.Read())
                    notice.Text = "존재하지 않는 아이디입니다.";

                else
                {
                    string pw = pwbox.Text;

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
                        notice.Text = "비밀번호가 일치하지 않습니다.";

                    else
                    {
                        notice.Text = read.GetValue(2).ToString() + "님 환영합니다.";

                        if (read.GetValue(0).ToString() == "admin")
                        {
                            AdminForm f = new AdminForm();
                            f.ShowDialog();
                        }

                        else
                        {
                            if (read.GetValue(6).ToString() == "N")
                                notice.Text = "회원가입이 승인되지 않았습니다.";
                            else
                            {
                                MemberForm f = new MemberForm();
                                f.ShowDialog();
                            }
                        }
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

        private void Regbtn_Click(object sender, EventArgs e)
        {
            RegForm f = new RegForm();
            f.ShowDialog();
        }

        private void Idbtn_Click(object sender, EventArgs e)
        {
            IdForm f = new IdForm();
            f.ShowDialog();
        }

        private void Pwbtn_Click(object sender, EventArgs e)
        {
            PwForm f = new PwForm();
            f.ShowDialog();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
