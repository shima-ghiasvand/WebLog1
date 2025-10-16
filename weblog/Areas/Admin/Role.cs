using Microsoft.AspNetCore.Mvc;

namespace weblog.Areas.Admin
{
    public class Role : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
