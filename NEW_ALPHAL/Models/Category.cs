namespace NEW_ALPHAL.Models
{
    public class Category
    {
        public int Id { get; set; } // ID của thể loại
        public string Name { get; set; } // Tên thể loại
        public List<Product>? Products { get; set; } // Danh sách sản phẩm liên kết

        public Category()
        {
            Products = new List<Product>(); // Khởi tạo danh sách sản phẩm
        }
    }
}
