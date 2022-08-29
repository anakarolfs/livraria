using Microsoft.AspNetCore.Mvc;
using siteLivraria.Filters;
using siteLivraria.Models;
using siteLivraria.repository;

namespace siteLivraria.Controllers
{
    [PgRestritaAdmin]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public IActionResult Index()
        {
            List<UsuarioModel> listUsuarios = _usuarioRepository.buscarTodos();
            return View(listUsuarios);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            UsuarioModel usuario = _usuarioRepository.ListarPorId(id);
            return View(usuario);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            UsuarioModel usuario = _usuarioRepository.ListarPorId(id);
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Criar(UsuarioModel usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    usuario = _usuarioRepository.Adicionar(usuario);
                    TempData["MensagemSucesso"] = "Usuario Cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(usuario);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao Cadastrar Usuario! Tente novamente, Detalhe: {erro.Message}";
                return RedirectToAction("Index");
            }

        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _usuarioRepository.Apagar(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Usuario Apagado com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = "Erro ao Apagar Usuario! Tente novamente.";
                }

                return RedirectToAction("index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao Apagar Usuario! Tente novamente, Detalhe: {erro.Message}";
                return RedirectToAction("index");
            }

        }

        [HttpPost]
        public IActionResult Alterar(UsuarioSemSenhaModel usuarioSemSenha)
        {
            // VERIFICAR PARA CAREÇÃO
            try
            {
                UsuarioModel usuario = null;
                
                if (ModelState.IsValid)
                {
                    usuario = new UsuarioModel()
                    {
                        id = usuarioSemSenha.id,
                        nome = usuarioSemSenha.nome,
                        login = usuarioSemSenha.login,
                        email = usuarioSemSenha.email,
                        perfil = usuarioSemSenha.perfil,
                    };

                    usuario = _usuarioRepository.Atualizar(usuario);
                    TempData["MensagemSucesso"] = "Usuario Alterado com sucesso!";
                    return RedirectToAction("Index");
                }
                return View("Editar", usuario);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao Alterar Usuario! Tente novamente, Detalhe: {erro.Message}";
                return RedirectToAction("Index");
            }

        }

    }
}
