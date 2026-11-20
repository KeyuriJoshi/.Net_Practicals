
using System.ComponentModel.DataAnnotations;

namespace SmartInventory.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [StringLength(100)]
        public string ProductName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; } = string.Empty;

        [Required(ErrorMessage = "Quantity is required")]
        [Range(0, 100000)]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(typeof(decimal), "0.01", "99999999")]
        public decimal Price { get; set; }
    }
}
