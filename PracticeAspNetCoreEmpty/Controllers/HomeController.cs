using Microsoft.AspNetCore.Mvc;

namespace PracticeAspNetCoreEmpty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
