using Microsoft.AspNetCore.Mvc;

namespace RoutingPractice.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")] //Attribute route added to index as usually home pages don't have a long URL at all
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View("Privacy");
        }

        
        public IActionResult Display(string id, string num, string cat)
        {
            if(id == null)
            {
                ViewBag.ID = "No ID supplied.";
            }
            else
            {
                ViewBag.ID = id;
            }
            if(num == null)
            {
                ViewBag.Page = "Null";
            }
            else
            {
                ViewBag.Page = num;
            }
            if(cat == null)
            {
                ViewBag.Sort = "Null";
            }
            else
            {
                ViewBag.Sort = cat;
            }
            return View("Display");
        }
    }
}
