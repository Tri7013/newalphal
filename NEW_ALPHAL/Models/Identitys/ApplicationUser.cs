using Microsoft.AspNetCore.Identity;
using NEW_ALPHAL.Models.Like;
using System.ComponentModel.DataAnnotations;

namespace NEW_ALPHAL.Models.Identitys
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FullName { get; set; }
        public string LoginName { get; set; }
        public bool IsPremium { get; set; } = false; // Tài khoản mặc định là Free
        public virtual ICollection<UserLikes> Likes { get; set; } = new List<UserLikes>(); // Danh sách các truyện đã thích
    }

}
