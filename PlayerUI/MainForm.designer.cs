namespace TestAndScore
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChamThi = new System.Windows.Forms.Button();
            this.panelSoanThao = new System.Windows.Forms.Panel();
            this.btn_SoanDeThi = new System.Windows.Forms.Button();
            this.btnSoanCauHoi = new System.Windows.Forms.Button();
            this.btnSoan = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelChamThi = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCaiDat = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelSoanThao.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelChamThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(162)))), ((int)(((byte)(93)))));
            this.panelSideMenu.Controls.Add(this.btnCaiDat);
            this.panelSideMenu.Controls.Add(this.btnThongKe);
            this.panelSideMenu.Controls.Add(this.btnTraCuu);
            this.panelSideMenu.Controls.Add(this.panelChamThi);
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.btnChamThi);
            this.panelSideMenu.Controls.Add(this.panelSoanThao);
            this.panelSideMenu.Controls.Add(this.btnSoan);
            this.panelSideMenu.Controls.Add(this.btnTrangChu);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 573);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(126)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(126)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = global::PlayerUI.Properties.Resources.exit_icon;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 528);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(250, 45);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = " Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChamThi
            // 
            this.btnChamThi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChamThi.FlatAppearance.BorderSize = 0;
            this.btnChamThi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(126)))));
            this.btnChamThi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(126)))));
            this.btnChamThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamThi.ForeColor = System.Drawing.Color.Black;
            this.btnChamThi.Image = global::PlayerUI.Properties.Resources.chamthi;
            this.btnChamThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamThi.Location = new System.Drawing.Point(0, 255);
            this.btnChamThi.Name = "btnChamThi";
            this.btnChamThi.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnChamThi.Size = new System.Drawing.Size(250, 45);
            this.btnChamThi.TabIndex = 5;
            this.btnChamThi.Text = " Ghi Nhận Chấm Thi";
            this.btnChamThi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamThi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChamThi.UseVisualStyleBackColor = true;
            this.btnChamThi.Click += new System.EventHandler(this.btnChamThi_Click);
            // 
            // panelSoanThao
            // 
            this.panelSoanThao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(189)))), ((int)(((byte)(152)))));
            this.panelSoanThao.Controls.Add(this.btn_SoanDeThi);
            this.panelSoanThao.Controls.Add(this.btnSoanCauHoi);
            this.panelSoanThao.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSoanThao.Location = new System.Drawing.Point(0, 175);
            this.panelSoanThao.Name = "panelSoanThao";
            this.panelSoanThao.Size = new System.Drawing.Size(250, 80);
            this.panelSoanThao.TabIndex = 4;
            // 
            // btn_SoanDeThi
            // 
            this.btn_SoanDeThi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_SoanDeThi.FlatAppearance.BorderSize = 0;
            this.btn_SoanDeThi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(126)))));
            this.btn_SoanDeThi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(126)))));
            this.btn_SoanDeThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SoanDeThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SoanDeThi.ForeColor = System.Drawing.Color.Black;
            this.btn_SoanDeThi.Location = new System.Drawing.Point(0, 40);
            this.btn_SoanDeThi.Name = "btn_SoanDeThi";
            this.btn_SoanDeThi.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_SoanDeThi.Size = new System.Drawing.Size(250, 40);
            this.btn_SoanDeThi.TabIndex = 1;
            this.btn_SoanDeThi.Text = "Soạn Đề Thi";
            this.btn_SoanDeThi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SoanDeThi.UseVisualStyleBackColor = true;
            this.btn_SoanDeThi.Click += new System.EventHandler(this.btn_SoanDeThi_Click);
            // 
            // btnSoanCauHoi
            // 
            this.btnSoanCauHoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSoanCauHoi.FlatAppearance.BorderSize = 0;
            this.btnSoanCauHoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(126)))));
            this.btnSoanCauHoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(126)))));
            this.btnSoanCauHoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoanCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoanCauHoi.ForeColor = System.Drawing.Color.Black;
            this.btnSoanCauHoi.Location = new System.Drawing.Point(0, 0);
            this.btnSoanCauHoi.Name = "btnSoanCauHoi";
            this.btnSoanCauHoi.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSoanCauHoi.Size = new System.Drawing.Size(250, 40);
            this.btnSoanCauHoi.TabIndex = 0;
            this.btnSoanCauHoi.Text = "Soạn Câu Hỏi";
            this.btnSoanCauHoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoanCauHoi.UseVisualStyleBackColor = true;
            this.btnSoanCauHoi.Click += new System.EventHandler(this.btnSoanCauHoi_Click);
            // 
            // btnSoan
            // 
            this.btnSoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSoan.FlatAppearance.BorderSize = 0;
            this.btnSoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(126)))));
            this.btnSoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(126)))));
            this.btnSoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoan.ForeColor = System.Drawing.Color.Black;
            this.btnSoan.Image = global::PlayerUI.Properties.Resources.edit;
            this.btnSoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoan.Location = new System.Drawing.Point(0, 130);
            this.btnSoan.Name = "btnSoan";
            this.btnSoan.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSoan.Size = new System.Drawing.Size(250, 45);
            this.btnSoan.TabIndex = 3;
            this.btnSoan.Text = " Soạn Thảo";
            this.btnSoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSoan.UseVisualStyleBackColor = true;
            this.btnSoan.Click += new System.EventHandler(this.btnSoan_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(126)))));
            this.btnTrangChu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(126)))));
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.Black;
            this.btnTrangChu.Image = global::PlayerUI.Properties.Resources.home;
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 85);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTrangChu.Size = new System.Drawing.Size(250, 45);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Text = " Trang Chủ";
            this.btnTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 85);
            this.panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Việc Ra Đề và Chấm Thi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(246)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(686, 573);
            this.panelChildForm.TabIndex = 2;
            // 
            // panelChamThi
            // 
            this.panelChamThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(189)))), ((int)(((byte)(152)))));
            this.panelChamThi.Controls.Add(this.button1);
            this.panelChamThi.Controls.Add(this.button2);
            this.panelChamThi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChamThi.Location = new System.Drawing.Point(0, 300);
            this.panelChamThi.Name = "panelChamThi";
            this.panelChamThi.Size = new System.Drawing.Size(250, 80);
            this.panelChamThi.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(126)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(126)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, 40);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kết Quả Chấm Thi";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(126)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(126)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(250, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "Nhập Điểm Thi";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaiDat.FlatAppearance.BorderSize = 0;
            this.btnCaiDat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(126)))));
            this.btnCaiDat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(126)))));
            this.btnCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaiDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaiDat.ForeColor = System.Drawing.Color.Black;
            this.btnCaiDat.Image = global::PlayerUI.Properties.Resources.setting;
            this.btnCaiDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaiDat.Location = new System.Drawing.Point(0, 470);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCaiDat.Size = new System.Drawing.Size(250, 45);
            this.btnCaiDat.TabIndex = 14;
            this.btnCaiDat.Text = "Cài Đặt";
            this.btnCaiDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaiDat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaiDat.UseVisualStyleBackColor = true;
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(126)))));
            this.btnThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(126)))));
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.Image = global::PlayerUI.Properties.Resources.thongke2;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 425);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(250, 45);
            this.btnThongKe.TabIndex = 13;
            this.btnThongKe.Text = "Báo Cáo Năm";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTraCuu.FlatAppearance.BorderSize = 0;
            this.btnTraCuu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(126)))));
            this.btnTraCuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(148)))), ((int)(((byte)(126)))));
            this.btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.ForeColor = System.Drawing.Color.Black;
            this.btnTraCuu.Image = global::PlayerUI.Properties.Resources.search2;
            this.btnTraCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraCuu.Location = new System.Drawing.Point(0, 380);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTraCuu.Size = new System.Drawing.Size(250, 45);
            this.btnTraCuu.TabIndex = 12;
            this.btnTraCuu.Text = "Tra Cứu Đề Thi";
            this.btnTraCuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraCuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(936, 573);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý việc ra đề và chấm thi của giảng viên";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSoanThao.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelChamThi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnChamThi;
        private System.Windows.Forms.Panel panelSoanThao;
        private System.Windows.Forms.Button btn_SoanDeThi;
        private System.Windows.Forms.Button btnSoanCauHoi;
        private System.Windows.Forms.Button btnSoan;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCaiDat;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Panel panelChamThi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

