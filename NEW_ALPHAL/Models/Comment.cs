using System.ComponentModel.DataAnnotations;

namespace NEW_ALPHAL.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; } // Khóa chính

        [Required]
        public string Content { get; set; } // Nội dung bình luận

        [Required]
        public string UserId { get; set; } // Id của người bình luận

        public DateTime CreatedAt { get; set; } = DateTime.Now; // Ngày tạo bình luận

        public virtual Product Product { get; set; } // Liên kết đến sản phẩm
    }
}
