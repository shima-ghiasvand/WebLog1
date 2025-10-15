using Microsoft.AspNetCore.Mvc;

namespace weblog.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            ViewBag.BlogId = id;
            return View();
        }
        public IActionResult Archive()
        {
            return View();
        }
    }
}
