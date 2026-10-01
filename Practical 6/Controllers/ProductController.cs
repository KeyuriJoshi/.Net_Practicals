using Microsoft.AspNetCore.Mvc;
using Practical_6.Models;

namespace Practical_6.Controllers
{
    public class ProductController : Controller
    {
        private static readonly List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Category = "Electronics",
                Price = 65000,
                Description = "High-performance laptop suitable for professional and academic use."
            },

            new Product
            {
                Id = 2,
                Name = "Smartphone",
                Category = "Electronics",
                Price = 28000,
                Description = "Modern smartphone with a powerful processor and excellent display."
            },

            new Product
            {
                Id = 3,
                Name = "Wireless Headphones",
                Category = "Accessories",
                Price = 4500,
                Description = "Comfortable wireless headphones with clear sound quality."
            },

            new Product
            {
                Id = 4,
                Name = "Smart Watch",
                Category = "Wearables",
                Price = 7500,
                Description = "Smart watch with fitness tracking and notification features."
            },

            new Product
            {
                Id = 5,
                Name = "Mechanical Keyboard",
                Category = "Accessories",
                Price = 3200,
                Description = "Professional mechanical keyboard designed for comfortable typing."
            },

            new Product
            {
                Id = 6,
                Name = "Monitor",
                Category = "Electronics",
                Price = 15000,
                Description = "Full HD monitor suitable for office work, coding and entertainment."
            }
        };

        public IActionResult Index()
        {
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}