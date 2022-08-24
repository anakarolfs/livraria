using Microsoft.AspNetCore.Mvc;
using siteLivraria.Models;
using siteLivraria.repository;

namespace siteLivraria.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public LoginController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UsuarioModel usuario = _usuarioRepository.BuscarPorLogin(loginModel.login);

                    if (usuario != null)
                    {
                        if (usuario.SenhaValida(loginModel.senha))
                        {
                            return RedirectToAction("Index", "Home");
                        }
                        TempData["MensagemErro"] = $"Senha inválido, tente novamente";
                    }
                    TempData["MensagemErro"] = $"Usuario e/ou Senha inválido(s). Por favor, tente novamente";
                }
                return View("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao Conectar! Tente novamente, Detalhe: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
