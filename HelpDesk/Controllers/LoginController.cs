using HelpDesk.Data;
using HelpDesk.Helper;
using HelpDesk.Models;
using HelpDesk.Repositorios.Login;
using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Controllers
{
    public class LoginController : Controller
    {
        private readonly ISessionUser _sessionuser;
        private readonly ILogin _Login;
        public LoginController(ISessionUser sessionUser, ILogin login)
        {
            _sessionuser = sessionUser;
            _Login = login;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult remover()
        {
            _sessionuser.ApagarSessao();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult FazerLogin(LoginModel usuario)
        {
            UsuarioModel usuarioRetornado = _Login.BuscarPorLogin(usuario.Login);

            if (usuarioRetornado != null)
            {
                if(usuarioRetornado.ValidarSenha(usuario.Senha))
                {
                    _sessionuser.CriarSessao(usuarioRetornado);
                    return RedirectToAction("Index", "Home");
                }
                TempData["MensagemErro"] = "Senha incorreta";
                return RedirectToAction("Index");
            }
            TempData["MensagemErro"] = "Usuario incorreto";
            return View("Index", usuario);
        }
    }
}
