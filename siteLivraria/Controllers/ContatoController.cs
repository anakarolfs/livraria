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
        public IActionResult Editar(int id)
        {
            ContatoModel contato = _contatoRepository.ListarPorId(id);
            return View(contato);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            ContatoModel contato = _contatoRepository.ListarPorId(id);
            return View(contato);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _contatoRepository.Apagar(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Contato Apagado com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = "Erro ao Apagar Contato! Tente novamente.";
                }

                return RedirectToAction("index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao Cadastrar Contato! Tente novamente, Detalhe: {erro.Message}";
                return RedirectToAction("index");
            }

        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepository.Adicionar(contato);
                    TempData["MensagemSucesso"] = "Contato Cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(contato);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao Cadastrar Contato! Tente novamente, Detalhe: {erro.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Alterar(ContatoModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepository.Atualizar(contato);
                    TempData["MensagemSucesso"] = "Contato Alterado com sucesso!";
                    return RedirectToAction("Index");
                }
                return View("Editar", contato);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao Alterar Contato! Tente novamente, Detalhe: {erro.Message}";
                return RedirectToAction("Index");
            }

        }
    }
}
