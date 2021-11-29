namespace dbtp
{
    partial class AdminForm
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
            this.Tab1 = new System.Windows.Forms.Button();
            this.Tab2 = new System.Windows.Forms.Button();
            this.Tab3 = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nbtn = new System.Windows.Forms.Button();
            this.namebox1 = new System.Windows.Forms.TextBox();
            this.name1 = new System.Windows.Forms.Label();
            this.joingrid = new System.Windows.Forms.DataGridView();
            this.ybtn1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.namebox2 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.Label();
            this.grade1 = new System.Windows.Forms.Label();
            this.gradebox1 = new System.Windows.Forms.ComboBox();
            this.gradegrid = new System.Windows.Forms.DataGridView();
            this.ybtn2 = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.dcbox = new System.Windows.Forms.NumericUpDown();
            this.gradebox2 = new System.Windows.Forms.ComboBox();
            this.grade2 = new System.Windows.Forms.Label();
            this.percent = new System.Windows.Forms.Label();
            this.dc = new System.Windows.Forms.Label();
            this.ybtn3 = new System.Windows.Forms.Button();
            this.dcgrid = new System.Windows.Forms.DataGridView();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.imgbox = new System.Windows.Forms.PictureBox();
            this.resetbtn1 = new System.Windows.Forms.Button();
            this.imgbtn = new System.Windows.Forms.Button();
            this.ybtn4 = new System.Windows.Forms.Button();
            this.movie5 = new System.Windows.Forms.Label();
            this.moviebox4 = new System.Windows.Forms.TextBox();
            this.movie4 = new System.Windows.Forms.Label();
            this.moviebox3 = new System.Windows.Forms.TextBox();
            this.movie3 = new System.Windows.Forms.Label();
            this.moviebox2 = new System.Windows.Forms.TextBox();
            this.movie2 = new System.Windows.Forms.Label();
            this.moviebox1 = new System.Windows.Forms.TextBox();
            this.movie1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.timebox3 = new System.Windows.Forms.TextBox();
            this.timebox2 = new System.Windows.Forms.ComboBox();
            this.resetbtn2 = new System.Windows.Forms.Button();
            this.ybtn5 = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.Label();
            this.datebox2 = new System.Windows.Forms.DateTimePicker();
            this.datebox1 = new System.Windows.Forms.DateTimePicker();
            this.time4 = new System.Windows.Forms.Label();
            this.time3 = new System.Windows.Forms.Label();
            this.time2 = new System.Windows.Forms.Label();
            this.timebox1 = new System.Windows.Forms.TextBox();
            this.time1 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.joingrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradegrid)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dcbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dcgrid)).BeginInit();
            this.Panel3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.Info;
            this.Title.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(320, 30);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(188, 37);
            this.Title.TabIndex = 11;
            this.Title.Text = "관리자 페이지";
            // 
            // Tab1
            // 
            this.Tab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Tab1.ForeColor = System.Drawing.Color.White;
            this.Tab1.Location = new System.Drawing.Point(50, 100);
            this.Tab1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tab1.Name = "Tab1";
            this.Tab1.Size = new System.Drawing.Size(125, 50);
            this.Tab1.TabIndex = 12;
            this.Tab1.Text = "회원 관리";
            this.Tab1.UseVisualStyleBackColor = false;
            this.Tab1.Click += new System.EventHandler(this.Tab1_Click);
            // 
            // Tab2
            // 
            this.Tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Tab2.ForeColor = System.Drawing.Color.White;
            this.Tab2.Location = new System.Drawing.Point(50, 175);
            this.Tab2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tab2.Name = "Tab2";
            this.Tab2.Size = new System.Drawing.Size(125, 50);
            this.Tab2.TabIndex = 13;
            this.Tab2.Text = "등급 관리";
            this.Tab2.UseVisualStyleBackColor = false;
            this.Tab2.Click += new System.EventHandler(this.Tab2_Click);
            // 
            // Tab3
            // 
            this.Tab3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Tab3.ForeColor = System.Drawing.Color.White;
            this.Tab3.Location = new System.Drawing.Point(50, 250);
            this.Tab3.Name = "Tab3";
            this.Tab3.Size = new System.Drawing.Size(125, 50);
            this.Tab3.TabIndex = 14;
            this.Tab3.Text = "영화 관리";
            this.Tab3.UseVisualStyleBackColor = false;
            this.Tab3.Click += new System.EventHandler(this.Tab3_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.logoutbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.logoutbtn.ForeColor = System.Drawing.Color.White;
            this.logoutbtn.Location = new System.Drawing.Point(50, 450);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(125, 50);
            this.logoutbtn.TabIndex = 34;
            this.logoutbtn.Text = "로그아웃";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.tabControl1);
            this.Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Panel1.Location = new System.Drawing.Point(225, 100);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(500, 400);
            this.Panel1.TabIndex = 35;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(492, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage1.Controls.Add(this.nbtn);
            this.tabPage1.Controls.Add(this.namebox1);
            this.tabPage1.Controls.Add(this.name1);
            this.tabPage1.Controls.Add(this.joingrid);
            this.tabPage1.Controls.Add(this.ybtn1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(484, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "회원등록";
            // 
            // nbtn
            // 
            this.nbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.nbtn.ForeColor = System.Drawing.Color.White;
            this.nbtn.Location = new System.Drawing.Point(100, 285);
            this.nbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nbtn.Name = "nbtn";
            this.nbtn.Size = new System.Drawing.Size(125, 50);
            this.nbtn.TabIndex = 48;
            this.nbtn.Text = "거절";
            this.nbtn.UseVisualStyleBackColor = false;
            this.nbtn.Click += new System.EventHandler(this.nbtn_Click);
            // 
            // namebox1
            // 
            this.namebox1.Location = new System.Drawing.Point(320, 125);
            this.namebox1.Name = "namebox1";
            this.namebox1.ReadOnly = true;
            this.namebox1.Size = new System.Drawing.Size(100, 25);
            this.namebox1.TabIndex = 47;
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Font = new System.Drawing.Font("굴림", 10F);
            this.name1.Location = new System.Drawing.Point(319, 105);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(76, 17);
            this.name1.TabIndex = 46;
            this.name1.Text = "회원이름";
            // 
            // joingrid
            // 
            this.joingrid.AllowUserToAddRows = false;
            this.joingrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.joingrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.joingrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.joingrid.Location = new System.Drawing.Point(6, 6);
            this.joingrid.MultiSelect = false;
            this.joingrid.Name = "joingrid";
            this.joingrid.ReadOnly = true;
            this.joingrid.RowHeadersWidth = 51;
            this.joingrid.RowTemplate.Height = 27;
            this.joingrid.Size = new System.Drawing.Size(258, 250);
            this.joingrid.TabIndex = 38;
            this.joingrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Click);
            // 
            // ybtn1
            // 
            this.ybtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.ybtn1.ForeColor = System.Drawing.Color.White;
            this.ybtn1.Location = new System.Drawing.Point(275, 285);
            this.ybtn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ybtn1.Name = "ybtn1";
            this.ybtn1.Size = new System.Drawing.Size(125, 50);
            this.ybtn1.TabIndex = 37;
            this.ybtn1.Text = "승인";
            this.ybtn1.UseVisualStyleBackColor = false;
            this.ybtn1.Click += new System.EventHandler(this.ybtn1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage2.Controls.Add(this.namebox2);
            this.tabPage2.Controls.Add(this.name2);
            this.tabPage2.Controls.Add(this.grade1);
            this.tabPage2.Controls.Add(this.gradebox1);
            this.tabPage2.Controls.Add(this.gradegrid);
            this.tabPage2.Controls.Add(this.ybtn2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(484, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "회원등급";
            // 
            // namebox2
            // 
            this.namebox2.Location = new System.Drawing.Point(301, 100);
            this.namebox2.Name = "namebox2";
            this.namebox2.ReadOnly = true;
            this.namebox2.Size = new System.Drawing.Size(100, 25);
            this.namebox2.TabIndex = 45;
            // 
            // name2
            // 
            this.name2.AutoSize = true;
            this.name2.Font = new System.Drawing.Font("굴림", 10F);
            this.name2.Location = new System.Drawing.Point(300, 80);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(76, 17);
            this.name2.TabIndex = 44;
            this.name2.Text = "회원이름";
            // 
            // grade1
            // 
            this.grade1.AutoSize = true;
            this.grade1.Font = new System.Drawing.Font("굴림", 10F);
            this.grade1.Location = new System.Drawing.Point(300, 139);
            this.grade1.Name = "grade1";
            this.grade1.Size = new System.Drawing.Size(42, 17);
            this.grade1.TabIndex = 43;
            this.grade1.Text = "등급";
            // 
            // gradebox1
            // 
            this.gradebox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradebox1.FormattingEnabled = true;
            this.gradebox1.Items.AddRange(new object[] {
            "SILVER",
            "GOLD",
            "VIP"});
            this.gradebox1.Location = new System.Drawing.Point(301, 160);
            this.gradebox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradebox1.Name = "gradebox1";
            this.gradebox1.Size = new System.Drawing.Size(100, 23);
            this.gradebox1.TabIndex = 42;
            // 
            // gradegrid
            // 
            this.gradegrid.AllowUserToAddRows = false;
            this.gradegrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gradegrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gradegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradegrid.Location = new System.Drawing.Point(6, 6);
            this.gradegrid.MultiSelect = false;
            this.gradegrid.Name = "gradegrid";
            this.gradegrid.ReadOnly = true;
            this.gradegrid.RowHeadersWidth = 51;
            this.gradegrid.RowTemplate.Height = 27;
            this.gradegrid.Size = new System.Drawing.Size(231, 250);
            this.gradegrid.TabIndex = 41;
            this.gradegrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Click);
            // 
            // ybtn2
            // 
            this.ybtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.ybtn2.ForeColor = System.Drawing.Color.White;
            this.ybtn2.Location = new System.Drawing.Point(175, 285);
            this.ybtn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ybtn2.Name = "ybtn2";
            this.ybtn2.Size = new System.Drawing.Size(125, 50);
            this.ybtn2.TabIndex = 40;
            this.ybtn2.Text = "변경";
            this.ybtn2.UseVisualStyleBackColor = false;
            this.ybtn2.Click += new System.EventHandler(this.ybtn2_Click);
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.dcbox);
            this.Panel2.Controls.Add(this.gradebox2);
            this.Panel2.Controls.Add(this.grade2);
            this.Panel2.Controls.Add(this.percent);
            this.Panel2.Controls.Add(this.dc);
            this.Panel2.Controls.Add(this.ybtn3);
            this.Panel2.Controls.Add(this.dcgrid);
            this.Panel2.Location = new System.Drawing.Point(225, 100);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(500, 400);
            this.Panel2.TabIndex = 36;
            // 
            // dcbox
            // 
            this.dcbox.Location = new System.Drawing.Point(303, 245);
            this.dcbox.Name = "dcbox";
            this.dcbox.Size = new System.Drawing.Size(50, 25);
            this.dcbox.TabIndex = 49;
            // 
            // gradebox2
            // 
            this.gradebox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradebox2.FormattingEnabled = true;
            this.gradebox2.Items.AddRange(new object[] {
            "SILVER",
            "GOLD",
            "VIP"});
            this.gradebox2.Location = new System.Drawing.Point(103, 244);
            this.gradebox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradebox2.Name = "gradebox2";
            this.gradebox2.Size = new System.Drawing.Size(100, 23);
            this.gradebox2.TabIndex = 48;
            // 
            // grade2
            // 
            this.grade2.AutoSize = true;
            this.grade2.Font = new System.Drawing.Font("굴림", 10F);
            this.grade2.Location = new System.Drawing.Point(100, 225);
            this.grade2.Name = "grade2";
            this.grade2.Size = new System.Drawing.Size(42, 17);
            this.grade2.TabIndex = 47;
            this.grade2.Text = "등급";
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Font = new System.Drawing.Font("굴림", 10F);
            this.percent.Location = new System.Drawing.Point(359, 253);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(22, 17);
            this.percent.TabIndex = 46;
            this.percent.Text = "%";
            // 
            // dc
            // 
            this.dc.AutoSize = true;
            this.dc.Font = new System.Drawing.Font("굴림", 10F);
            this.dc.Location = new System.Drawing.Point(300, 225);
            this.dc.Name = "dc";
            this.dc.Size = new System.Drawing.Size(98, 17);
            this.dc.TabIndex = 44;
            this.dc.Text = "할인율 수정";
            // 
            // ybtn3
            // 
            this.ybtn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.ybtn3.ForeColor = System.Drawing.Color.White;
            this.ybtn3.Location = new System.Drawing.Point(183, 315);
            this.ybtn3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ybtn3.Name = "ybtn3";
            this.ybtn3.Size = new System.Drawing.Size(125, 50);
            this.ybtn3.TabIndex = 43;
            this.ybtn3.Text = "변경";
            this.ybtn3.UseVisualStyleBackColor = false;
            this.ybtn3.Click += new System.EventHandler(this.ybtn3_Click);
            // 
            // dcgrid
            // 
            this.dcgrid.AllowUserToAddRows = false;
            this.dcgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dcgrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dcgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dcgrid.Location = new System.Drawing.Point(150, 63);
            this.dcgrid.MultiSelect = false;
            this.dcgrid.Name = "dcgrid";
            this.dcgrid.ReadOnly = true;
            this.dcgrid.RowHeadersWidth = 51;
            this.dcgrid.RowTemplate.Height = 27;
            this.dcgrid.Size = new System.Drawing.Size(198, 102);
            this.dcgrid.TabIndex = 42;
            this.dcgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Click);
            // 
            // Panel3
            // 
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.tabControl2);
            this.Panel3.Location = new System.Drawing.Point(225, 100);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(500, 400);
            this.Panel3.TabIndex = 37;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(496, 392);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage3.Controls.Add(this.imgbox);
            this.tabPage3.Controls.Add(this.resetbtn1);
            this.tabPage3.Controls.Add(this.imgbtn);
            this.tabPage3.Controls.Add(this.ybtn4);
            this.tabPage3.Controls.Add(this.movie5);
            this.tabPage3.Controls.Add(this.moviebox4);
            this.tabPage3.Controls.Add(this.movie4);
            this.tabPage3.Controls.Add(this.moviebox3);
            this.tabPage3.Controls.Add(this.movie3);
            this.tabPage3.Controls.Add(this.moviebox2);
            this.tabPage3.Controls.Add(this.movie2);
            this.tabPage3.Controls.Add(this.moviebox1);
            this.tabPage3.Controls.Add(this.movie1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(488, 363);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "영화등록";
            // 
            // imgbox
            // 
            this.imgbox.BackgroundImage = global::dbms.Properties.Resources.waiting;
            this.imgbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgbox.Location = new System.Drawing.Point(198, 144);
            this.imgbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgbox.Name = "imgbox";
            this.imgbox.Size = new System.Drawing.Size(150, 133);
            this.imgbox.TabIndex = 107;
            this.imgbox.TabStop = false;
            // 
            // resetbtn1
            // 
            this.resetbtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.resetbtn1.ForeColor = System.Drawing.Color.White;
            this.resetbtn1.Location = new System.Drawing.Point(100, 300);
            this.resetbtn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resetbtn1.Name = "resetbtn1";
            this.resetbtn1.Size = new System.Drawing.Size(125, 50);
            this.resetbtn1.TabIndex = 12;
            this.resetbtn1.Text = "초기화";
            this.resetbtn1.UseVisualStyleBackColor = false;
            this.resetbtn1.Click += new System.EventHandler(this.Tab3_Click);
            // 
            // imgbtn
            // 
            this.imgbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.imgbtn.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.imgbtn.ForeColor = System.Drawing.Color.White;
            this.imgbtn.Location = new System.Drawing.Point(348, 142);
            this.imgbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgbtn.Name = "imgbtn";
            this.imgbtn.Size = new System.Drawing.Size(95, 31);
            this.imgbtn.TabIndex = 11;
            this.imgbtn.Text = "첨부";
            this.imgbtn.UseVisualStyleBackColor = false;
            this.imgbtn.Click += new System.EventHandler(this.imgbtn_Click);
            // 
            // ybtn4
            // 
            this.ybtn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.ybtn4.ForeColor = System.Drawing.Color.White;
            this.ybtn4.Location = new System.Drawing.Point(275, 300);
            this.ybtn4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ybtn4.Name = "ybtn4";
            this.ybtn4.Size = new System.Drawing.Size(125, 50);
            this.ybtn4.TabIndex = 13;
            this.ybtn4.Text = "등록";
            this.ybtn4.UseVisualStyleBackColor = false;
            this.ybtn4.Click += new System.EventHandler(this.ybtn4_Click);
            // 
            // movie5
            // 
            this.movie5.AutoSize = true;
            this.movie5.Location = new System.Drawing.Point(140, 150);
            this.movie5.Name = "movie5";
            this.movie5.Size = new System.Drawing.Size(52, 15);
            this.movie5.TabIndex = 10;
            this.movie5.Text = "포스터";
            // 
            // moviebox4
            // 
            this.moviebox4.Location = new System.Drawing.Point(198, 112);
            this.moviebox4.Name = "moviebox4";
            this.moviebox4.Size = new System.Drawing.Size(150, 25);
            this.moviebox4.TabIndex = 9;
            // 
            // movie4
            // 
            this.movie4.AutoSize = true;
            this.movie4.Location = new System.Drawing.Point(125, 115);
            this.movie4.Name = "movie4";
            this.movie4.Size = new System.Drawing.Size(67, 15);
            this.movie4.TabIndex = 8;
            this.movie4.Text = "주연배우";
            // 
            // moviebox3
            // 
            this.moviebox3.Location = new System.Drawing.Point(198, 82);
            this.moviebox3.Name = "moviebox3";
            this.moviebox3.Size = new System.Drawing.Size(150, 25);
            this.moviebox3.TabIndex = 7;
            // 
            // movie3
            // 
            this.movie3.AutoSize = true;
            this.movie3.Location = new System.Drawing.Point(125, 85);
            this.movie3.Name = "movie3";
            this.movie3.Size = new System.Drawing.Size(67, 15);
            this.movie3.TabIndex = 6;
            this.movie3.Text = "영화감독";
            // 
            // moviebox2
            // 
            this.moviebox2.Location = new System.Drawing.Point(198, 52);
            this.moviebox2.Name = "moviebox2";
            this.moviebox2.Size = new System.Drawing.Size(150, 25);
            this.moviebox2.TabIndex = 5;
            // 
            // movie2
            // 
            this.movie2.AutoSize = true;
            this.movie2.Location = new System.Drawing.Point(155, 55);
            this.movie2.Name = "movie2";
            this.movie2.Size = new System.Drawing.Size(37, 15);
            this.movie2.TabIndex = 4;
            this.movie2.Text = "장르";
            // 
            // moviebox1
            // 
            this.moviebox1.Location = new System.Drawing.Point(198, 22);
            this.moviebox1.Name = "moviebox1";
            this.moviebox1.Size = new System.Drawing.Size(150, 25);
            this.moviebox1.TabIndex = 3;
            // 
            // movie1
            // 
            this.movie1.AutoSize = true;
            this.movie1.Location = new System.Drawing.Point(125, 25);
            this.movie1.Name = "movie1";
            this.movie1.Size = new System.Drawing.Size(67, 15);
            this.movie1.TabIndex = 2;
            this.movie1.Text = "영화제목";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage4.Controls.Add(this.timebox3);
            this.tabPage4.Controls.Add(this.timebox2);
            this.tabPage4.Controls.Add(this.resetbtn2);
            this.tabPage4.Controls.Add(this.ybtn5);
            this.tabPage4.Controls.Add(this.price);
            this.tabPage4.Controls.Add(this.datebox2);
            this.tabPage4.Controls.Add(this.datebox1);
            this.tabPage4.Controls.Add(this.time4);
            this.tabPage4.Controls.Add(this.time3);
            this.tabPage4.Controls.Add(this.time2);
            this.tabPage4.Controls.Add(this.timebox1);
            this.tabPage4.Controls.Add(this.time1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(488, 363);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "상영시간표";
            // 
            // timebox3
            // 
            this.timebox3.Location = new System.Drawing.Point(200, 222);
            this.timebox3.Name = "timebox3";
            this.timebox3.ReadOnly = true;
            this.timebox3.Size = new System.Drawing.Size(100, 25);
            this.timebox3.TabIndex = 13;
            this.timebox3.Text = "8000";
            this.timebox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timebox2
            // 
            this.timebox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timebox2.FormattingEnabled = true;
            this.timebox2.Items.AddRange(new object[] {
            "1관",
            "2관",
            "3관"});
            this.timebox2.Location = new System.Drawing.Point(200, 171);
            this.timebox2.Name = "timebox2";
            this.timebox2.Size = new System.Drawing.Size(100, 23);
            this.timebox2.TabIndex = 12;
            this.timebox2.SelectedIndexChanged += new System.EventHandler(this.combo_Changed);
            // 
            // resetbtn2
            // 
            this.resetbtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.resetbtn2.ForeColor = System.Drawing.Color.White;
            this.resetbtn2.Location = new System.Drawing.Point(100, 300);
            this.resetbtn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resetbtn2.Name = "resetbtn2";
            this.resetbtn2.Size = new System.Drawing.Size(125, 50);
            this.resetbtn2.TabIndex = 9;
            this.resetbtn2.Text = "초기화";
            this.resetbtn2.UseVisualStyleBackColor = false;
            this.resetbtn2.Click += new System.EventHandler(this.Tab3_Click);
            // 
            // ybtn5
            // 
            this.ybtn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.ybtn5.ForeColor = System.Drawing.Color.White;
            this.ybtn5.Location = new System.Drawing.Point(275, 300);
            this.ybtn5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ybtn5.Name = "ybtn5";
            this.ybtn5.Size = new System.Drawing.Size(125, 50);
            this.ybtn5.TabIndex = 10;
            this.ybtn5.Text = "등록";
            this.ybtn5.UseVisualStyleBackColor = false;
            this.ybtn5.Click += new System.EventHandler(this.ybtn5_Click);
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("굴림", 10F);
            this.price.Location = new System.Drawing.Point(306, 225);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(25, 17);
            this.price.TabIndex = 11;
            this.price.Text = "원";
            // 
            // datebox2
            // 
            this.datebox2.CustomFormat = "HH:00";
            this.datebox2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datebox2.Location = new System.Drawing.Point(356, 122);
            this.datebox2.Name = "datebox2";
            this.datebox2.ShowUpDown = true;
            this.datebox2.Size = new System.Drawing.Size(63, 25);
            this.datebox2.TabIndex = 6;
            this.datebox2.Value = new System.DateTime(2021, 11, 28, 0, 0, 0, 0);
            // 
            // datebox1
            // 
            this.datebox1.CustomFormat = "MMMM dd일 (ddd)";
            this.datebox1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datebox1.Location = new System.Drawing.Point(200, 122);
            this.datebox1.Name = "datebox1";
            this.datebox1.Size = new System.Drawing.Size(150, 25);
            this.datebox1.TabIndex = 5;
            // 
            // time4
            // 
            this.time4.AutoSize = true;
            this.time4.Location = new System.Drawing.Point(157, 225);
            this.time4.Name = "time4";
            this.time4.Size = new System.Drawing.Size(37, 15);
            this.time4.TabIndex = 6;
            this.time4.Text = "요금";
            // 
            // time3
            // 
            this.time3.AutoSize = true;
            this.time3.Location = new System.Drawing.Point(112, 175);
            this.time3.Name = "time3";
            this.time3.Size = new System.Drawing.Size(82, 15);
            this.time3.TabIndex = 5;
            this.time3.Text = "상영관번호";
            // 
            // time2
            // 
            this.time2.AutoSize = true;
            this.time2.Location = new System.Drawing.Point(127, 125);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(67, 15);
            this.time2.TabIndex = 4;
            this.time2.Text = "상영시간";
            // 
            // timebox1
            // 
            this.timebox1.Location = new System.Drawing.Point(200, 72);
            this.timebox1.Name = "timebox1";
            this.timebox1.Size = new System.Drawing.Size(150, 25);
            this.timebox1.TabIndex = 3;
            // 
            // time1
            // 
            this.time1.AutoSize = true;
            this.time1.Location = new System.Drawing.Point(127, 75);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(67, 15);
            this.time1.TabIndex = 2;
            this.time1.Text = "영화번호";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.CancelButton = this.logoutbtn;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.Tab3);
            this.Controls.Add(this.Tab2);
            this.Controls.Add(this.Tab1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel3);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.Panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.joingrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradegrid)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dcbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dcgrid)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbox)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Tab1;
        private System.Windows.Forms.Button Tab2;
        private System.Windows.Forms.Button Tab3;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ybtn1;
        private System.Windows.Forms.Button ybtn2;
        private System.Windows.Forms.DataGridView joingrid;
        private System.Windows.Forms.DataGridView gradegrid;
        private System.Windows.Forms.Label grade1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Button ybtn3;
        private System.Windows.Forms.DataGridView dcgrid;
        private System.Windows.Forms.Label dc;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.ComboBox gradebox1;
        private System.Windows.Forms.TextBox namebox2;
        private System.Windows.Forms.Label name2;
        private System.Windows.Forms.Label grade2;
        private System.Windows.Forms.ComboBox gradebox2;
        private System.Windows.Forms.TextBox namebox1;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label movie5;
        private System.Windows.Forms.TextBox moviebox4;
        private System.Windows.Forms.Label movie4;
        private System.Windows.Forms.TextBox moviebox3;
        private System.Windows.Forms.Label movie3;
        private System.Windows.Forms.TextBox moviebox2;
        private System.Windows.Forms.Label movie2;
        private System.Windows.Forms.TextBox moviebox1;
        private System.Windows.Forms.Label movie1;
        private System.Windows.Forms.Button ybtn4;
        private System.Windows.Forms.Button imgbtn;
        private System.Windows.Forms.Button resetbtn1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button resetbtn2;
        private System.Windows.Forms.Button ybtn5;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.DateTimePicker datebox2;
        private System.Windows.Forms.DateTimePicker datebox1;
        private System.Windows.Forms.Label time4;
        private System.Windows.Forms.Label time3;
        private System.Windows.Forms.Label time2;
        private System.Windows.Forms.TextBox timebox1;
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.NumericUpDown dcbox;
        private System.Windows.Forms.PictureBox imgbox;
        private System.Windows.Forms.Button nbtn;
        private System.Windows.Forms.ComboBox timebox2;
        private System.Windows.Forms.TextBox timebox3;
    }
}