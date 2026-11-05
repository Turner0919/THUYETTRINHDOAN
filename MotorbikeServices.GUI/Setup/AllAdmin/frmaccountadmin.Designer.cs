using System.Security.Principal;

namespace MotorbikeServices.GUI.Setup.AllAdmin
{
    partial class frmaccountadmin
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
            tlpMain = new TableLayoutPanel();
            pnlHeader = new Panel();
            btnDangXuat = new Button();
            btnProfile = new Button();
            lblSubtitle = new Label();
            lblLogo = new Label();
            pnlSidebar = new Panel();
            btnCuaHang = new Button();
            btnAccount = new Button();
            btnQuyChuan = new Button();
            btnHangXe = new Button();
            btnDashboard = new Button();
            lblMenuTitle = new Label();
            pnlContent = new Panel();
            tlpMain.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 228F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(pnlHeader, 0, 0);
            tlpMain.Controls.Add(pnlSidebar, 0, 1);
            tlpMain.Controls.Add(pnlContent, 1, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(948, 458);
            tlpMain.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(21, 54, 91);
            tlpMain.SetColumnSpan(pnlHeader, 2);
            pnlHeader.Controls.Add(btnDangXuat);
            pnlHeader.Controls.Add(btnProfile);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblLogo);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(948, 60);
            pnlHeader.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDangXuat.BackColor = Color.PaleTurquoise;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangXuat.Location = new Point(843, 10);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(93, 39);
            btnDangXuat.TabIndex = 4;
            btnDangXuat.Text = "ĐĂNG XUẤT";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnProfile
            // 
            btnProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(764, 16);
            btnProfile.Margin = new Padding(3, 2, 3, 2);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(88, 27);
            btnProfile.TabIndex = 2;
            btnProfile.Text = "Admin";
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.LightSteelBlue;
            lblSubtitle.Location = new Point(183, 20);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(96, 13);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "ADMINISTRATION";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.Transparent;
            lblLogo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(18, 10);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(169, 30);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "DAIDAIMOTOR";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(25, 57, 94);
            pnlSidebar.Controls.Add(btnCuaHang);
            pnlSidebar.Controls.Add(btnAccount);
            pnlSidebar.Controls.Add(btnQuyChuan);
            pnlSidebar.Controls.Add(btnHangXe);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblMenuTitle);
            pnlSidebar.Dock = DockStyle.Fill;
            pnlSidebar.Location = new Point(0, 60);
            pnlSidebar.Margin = new Padding(0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(228, 398);
            pnlSidebar.TabIndex = 1;
            // 
            // btnCuaHang
            // 
            btnCuaHang.Cursor = Cursors.Hand;
            btnCuaHang.FlatAppearance.BorderSize = 0;
            btnCuaHang.FlatStyle = FlatStyle.Flat;
            btnCuaHang.Font = new Font("Segoe UI", 9F);
            btnCuaHang.ForeColor = Color.White;
            btnCuaHang.Location = new Point(9, 191);
            btnCuaHang.Margin = new Padding(3, 2, 3, 2);
            btnCuaHang.Name = "btnCuaHang";
            btnCuaHang.Padding = new Padding(10, 0, 4, 0);
            btnCuaHang.Size = new Size(210, 33);
            btnCuaHang.TabIndex = 5;
            btnCuaHang.Text = "🏪   Quản lý cửa hàng";
            btnCuaHang.TextAlign = ContentAlignment.MiddleLeft;
            btnCuaHang.UseVisualStyleBackColor = false;
            btnCuaHang.Click += btnCuaHang_Click;
            // 
            // btnAccount
            // 
            btnAccount.Cursor = Cursors.Hand;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Segoe UI", 9F);
            btnAccount.ForeColor = Color.White;
            btnAccount.Location = new Point(9, 154);
            btnAccount.Margin = new Padding(3, 2, 3, 2);
            btnAccount.Name = "btnAccount";
            btnAccount.Padding = new Padding(10, 0, 4, 0);
            btnAccount.Size = new Size(210, 33);
            btnAccount.TabIndex = 0;
            btnAccount.Text = "♙   Quản lý tài khoản";
            btnAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnQuyChuan
            // 
            btnQuyChuan.Cursor = Cursors.Hand;
            btnQuyChuan.FlatAppearance.BorderSize = 0;
            btnQuyChuan.FlatStyle = FlatStyle.Flat;
            btnQuyChuan.Font = new Font("Segoe UI", 9F);
            btnQuyChuan.ForeColor = Color.White;
            btnQuyChuan.Location = new Point(9, 116);
            btnQuyChuan.Margin = new Padding(3, 2, 3, 2);
            btnQuyChuan.Name = "btnQuyChuan";
            btnQuyChuan.Padding = new Padding(10, 0, 4, 0);
            btnQuyChuan.Size = new Size(210, 33);
            btnQuyChuan.TabIndex = 3;
            btnQuyChuan.Text = "⚙   Quy chuẩn bảo dưỡng";
            btnQuyChuan.TextAlign = ContentAlignment.MiddleLeft;
            btnQuyChuan.UseVisualStyleBackColor = false;
            btnQuyChuan.Click += btnQuyChuan_Click;
            // 
            // btnHangXe
            // 
            btnHangXe.Cursor = Cursors.Hand;
            btnHangXe.FlatAppearance.BorderSize = 0;
            btnHangXe.FlatStyle = FlatStyle.Flat;
            btnHangXe.Font = new Font("Segoe UI", 9F);
            btnHangXe.ForeColor = Color.White;
            btnHangXe.Location = new Point(9, 79);
            btnHangXe.Margin = new Padding(3, 2, 3, 2);
            btnHangXe.Name = "btnHangXe";
            btnHangXe.Padding = new Padding(10, 0, 4, 0);
            btnHangXe.Size = new Size(210, 33);
            btnHangXe.TabIndex = 2;
            btnHangXe.Text = "🚘   Hãng xe và dòng xe";
            btnHangXe.TextAlign = ContentAlignment.MiddleLeft;
            btnHangXe.UseVisualStyleBackColor = false;
            btnHangXe.Click += btnHangXe_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(25, 57, 94);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(9, 41);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 4, 0);
            btnDashboard.Size = new Size(210, 33);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "▦   Tổng quan";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblMenuTitle
            // 
            lblMenuTitle.AutoSize = true;
            lblMenuTitle.BackColor = Color.Transparent;
            lblMenuTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuTitle.ForeColor = Color.LightSteelBlue;
            lblMenuTitle.Location = new Point(16, 18);
            lblMenuTitle.Name = "lblMenuTitle";
            lblMenuTitle.Size = new Size(121, 15);
            lblMenuTitle.TabIndex = 0;
            lblMenuTitle.Text = "QUẢN LÝ HỆ THỐNG";
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(231, 62);
            pnlContent.Margin = new Padding(3, 2, 3, 2);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(18, 15, 18, 15);
            pnlContent.Size = new Size(714, 394);
            pnlContent.TabIndex = 2;
            // 
            // frmaccountadmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(948, 458);
            Controls.Add(tlpMain);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(964, 497);
            Name = "frmaccountadmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DAIDAIMOTOR Admin";
            WindowState = FormWindowState.Maximized;
            tlpMain.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Panel pnlHeader;
        private Panel pnlSidebar;
        private Panel pnlContent;
        private Button btnProfile;
        private Label lblSubtitle;
        private Label lblLogo;
        private Button btnHangXe;
        private Button btnDashboard;
        private Label lblMenuTitle;
        private Button btnQuyChuan;
        private Button btnAccount;
        private Button btnCuaHang;
        private Button btnDangXuat;
    }
}