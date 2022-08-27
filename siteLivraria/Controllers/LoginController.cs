using Microsoft.AspNetCore.Mvc;
using siteLivraria.Helper;
using siteLivraria.Models;
using siteLivraria.repository;

namespace siteLivraria.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly Isessao _sessao;
        public LoginController(IUsuarioRepository usuarioRepository, Isessao sessao)
        {
            _usuarioRepository = usuarioRepository;
            _sessao = sessao;
        }
        public IActionResult Index()
        {
            // se usuario estiver logado redirecionar para home
            if(_sessao.BuscarSessaoUsuario() != null) return RedirectToAction("Index", "Home");

            return View();
        }

        public IActionResult Sair()
        {
            _sessao.RemoverSessaoUsuario();

            return RedirectToAction("Index", "Login");
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
                            _sessao.CriarSessaoUsuario(usuario);
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
