namespace dbtp
{
    partial class IdForm
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
            this.namebox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.ComboBox();
            this.num = new System.Windows.Forms.Label();
            this.ybtn = new System.Windows.Forms.Button();
            this.nbtn = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.Info;
            this.Title.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(325, 50);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(161, 37);
            this.Title.TabIndex = 12;
            this.Title.Text = "아이디 찾기";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(120, 70);
            this.namebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(178, 25);
            this.namebox.TabIndex = 22;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(77, 73);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(37, 15);
            this.name.TabIndex = 21;
            this.name.Text = "이름";
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(241, 145);
            this.num3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num3.MaxLength = 4;
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(57, 25);
            this.num3.TabIndex = 30;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(179, 145);
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
            this.num1.Location = new System.Drawing.Point(120, 146);
            this.num1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(54, 23);
            this.num1.TabIndex = 28;
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Location = new System.Drawing.Point(47, 149);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(67, 15);
            this.num.TabIndex = 27;
            this.num.Text = "전화번호";
            // 
            // ybtn
            // 
            this.ybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.ybtn.ForeColor = System.Drawing.Color.White;
            this.ybtn.Location = new System.Drawing.Point(225, 225);
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
            this.nbtn.Location = new System.Drawing.Point(50, 225);
            this.nbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nbtn.Name = "nbtn";
            this.nbtn.Size = new System.Drawing.Size(125, 50);
            this.nbtn.TabIndex = 33;
            this.nbtn.Text = "취소";
            this.nbtn.UseVisualStyleBackColor = false;
            this.nbtn.Click += new System.EventHandler(this.Nbtn_Click);
            // 
            // Panel
            // 
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.Controls.Add(this.num3);
            this.Panel.Controls.Add(this.ybtn);
            this.Panel.Controls.Add(this.nbtn);
            this.Panel.Controls.Add(this.num2);
            this.Panel.Controls.Add(this.num1);
            this.Panel.Controls.Add(this.num);
            this.Panel.Controls.Add(this.namebox);
            this.Panel.Controls.Add(this.name);
            this.Panel.Location = new System.Drawing.Point(200, 140);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(400, 300);
            this.Panel.TabIndex = 35;
            // 
            // IdForm
            // 
            this.AcceptButton = this.ybtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.CancelButton = this.nbtn;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Title);
            this.Name = "IdForm";
            this.Text = "Forgot ID?";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox num3;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.ComboBox num1;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Button ybtn;
        private System.Windows.Forms.Button nbtn;
        private System.Windows.Forms.Panel Panel;
    }
}