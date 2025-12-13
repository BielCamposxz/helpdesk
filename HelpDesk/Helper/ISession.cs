using HelpDesk.Models;

namespace HelpDesk.Helper
{
    public interface ISession
    {
        public void CriarSessao(UsuarioModel usuario);
        public void ApagarSessao();

        public UsuarioModel BuscarSessao();
    }
}
