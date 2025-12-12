using HelpDesk.Models;

namespace HelpDesk.Repositorios.Usuario
{
    public interface IUsuarioRepositorio
    {
        public UsuarioModel CriarUsuario(UsuarioModel usuario);

        public List<UsuarioModel> BuscarTodos();

        public UsuarioModel BuscarPorId(int id);

        public UsuarioModel EditarUsuario(UsuarioModel usuario);

        public bool ApagarUsuario(int id);
    }
}
