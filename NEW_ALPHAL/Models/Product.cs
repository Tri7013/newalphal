    using System.ComponentModel.DataAnnotations;

    namespace NEW_ALPHAL.Models
    {
        public class Product
        {
            [Key]
            public int Id { get; set; } // Khóa chính

            [Required]
            [StringLength(100)]
            public string Name { get; set; } // Tên truyện

            [Required]
            public string Description { get; set; } // Mô tả truyện

            public int CategoryId { get; set; }
            public Category? Category { get; set; }


            [Required]
            public bool IsPremium { get; set; } // Có phải là truyện VIP hay không

            public DateTime CreatedAt { get; set; } = DateTime.Now; // Ngày tạo

            

            public string? ImageUrl { get; set; } // Đường dẫn đến hình ảnh truyện

       

       

            public bool IsActive { get; set; } = true; // Trạng thái hoạt động của sản phẩm

            public int Likes { get; set; } = 0; // Số lượt thích

            public int ViewCount { get; set; } = 0; // Số lượt xem

            public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>(); // Danh sách bình luận
        }
    }
