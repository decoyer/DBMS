namespace dbtp
{
    partial class RegForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.idbox = new System.Windows.Forms.TextBox();
            this.pwbox = new System.Windows.Forms.TextBox();
            this.pw = new System.Windows.Forms.Label();
            this.repwbox = new System.Windows.Forms.TextBox();
            this.repw = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.Label();
            this.card = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.ComboBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.num3 = new System.Windows.Forms.TextBox();
            this.card1 = new System.Windows.Forms.ComboBox();
            this.card2 = new System.Windows.Forms.TextBox();
            this.card3 = new System.Windows.Forms.TextBox();
            this.card4 = new System.Windows.Forms.TextBox();
            this.card5 = new System.Windows.Forms.TextBox();
            this.ybtn = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.checkbtn = new System.Windows.Forms.Button();
            this.nbtn = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.Info;
            this.Title.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(340, 30);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(125, 37);
            this.Title.TabIndex = 11;
            this.Title.Text = "회원가입";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(58, 33);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(52, 15);
            this.id.TabIndex = 12;
            this.id.Text = "아이디";
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(116, 30);
            this.idbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(125, 25);
            this.idbox.TabIndex = 13;
            // 
            // pwbox
            // 
            this.pwbox.Location = new System.Drawing.Point(116, 80);
            this.pwbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pwbox.Name = "pwbox";
            this.pwbox.PasswordChar = '•';
            this.pwbox.Size = new System.Drawing.Size(178, 25);
            this.pwbox.TabIndex = 16;
            // 
            // pw
            // 
            this.pw.AutoSize = true;
            this.pw.Location = new System.Drawing.Point(43, 83);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(67, 15);
            this.pw.TabIndex = 15;
            this.pw.Text = "비밀번호";
            // 
            // repwbox
            // 
            this.repwbox.Location = new System.Drawing.Point(116, 130);
            this.repwbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.repwbox.Name = "repwbox";
            this.repwbox.PasswordChar = '•';
            this.repwbox.Size = new System.Drawing.Size(178, 25);
            this.repwbox.TabIndex = 18;
            // 
            // repw
            // 
            this.repw.AutoSize = true;
            this.repw.Location = new System.Drawing.Point(8, 133);
            this.repw.Name = "repw";
            this.repw.Size = new System.Drawing.Size(102, 15);
            this.repw.TabIndex = 17;
            this.repw.Text = "비밀번호 확인";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(73, 183);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(37, 15);
            this.name.TabIndex = 19;
            this.name.Text = "이름";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(116, 180);
            this.namebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(178, 25);
            this.namebox.TabIndex = 20;
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Location = new System.Drawing.Point(43, 233);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(67, 15);
            this.num.TabIndex = 21;
            this.num.Text = "전화번호";
            // 
            // card
            // 
            this.card.AutoSize = true;
            this.card.Location = new System.Drawing.Point(43, 283);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(67, 15);
            this.card.TabIndex = 26;
            this.card.Text = "카드번호";
            // 
            // num1
            // 
            this.num1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.num1.FormattingEnabled = true;
            this.num1.Items.AddRange(new object[] {
            "010",
            "011",
            "016",
            "017",
            "018",
            "019"});
            this.num1.Location = new System.Drawing.Point(116, 231);
            this.num1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(54, 23);
            this.num1.TabIndex = 23;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(175, 230);
            this.num2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num2.MaxLength = 4;
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(57, 25);
            this.num2.TabIndex = 25;
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(237, 230);
            this.num3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num3.MaxLength = 4;
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(57, 25);
            this.num3.TabIndex = 26;
            // 
            // card1
            // 
            this.card1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.card1.FormattingEnabled = true;
            this.card1.Items.AddRange(new object[] {
            "KB국민카드",
            "NH농협카드",
            "롯데카드",
            "삼성카드",
            "신한카드",
            "우리카드",
            "하나카드",
            "현대카드",
            "카카오뱅크"});
            this.card1.Location = new System.Drawing.Point(116, 280);
            this.card1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(100, 23);
            this.card1.TabIndex = 27;
            // 
            // card2
            // 
            this.card2.Location = new System.Drawing.Point(116, 315);
            this.card2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.card2.MaxLength = 4;
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(57, 25);
            this.card2.TabIndex = 28;
            // 
            // card3
            // 
            this.card3.Location = new System.Drawing.Point(179, 315);
            this.card3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.card3.MaxLength = 4;
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(57, 25);
            this.card3.TabIndex = 29;
            // 
            // card4
            // 
            this.card4.Location = new System.Drawing.Point(241, 315);
            this.card4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.card4.MaxLength = 4;
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(57, 25);
            this.card4.TabIndex = 30;
            // 
            // card5
            // 
            this.card5.Location = new System.Drawing.Point(303, 315);
            this.card5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.card5.MaxLength = 4;
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(57, 25);
            this.card5.TabIndex = 31;
            // 
            // ybtn
            // 
            this.ybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.ybtn.ForeColor = System.Drawing.Color.White;
            this.ybtn.Location = new System.Drawing.Point(225, 375);
            this.ybtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ybtn.Name = "ybtn";
            this.ybtn.Size = new System.Drawing.Size(125, 50);
            this.ybtn.TabIndex = 34;
            this.ybtn.Text = "확인";
            this.ybtn.UseVisualStyleBackColor = false;
            this.ybtn.Click += new System.EventHandler(this.Ybtn_Click);
            // 
            // Panel
            // 
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.Controls.Add(this.checkbtn);
            this.Panel.Controls.Add(this.nbtn);
            this.Panel.Controls.Add(this.namebox);
            this.Panel.Controls.Add(this.name);
            this.Panel.Controls.Add(this.ybtn);
            this.Panel.Controls.Add(this.card5);
            this.Panel.Controls.Add(this.card4);
            this.Panel.Controls.Add(this.card3);
            this.Panel.Controls.Add(this.card2);
            this.Panel.Controls.Add(this.card1);
            this.Panel.Controls.Add(this.num3);
            this.Panel.Controls.Add(this.num2);
            this.Panel.Controls.Add(this.num1);
            this.Panel.Controls.Add(this.card);
            this.Panel.Controls.Add(this.num);
            this.Panel.Controls.Add(this.repwbox);
            this.Panel.Controls.Add(this.repw);
            this.Panel.Controls.Add(this.pwbox);
            this.Panel.Controls.Add(this.pw);
            this.Panel.Controls.Add(this.id);
            this.Panel.Controls.Add(this.idbox);
            this.Panel.Location = new System.Drawing.Point(210, 90);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(380, 440);
            this.Panel.TabIndex = 32;
            // 
            // checkbtn
            // 
            this.checkbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkbtn.ForeColor = System.Drawing.Color.White;
            this.checkbtn.Location = new System.Drawing.Point(260, 28);
            this.checkbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkbtn.Name = "checkbtn";
            this.checkbtn.Size = new System.Drawing.Size(100, 30);
            this.checkbtn.TabIndex = 14;
            this.checkbtn.Text = "중복 검사";
            this.checkbtn.UseVisualStyleBackColor = false;
            this.checkbtn.Click += new System.EventHandler(this.Checkbtn_Click);
            // 
            // nbtn
            // 
            this.nbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.nbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.nbtn.ForeColor = System.Drawing.Color.White;
            this.nbtn.Location = new System.Drawing.Point(50, 375);
            this.nbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nbtn.Name = "nbtn";
            this.nbtn.Size = new System.Drawing.Size(125, 50);
            this.nbtn.TabIndex = 33;
            this.nbtn.Text = "취소";
            this.nbtn.UseVisualStyleBackColor = false;
            this.nbtn.Click += new System.EventHandler(this.Nbtn_Click);
            // 
            // RegForm
            // 
            this.AcceptButton = this.ybtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.CancelButton = this.nbtn;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegForm";
            this.Text = "Register";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.TextBox pwbox;
        private System.Windows.Forms.Label pw;
        private System.Windows.Forms.Label repw;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Label card;
        private System.Windows.Forms.ComboBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox num3;
        private System.Windows.Forms.ComboBox card1;
        private System.Windows.Forms.TextBox card2;
        private System.Windows.Forms.TextBox card3;
        private System.Windows.Forms.TextBox card4;
        private System.Windows.Forms.TextBox card5;
        private System.Windows.Forms.Button ybtn;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button nbtn;
        private System.Windows.Forms.Button checkbtn;
        private System.Windows.Forms.TextBox repwbox;
    }
}