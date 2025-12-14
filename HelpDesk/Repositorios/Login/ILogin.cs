using HelpDesk.Models;

namespace HelpDesk.Repositorios.Login
{
    public interface ILogin
    {
        public UsuarioModel BuscarPorLogin(string login);
    }
}
