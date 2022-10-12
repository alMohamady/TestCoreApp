using Microsoft.AspNetCore.Mvc;

namespace TestCoreApp.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
