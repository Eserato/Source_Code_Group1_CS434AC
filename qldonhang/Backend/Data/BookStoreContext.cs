using Microsoft.EntityFrameworkCore;
using BookStoreAPI.Models;

namespace BookStoreAPI.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options) { }

        public DbSet<DonHang> DonHangs { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map entity DonHang đến bảng dbo.DonHang
            modelBuilder.Entity<DonHang>()
                .ToTable("DonHang") // 👈 map đúng tên bảng
                .Property(d => d.TongTien)
                .HasPrecision(18, 2); // ví dụ: 18 digits, 2 decimal places

            base.OnModelCreating(modelBuilder);
        }
    }
}
