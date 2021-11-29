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
    public partial class RegForm : Form
    {
        OleDbConnection conn;
        string connectionString = "Provider=OraOLEDB.Oracle;Password=1q2w3e;User ID=system";    // oracle 서버 연결

        public RegForm()
        {
            InitializeComponent();

            this.num1.SelectedIndex = 0;
            this.card1.SelectedIndex = 0;
            this.pwbox.Enabled = false;
            this.repwbox.Enabled = false;
            this.namebox.Enabled = false;
            this.num1.Enabled = false;
            this.num2.Enabled = false;
            this.num3.Enabled = false;
            this.card1.Enabled = false;
            this.card2.Enabled = false;
            this.card3.Enabled = false;
            this.card4.Enabled = false;
            this.card5.Enabled = false;
            this.ybtn.Enabled = false;
        }

        private void Checkbtn_Click(object sender, EventArgs e)
        {
            String id = this.idbox.Text;
            conn = new OleDbConnection(connectionString);
            try
            {
                if (id.Length < 4)
                {
                    MessageBox.Show("아이디는 4자 이상이어야 합니다.", "회원가입 불가");
                    return;
                }

                conn.Open(); // 데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                String query = $"select * from 회원 where 아이디 ='" + id + "'";

                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; // 검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader(); // select 아이디 from 회원 결과

                if (!read.Read())
                {
                    MessageBox.Show("사용 가능한 아이디입니다.", "중복 검사결과");
                    idbox.Enabled = false;
                    checkbtn.Enabled = false;
                    this.pwbox.Enabled = true;
                    this.repwbox.Enabled = true;
                    this.namebox.Enabled = true;
                    this.num1.Enabled = true;
                    this.num2.Enabled = true;
                    this.num3.Enabled = true;
                    this.card1.Enabled = true;
                    this.card2.Enabled = true;
                    this.card3.Enabled = true;
                    this.card4.Enabled = true;
                    this.card5.Enabled = true;
                    this.ybtn.Enabled = true;
                }

                else
                    MessageBox.Show("중복된 아이디입니다.", "중복 검사결과"); // 에러 메세지

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
            String name = this.namebox.Text;
            String num = this.num1.Text + "-" + this.num2.Text + "-" + this.num3.Text;
            String card = this.card1.Text + " " + this.card2.Text + " " + this.card3.Text + " " + this.card4.Text + " " + this.card5.Text;

            if (pw.Length < 4)
            {
                MessageBox.Show("비밀번호는 4자 이상이어야 합니다.", "회원가입 불가");
                return;
            }

            // SHA256 해시 생성
            SHA256 hash1 = new SHA256Managed();
            byte[] bytes1 = hash1.ComputeHash(Encoding.ASCII.GetBytes(pw));

            // 16진수 형태로 문자열 결합
            StringBuilder sb1 = new StringBuilder();
            foreach (byte b1 in bytes1)
                sb1.AppendFormat("{0:x2}", b1);

            // 입력값의 해시결과
            String hash_value = sb1.ToString();

            if (this.repwbox.Text != pw)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "회원가입 불가");
                return;
            }
            
            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();    // 데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                String query = $"insert into 회원 values ('{id}', '{hash_value}', '{name}', '{num}', 'SILVER', '{card}', 'N')";
                cmd.CommandText = query;

                cmd.CommandType = CommandType.Text; // 검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();
                MessageBox.Show("가입신청 완료되었습니다.", "가입신청 완료");

                Close();
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
