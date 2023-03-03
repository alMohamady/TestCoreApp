using Microsoft.AspNetCore.Mvc;
using TestCoreApp.Models;
using TestCoreApp.Repository.Base;

namespace TestCoreApp.Controllers
{
    public class CategoryController : Controller
    {
        public CategoryController(IRepository<Category> repository) 
        {
           _repository = repository;
        }

        private IRepository<Category> _repository;

        //public IActionResult Index()
        //{
        //    return View(_repository.FindAll());
        //}

        public async Task<IActionResult> Index()
        {
            var oneCat = _repository.SelectOne(x => x.Name == "Computers");

            var allCat = await _repository.FindAllAsync("Items"); 

            return View(allCat);
        }
    }
}
