using Microsoft.AspNetCore.Mvc;

namespace siteLivraria.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
