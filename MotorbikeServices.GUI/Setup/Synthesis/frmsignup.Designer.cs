namespace MotorbikeServices.GUI.Setup.Synthesis
{
    partial class frmsignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsignup));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnHuy = new Button();
            btnDangKy = new Button();
            txtDapAnChoCauHoi = new TextBox();
            label8 = new Label();
            txtDatCauHoi = new TextBox();
            label7 = new Label();
            txtXacNhanMatKhau = new TextBox();
            label6 = new Label();
            txtMatKhau = new TextBox();
            label5 = new Label();
            txtKeyAdmin = new TextBox();
            label4 = new Label();
            cboTaoSoHuu = new ComboBox();
            label3 = new Label();
            txtTaoTaiKhoan = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(933, 443);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(btnHuy);
            panel1.Controls.Add(btnDangKy);
            panel1.Controls.Add(txtDapAnChoCauHoi);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtDatCauHoi);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtXacNhanMatKhau);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtKeyAdmin);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cboTaoSoHuu);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtTaoTaiKhoan);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(469, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 439);
            panel1.TabIndex = 0;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.DarkGray;
            btnHuy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuy.ForeColor = SystemColors.ButtonHighlight;
            btnHuy.Location = new Point(228, 372);
            btnHuy.Margin = new Padding(3, 2, 3, 2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(128, 39);
            btnHuy.TabIndex = 17;
            btnHuy.Text = "HỦY";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(0, 0, 192);
            btnDangKy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDangKy.ForeColor = SystemColors.ButtonHighlight;
            btnDangKy.Location = new Point(94, 372);
            btnDangKy.Margin = new Padding(3, 2, 3, 2);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(128, 39);
            btnDangKy.TabIndex = 16;
            btnDangKy.Text = "ĐĂNG KÝ";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // txtDapAnChoCauHoi
            // 
            txtDapAnChoCauHoi.Location = new Point(50, 339);
            txtDapAnChoCauHoi.Margin = new Padding(3, 2, 3, 2);
            txtDapAnChoCauHoi.Name = "txtDapAnChoCauHoi";
            txtDapAnChoCauHoi.PlaceholderText = "Viết thường, không dấu, không khoảng cách...";
            txtDapAnChoCauHoi.Size = new Size(346, 23);
            txtDapAnChoCauHoi.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label8.Location = new Point(50, 318);
            label8.Name = "label8";
            label8.Size = new Size(140, 20);
            label8.TabIndex = 14;
            label8.Text = "Đáp án cho câu hỏi:";
            // 
            // txtDatCauHoi
            // 
            txtDatCauHoi.Location = new Point(50, 296);
            txtDatCauHoi.Margin = new Padding(3, 2, 3, 2);
            txtDatCauHoi.Name = "txtDatCauHoi";
            txtDatCauHoi.PlaceholderText = "Dành cho trường hợp quên mật khẩu...";
            txtDatCauHoi.Size = new Size(346, 23);
            txtDatCauHoi.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label7.Location = new Point(50, 274);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 12;
            label7.Text = "Đặt câu hỏi:";
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(50, 252);
            txtXacNhanMatKhau.Margin = new Padding(3, 2, 3, 2);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(346, 23);
            txtXacNhanMatKhau.TabIndex = 11;
            txtXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label6.Location = new Point(50, 231);
            label6.Name = "label6";
            label6.Size = new Size(142, 20);
            label6.TabIndex = 10;
            label6.Text = "Xác Nhận Mật Khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(50, 208);
            txtMatKhau.Margin = new Padding(3, 2, 3, 2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PlaceholderText = "Tối thiểu 8 ký tự...";
            txtMatKhau.Size = new Size(346, 23);
            txtMatKhau.TabIndex = 9;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label5.Location = new Point(50, 188);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 8;
            label5.Text = "Mật Khẩu:";
            // 
            // txtKeyAdmin
            // 
            txtKeyAdmin.Location = new Point(50, 165);
            txtKeyAdmin.Margin = new Padding(3, 2, 3, 2);
            txtKeyAdmin.Name = "txtKeyAdmin";
            txtKeyAdmin.PlaceholderText = "Key do Boss cung cấp...";
            txtKeyAdmin.Size = new Size(346, 23);
            txtKeyAdmin.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(50, 144);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 6;
            label4.Text = "Key Admin:";
            // 
            // cboTaoSoHuu
            // 
            cboTaoSoHuu.FormattingEnabled = true;
            cboTaoSoHuu.Items.AddRange(new object[] { "User", "Admin" });
            cboTaoSoHuu.Location = new Point(50, 121);
            cboTaoSoHuu.Margin = new Padding(3, 2, 3, 2);
            cboTaoSoHuu.Name = "cboTaoSoHuu";
            cboTaoSoHuu.Size = new Size(150, 23);
            cboTaoSoHuu.TabIndex = 5;
            cboTaoSoHuu.SelectedIndexChanged += cboTaoSoHuu_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(50, 100);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 4;
            label3.Text = "Tạo Sở Hữu:";
            label3.Click += label3_Click;
            // 
            // txtTaoTaiKhoan
            // 
            txtTaoTaiKhoan.Location = new Point(50, 77);
            txtTaoTaiKhoan.Margin = new Padding(3, 2, 3, 2);
            txtTaoTaiKhoan.Name = "txtTaoTaiKhoan";
            txtTaoTaiKhoan.Size = new Size(346, 23);
            txtTaoTaiKhoan.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(50, 56);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 2;
            label2.Text = "Tạo Tài Khoản:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.8F, FontStyle.Bold);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(81, 13);
            label1.Name = "label1";
            label1.Size = new Size(261, 31);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG KÝ TÀI KHOẢN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 439);
            panel2.TabIndex = 1;
            // 
            // frmsignup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 443);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmsignup";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đăng Ký Tài Khoản";
            Load += frmsignup_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private ComboBox cboTaoSoHuu;
        private Label label3;
        private TextBox txtTaoTaiKhoan;
        private Label label2;
        private TextBox txtKeyAdmin;
        private Label label4;
        private TextBox txtMatKhau;
        private Label label5;
        private TextBox txtXacNhanMatKhau;
        private Label label6;
        private Label label7;
        private TextBox txtDapAnChoCauHoi;
        private Label label8;
        private TextBox txtDatCauHoi;
        private Button btnHuy;
        private Button btnDangKy;
    }
}