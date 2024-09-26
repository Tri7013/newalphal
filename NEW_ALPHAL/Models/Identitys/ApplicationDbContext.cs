using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NEW_ALPHAL.Models.Identitys
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSet cho các mô hình
        public DbSet<Product> Products { get; set; } // Bộ sưu tập cho truyện
        public DbSet<ProductImage> ProductImages { get; set; } // Bộ sưu tập cho hình ảnh sản phẩm
        
        public DbSet<Category> Categories { get; set; } // Bộ sưu tập cho thể loại
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);


        }
    }
}
