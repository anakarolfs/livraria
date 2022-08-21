using Microsoft.AspNetCore.Mvc;
using siteLivraria.Models;
using siteLivraria.repository;

namespace siteLivraria.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepository _contatoRepository;
        public ContatoController(IContatoRepository contatatoRepository)
        {
            _contatoRepository = contatatoRepository;
        }
        public IActionResult Index()
        {
            List<ContatoModel> listContatos = _contatoRepository.buscarTodos();
            return View(listContatos);
        }

        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepository.Adicionar(contato);
            return RedirectToAction("Index");
        }
    }
}
