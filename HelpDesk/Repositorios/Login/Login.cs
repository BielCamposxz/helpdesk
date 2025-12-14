using HelpDesk.Data;
using HelpDesk.Models;

namespace HelpDesk.Repositorios.Login
{
    public class Login : ILogin
    {
        private readonly BancoContext _bancoContext;

        public Login(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public UsuarioModel BuscarPorLogin(string login)
        {
            UsuarioModel usuario = _bancoContext.Usuarios.FirstOrDefault(user => user.Login == login);

            return usuario;
        }
    }
}
