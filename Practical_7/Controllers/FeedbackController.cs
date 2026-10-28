
using Microsoft.AspNetCore.Mvc;
using FeedbackManagement.Models;

namespace FeedbackManagement.Controllers
{
    public class FeedbackController : Controller
    {
        public IActionResult Index()
        {
            return View(new Feedback());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                TempData["Success"] =
                    "Thank you! Your feedback was submitted successfully.";

                return RedirectToAction(nameof(Index));
            }

            return View(feedback);
        }
    }
}
