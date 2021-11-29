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
    public partial class PwForm : Form
    {
        OleDbConnection conn;
        string connectionString = "Provider=OraOLEDB.Oracle;Password=1q2w3e;User ID=system";    // oracle 서버 연결

        public PwForm()
        {
            InitializeComponent();

            this.num1.SelectedIndex = 0;
            this.pwbox.Enabled = false;
            this.repwbox.Enabled = false;
            this.ybtn.Enabled = false;
        }

        private void Checkbtn_Click(object sender, EventArgs e)
        {
            String id = this.idbox.Text;
            String name = this.namebox.Text;
            String num = this.num1.Text + "-" + this.num2.Text + "-" + this.num3.Text;

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open(); // 데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                String query = $"select * from 회원 where 아이디 ='" + id + "' and 회원이름 ='" + name + "' and 전화번호 ='" + num + "'";

                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; // 검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader();

                if (!read.Read())
                    MessageBox.Show("회원으로 등록되지 않은 정보입니다.", "비밀번호 찾기 결과");

                else
                {
                    this.Panel1.Enabled = false;
                    this.pwbox.Enabled = true;
                    this.repwbox.Enabled = true;
                    this.ybtn.Enabled = true;
                }

                read.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "오류 발생"); // 에러 메세지
            }

            conn.Close(); // 데이터베이스 연결 해제
        }

        private void Ybtn_Click(object sender, EventArgs e)
        {
            String id = this.idbox.Text;
            String pw = this.pwbox.Text;

            if (pw.Length < 4)
            {
                MessageBox.Show("비밀번호는 4자 이상이어야 합니다.", "비밀번호 변경불가");
                return;
            }

            if (pw != this.repwbox.Text)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "비밀번호 변경불가");
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

                OleDbDataReader read = cmd.ExecuteReader(); // select 아이디 from 회원 결과

                if (read.Read())
                {

                    if (hash_value == read.GetValue(1).ToString())
                    {
                        MessageBox.Show("기존 비밀번호와 같습니다.", "비밀번호 변경불가");
                        return;
                    }

                    else
                    {
                        read.Close();
                        String query = $"update 회원 set 비밀번호 ='" + hash_value + "' where 아이디 ='" + id + "'";

                        cmd.CommandText = query;
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = conn;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("비밀번호가 변경되었습니다.", "비밀번호 변경성공");

                        Close();
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

        private void Nbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
