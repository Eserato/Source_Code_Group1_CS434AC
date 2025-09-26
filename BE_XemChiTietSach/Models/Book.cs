using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; } = string.Empty;
        
        [Required]
        public string Author { get; set; } = string.Empty;
        
        [Required]
        public string Publisher { get; set; } = string.Empty;
        
        [Required]
        public string Country { get; set; } = string.Empty;
        
        [Required]
        public string Category { get; set; } = string.Empty;
        
        public int Pages { get; set; }
        public int Sold { get; set; }
        public decimal Price { get; set; }
        
        [Required]
        public string Description { get; set; } = string.Empty;
        
        public string CoverImage { get; set; } = string.Empty;
        public string ProductType { get; set; } = "Sách"; // Sách, Văn phòng phẩm, etc.
    }
}