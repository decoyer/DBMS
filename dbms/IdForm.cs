using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbtp
{
    public partial class IdForm : Form
    {
        OleDbConnection conn;
        string connectionString = "Provider=OraOLEDB.Oracle;Password=1q2w3e;User ID=system";    // oracle 서버 연결

        public IdForm()
        {
            InitializeComponent();

            this.num1.SelectedIndex = 0;
        }

        private void Ybtn_Click(object sender, EventArgs e)
        {
            String name = this.namebox.Text;
            String num = this.num1.Text + "-" + this.num2.Text +"-" + this.num3.Text;
            conn = new OleDbConnection(connectionString);

            try
            {
                conn.Open(); // 데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                String query = $"select * from 회원 where 회원이름 ='" + name + "' and 전화번호 ='" + num + "'";

                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text; // 검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader(); // select 회원이름 from 회원 결과

                if (!read.Read())
                    MessageBox.Show("회원으로 등록되지 않은 정보입니다.", "아이디 찾기 결과");

                else
                {
                    MessageBox.Show(name + "의 아이디는 " + read.GetValue(0) + "입니다.", "아이디 찾기 결과");
                    Close();
                }

                read.Close();
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
