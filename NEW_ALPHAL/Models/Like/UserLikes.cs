using NEW_ALPHAL.Models.Identitys;
using System.ComponentModel.DataAnnotations;

namespace NEW_ALPHAL.Models.Like
{
    public class UserLikes
    {
        [Key]
        public int Id { get; set; } // Khóa chính

        [Required]
        public string UserId { get; set; } // Id của người dùng

        [Required]
        public int ProductId { get; set; } // Id của truyện

        public virtual Product Product { get; set; } // Liên kết đến truyện

        public virtual ApplicationUser User { get; set; } // Liên kết đến người dùng
    }
}
