using Microsoft.EntityFrameworkCore;

namespace BookStore.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Thông tin chi tiết", // Đảm bảo đúng chính tả
                    Author = "Luis Sepúlveda",
                    Publisher = "Kim Đồng",
                    Country = "Chile",
                    Category = "Thiếu nhi",
                    Pages = 144,
                    Sold = 100,
                    Price = 135000,
                    Description = "Chuyện con mèo dạy hải âu bay (tiếng Tây Ban Nha: Historia de una gaviota y del gato que le enseñó a volar) là kiệt tác dành cho thiếu nhi của nhà văn Chile nối tiếng Luis Sepúlveda – tác giả của cuốn Lão già mê đọc truyền tình đã được dịch ra 60 thứ tiếng và bán được 18 triệu bán khắp thế giới. [1] Chuyện con mèo dạy hải âu bay, xuất bán lần đầu năm 1996, cũng đã bán được 5 triệu bán khắp thế giới.[2] Tác phẩm không chỉ là một câu chuyện ấm áp, trong sáng, dể thương về loài vật mà còn chuyến tải thông điệp về trách nhiệm với môi trường về sự sẻ chia và yêu thương cũng như ý nghĩa của những nỗ lực – 'Chỉ những kẻ dám mới có thể bay'.",
                    CoverImage = "/images/sach.jpg" // Đảm bảo đường dẫn đúng
                }
            );
        }
    }
}