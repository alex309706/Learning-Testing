using Microsoft.AspNetCore.Mvc;
using ProjectToTest.Interfaces;

namespace ProjectToTest.Controllers
{
    public class HomeController : Controller
    {
        IRepository repository;
     
        public HomeController(IRepository inputRepository)
        {
            repository = inputRepository;
        }

        public IActionResult Index()
        {
            return View(repository.GetAll());
        }
    }
}
