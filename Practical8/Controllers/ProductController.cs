
using Microsoft.AspNetCore.Mvc;
using SmartInventory.Data;
using SmartInventory.Models;

namespace SmartInventory.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository _repository;

        public ProductController(ProductRepository repository)
        {
            _repository = repository;
        }

        // READ: Display all products
        public IActionResult Index()
        {
            var products = _repository.GetAllProducts();
            return View(products);
        }

        // CREATE: Display form
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // CREATE: Save product
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _repository.AddProduct(product);
                return RedirectToAction(nameof(Index));
            }

            return View(product);
        }

        // UPDATE: Display edit form
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = _repository.GetProductById(id);

            if (product == null)
                return NotFound();

            return View(product);
        }

        // UPDATE: Save changes
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _repository.UpdateProduct(product);
                return RedirectToAction(nameof(Index));
            }

            return View(product);
        }

        // DELETE: Remove product
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var product = _repository.GetProductById(id);

            if (product == null)
                return NotFound();

            _repository.DeleteProduct(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
