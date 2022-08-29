using Microsoft.AspNetCore.Mvc;
using siteLivraria.Filters;

namespace siteLivraria.Controllers
{
    [PgUsuarioLogado]
    public class RestritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
