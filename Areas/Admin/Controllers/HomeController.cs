using Microsoft.AspNetCore.Mvc;

namespace RoutingPractice.Areas.Admin.Controllers
{
    [Area("Admin")] //Area attribute
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View("Privacy");
        }

        public IActionResult Display(string id)
        {
            if (id == null)
            {
                return Content("No Admin ID supplied.");
            }
            else
            {
                return Content("Admin ID: " + id);
            }
        }
    }
}
