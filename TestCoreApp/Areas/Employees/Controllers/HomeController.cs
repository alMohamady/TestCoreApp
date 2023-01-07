using Microsoft.AspNetCore.Mvc;

namespace TestCoreApp.Areas.Employees.Controllers
{
    [Area("Employees")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
