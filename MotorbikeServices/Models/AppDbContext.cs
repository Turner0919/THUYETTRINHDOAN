using Microsoft.EntityFrameworkCore;
using MotorbikeServices.DAL.Models.Account;
using MotorbikeServices.DAL.Models.Maintenance;
using MotorbikeServices.DAL.Models.Store;

namespace MotorbikeServices.DAL.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<UserUse> UserUses { get; set; }
        public DbSet<DiaChi> DiaChis { get; set; }
        public DbSet<NhanVienUse> NhanVienUses { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<UserXe> UserXes { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public DbSet<HangXe> HangXes { get; set; }
        public DbSet<DongXe> DongXes { get; set; }

        public DbSet<QuyChuanBaoDuong> QuyChuanBaoDuongs { get; set; }
        public DbSet<QuyChuanXeNguoiDung> QuyChuanXeNguoiDungs { get; set; }
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=localhost\\SQLEXPRESS;Database=MotorbikeServices;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ==========================================
            // 1. UNIQUE INDEX TÀI KHOẢN
            // ==========================================

            modelBuilder.Entity<Admin>()
                .HasIndex(a => a.TenTaiKhoan)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.TenTaiKhoan)
                .IsUnique();


            // ==========================================
            // 2. QUY CHUẨN BẢO DƯỠNG
            // ==========================================

            modelBuilder.Entity<QuyChuanBaoDuong>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.TenQuyChuan)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.MoTa)
                    .HasMaxLength(500);

                entity.HasOne(e => e.DongXe)
                    .WithMany(d => d.QuyChuanBaoDuongs)
                    .HasForeignKey(e => e.DongXeId)
                    .OnDelete(DeleteBehavior.Restrict);
            });


            // ==========================================
            // 3. QUY CHUẨN XE NGƯỜI DÙNG
            // ==========================================

            modelBuilder.Entity<QuyChuanXeNguoiDung>(entity =>
            {
                entity.HasKey(e => e.Id);

                // Quan hệ với UserXe
                entity.HasOne(e => e.UserXe)
                    .WithMany()
                    .HasForeignKey(e => e.UserXeId)
                    .OnDelete(DeleteBehavior.NoAction);

                // Quan hệ với QuyChuanBaoDuong
                entity.HasOne(e => e.QuyChuanBaoDuong)
                    .WithMany()
                    .HasForeignKey(e => e.QuyChuanBaoDuongId)
                    .OnDelete(DeleteBehavior.Cascade);

                // Index
                entity.HasIndex(e => e.UserXeId);

                entity.HasIndex(e => e.QuyChuanBaoDuongId);
            });


            // ==========================================
            // 4. CHI TIẾT HÓA ĐƠN - SẢN PHẨM
            // ==========================================

            modelBuilder.Entity<ChiTietHoaDon>()
                .HasOne(ct => ct.SanPham)
                .WithMany()
                .HasForeignKey(ct => ct.SanPhamId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
