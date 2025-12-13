using HelpDesk.Models;

namespace HelpDesk.Helper
{
    public interface ISessionUser
    {
        public void CriarSessao(UsuarioModel usuario);
        public void ApagarSessao();
        public UsuarioModel BuscarSessao();
    }
}
