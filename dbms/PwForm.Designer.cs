namespace dbtp
{
    partial class PwForm
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.checkbtn = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.TextBox();
            this.idbox = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.ComboBox();
            this.num = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.ybtn = new System.Windows.Forms.Button();
            this.nbtn = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.repwbox = new System.Windows.Forms.TextBox();
            this.repw = new System.Windows.Forms.Label();
            this.pwbox = new System.Windows.Forms.TextBox();
            this.pw = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.Info;
            this.Title.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(300, 30);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(188, 37);
            this.Title.TabIndex = 13;
            this.Title.Text = "비밀번호 찾기";
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.checkbtn);
            this.Panel1.Controls.Add(this.id);
            this.Panel1.Controls.Add(this.num3);
            this.Panel1.Controls.Add(this.idbox);
            this.Panel1.Controls.Add(this.num2);
            this.Panel1.Controls.Add(this.num1);
            this.Panel1.Controls.Add(this.num);
            this.Panel1.Controls.Add(this.namebox);
            this.Panel1.Controls.Add(this.name);
            this.Panel1.Location = new System.Drawing.Point(190, 100);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(400, 225);
            this.Panel1.TabIndex = 36;
            // 
            // checkbtn
            // 
            this.checkbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.checkbtn.ForeColor = System.Drawing.Color.White;
            this.checkbtn.Location = new System.Drawing.Point(140, 160);
            this.checkbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkbtn.Name = "checkbtn";
            this.checkbtn.Size = new System.Drawing.Size(125, 50);
            this.checkbtn.TabIndex = 31;
            this.checkbtn.Text = "비밀번호 재설정";
            this.checkbtn.UseVisualStyleBackColor = false;
            this.checkbtn.Click += new System.EventHandler(this.Checkbtn_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(62, 20);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(52, 15);
            this.id.TabIndex = 14;
            this.id.Text = "아이디";
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(241, 116);
            this.num3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num3.MaxLength = 4;
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(57, 25);
            this.num3.TabIndex = 30;
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(120, 17);
            this.idbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(178, 25);
            this.idbox.TabIndex = 15;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(179, 116);
            this.num2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num2.MaxLength = 4;
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(57, 25);
            this.num2.TabIndex = 29;
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
            this.num1.Location = new System.Drawing.Point(120, 117);
            this.num1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(54, 23);
            this.num1.TabIndex = 28;
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Location = new System.Drawing.Point(47, 119);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(67, 15);
            this.num.TabIndex = 27;
            this.num.Text = "전화번호";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(120, 67);
            this.namebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(178, 25);
            this.namebox.TabIndex = 22;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(77, 70);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(37, 15);
            this.name.TabIndex = 21;
            this.name.Text = "이름";
            // 
            // ybtn
            // 
            this.ybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.ybtn.ForeColor = System.Drawing.Color.White;
            this.ybtn.Location = new System.Drawing.Point(225, 134);
            this.ybtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ybtn.Name = "ybtn";
            this.ybtn.Size = new System.Drawing.Size(125, 50);
            this.ybtn.TabIndex = 34;
            this.ybtn.Text = "확인";
            this.ybtn.UseVisualStyleBackColor = false;
            this.ybtn.Click += new System.EventHandler(this.Ybtn_Click);
            // 
            // nbtn
            // 
            this.nbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.nbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.nbtn.ForeColor = System.Drawing.Color.White;
            this.nbtn.Location = new System.Drawing.Point(50, 134);
            this.nbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nbtn.Name = "nbtn";
            this.nbtn.Size = new System.Drawing.Size(125, 50);
            this.nbtn.TabIndex = 33;
            this.nbtn.Text = "취소";
            this.nbtn.UseVisualStyleBackColor = false;
            this.nbtn.Click += new System.EventHandler(this.Nbtn_Click);
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.repwbox);
            this.Panel2.Controls.Add(this.repw);
            this.Panel2.Controls.Add(this.pwbox);
            this.Panel2.Controls.Add(this.pw);
            this.Panel2.Controls.Add(this.nbtn);
            this.Panel2.Controls.Add(this.ybtn);
            this.Panel2.Location = new System.Drawing.Point(190, 331);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(400, 190);
            this.Panel2.TabIndex = 37;
            // 
            // repwbox
            // 
            this.repwbox.Location = new System.Drawing.Point(120, 80);
            this.repwbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.repwbox.Name = "repwbox";
            this.repwbox.PasswordChar = '•';
            this.repwbox.Size = new System.Drawing.Size(178, 25);
            this.repwbox.TabIndex = 39;
            // 
            // repw
            // 
            this.repw.AutoSize = true;
            this.repw.Location = new System.Drawing.Point(12, 83);
            this.repw.Name = "repw";
            this.repw.Size = new System.Drawing.Size(102, 15);
            this.repw.TabIndex = 38;
            this.repw.Text = "비밀번호 확인";
            // 
            // pwbox
            // 
            this.pwbox.Location = new System.Drawing.Point(120, 30);
            this.pwbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pwbox.Name = "pwbox";
            this.pwbox.PasswordChar = '•';
            this.pwbox.Size = new System.Drawing.Size(178, 25);
            this.pwbox.TabIndex = 36;
            // 
            // pw
            // 
            this.pw.AutoSize = true;
            this.pw.Location = new System.Drawing.Point(27, 33);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(87, 15);
            this.pw.TabIndex = 35;
            this.pw.Text = "새 비밀번호";
            // 
            // PwForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.CancelButton = this.nbtn;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Title);
            this.Name = "PwForm";
            this.Text = "Forgot Password?";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox num3;
        private System.Windows.Forms.Button ybtn;
        private System.Windows.Forms.Button nbtn;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.ComboBox num1;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Button checkbtn;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.TextBox pwbox;
        private System.Windows.Forms.Label pw;
        private System.Windows.Forms.TextBox repwbox;
        private System.Windows.Forms.Label repw;
    }
}