using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreAPI.Models // hoặc Models – thống nhất
{
    [Table("DonHang")]
    public class DonHang
    {
        [Key]
        [Column("MaDonHang")]
        public int MaDonHang { get; set; }  // PK, Identity tự tăng

        [Column(TypeName = "nvarchar(20)")]
        public string MaKhachHang { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(255)")]
        public string DiaChi { get; set; } = string.Empty;

        public DateTime NgayDatHang { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TongTien { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string TrangThai { get; set; } = string.Empty;
    }
}
