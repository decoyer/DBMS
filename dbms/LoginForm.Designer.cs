namespace dbtp
{
    partial class LoginForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.idbox = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.pw = new System.Windows.Forms.Label();
            this.pwbox = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.idbtn = new System.Windows.Forms.Button();
            this.pwbtn = new System.Windows.Forms.Button();
            this.regbtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.notice = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(107, 48);
            this.idbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(178, 25);
            this.idbox.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(54, 50);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(52, 15);
            this.id.TabIndex = 1;
            this.id.Text = "아이디";
            // 
            // pw
            // 
            this.pw.AutoSize = true;
            this.pw.Location = new System.Drawing.Point(40, 102);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(67, 15);
            this.pw.TabIndex = 2;
            this.pw.Text = "비밀번호";
            // 
            // pwbox
            // 
            this.pwbox.Location = new System.Drawing.Point(107, 98);
            this.pwbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pwbox.Name = "pwbox";
            this.pwbox.PasswordChar = '•';
            this.pwbox.Size = new System.Drawing.Size(178, 25);
            this.pwbox.TabIndex = 3;
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.Location = new System.Drawing.Point(40, 150);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(250, 40);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "로그인";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // idbtn
            // 
            this.idbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.idbtn.ForeColor = System.Drawing.Color.White;
            this.idbtn.Location = new System.Drawing.Point(209, 401);
            this.idbtn.Name = "idbtn";
            this.idbtn.Size = new System.Drawing.Size(120, 40);
            this.idbtn.TabIndex = 7;
            this.idbtn.Text = "아이디 찾기";
            this.idbtn.UseVisualStyleBackColor = false;
            this.idbtn.Click += new System.EventHandler(this.Idbtn_Click);
            // 
            // pwbtn
            // 
            this.pwbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pwbtn.ForeColor = System.Drawing.Color.White;
            this.pwbtn.Location = new System.Drawing.Point(335, 401);
            this.pwbtn.Name = "pwbtn";
            this.pwbtn.Size = new System.Drawing.Size(120, 40);
            this.pwbtn.TabIndex = 8;
            this.pwbtn.Text = "비밀번호 찾기";
            this.pwbtn.UseVisualStyleBackColor = false;
            this.pwbtn.Click += new System.EventHandler(this.Pwbtn_Click);
            // 
            // regbtn
            // 
            this.regbtn.BackColor = System.Drawing.Color.Orange;
            this.regbtn.ForeColor = System.Drawing.Color.White;
            this.regbtn.Location = new System.Drawing.Point(461, 401);
            this.regbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(120, 40);
            this.regbtn.TabIndex = 9;
            this.regbtn.Text = "회원가입";
            this.regbtn.UseVisualStyleBackColor = false;
            this.regbtn.Click += new System.EventHandler(this.Regbtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.Info;
            this.Title.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(240, 60);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(331, 54);
            this.Title.TabIndex = 10;
            this.Title.Text = "영화 예약 시스템";
            // 
            // Panel
            // 
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.Controls.Add(this.notice);
            this.Panel.Controls.Add(this.loginbtn);
            this.Panel.Controls.Add(this.pwbox);
            this.Panel.Controls.Add(this.pw);
            this.Panel.Controls.Add(this.id);
            this.Panel.Controls.Add(this.idbox);
            this.Panel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Panel.Location = new System.Drawing.Point(230, 175);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(325, 200);
            this.Panel.TabIndex = 0;
            // 
            // notice
            // 
            this.notice.AutoSize = true;
            this.notice.Font = new System.Drawing.Font("굴림", 8F);
            this.notice.Location = new System.Drawing.Point(15, 15);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(0, 14);
            this.notice.TabIndex = 5;
            this.notice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.exitbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitbtn.Location = new System.Drawing.Point(0, 0);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(0, 0);
            this.exitbtn.TabIndex = 99;
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.CancelButton = this.exitbtn;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.regbtn);
            this.Controls.Add(this.pwbtn);
            this.Controls.Add(this.idbtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label pw;
        private System.Windows.Forms.TextBox pwbox;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button idbtn;
        private System.Windows.Forms.Button pwbtn;
        private System.Windows.Forms.Button regbtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label notice;
        private System.Windows.Forms.Button exitbtn;
    }
}

