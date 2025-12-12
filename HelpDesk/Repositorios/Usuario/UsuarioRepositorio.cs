using HelpDesk.Data;
using HelpDesk.Models;

namespace HelpDesk.Repositorios.Usuario
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly BancoContext _bancoContext;

        public UsuarioRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public UsuarioModel CriarUsuario(UsuarioModel usuario)
        {
            usuario.DataDeCriacao = DateTime.Now;
            _bancoContext.Usuarios.Add(usuario);
            _bancoContext.SaveChanges();
            return usuario; 
        }

        public List<UsuarioModel> BuscarTodos()
        {
            return _bancoContext.Usuarios.ToList();
        }

        public UsuarioModel BuscarPorId(int id)
        {
            return _bancoContext.Usuarios.FirstOrDefault(o => o.Id == id);
        }

        public UsuarioModel EditarUsuario(UsuarioModel usuario)
        {
            UsuarioModel UsuarioDb = BuscarPorId(usuario.Id);

            if (UsuarioDb == null) throw new Exception("Nenhum usuario retornado");

            UsuarioDb.Nome = usuario.Nome;
            UsuarioDb.Login = usuario.Login;
            UsuarioDb.Senha = usuario.Senha;
            UsuarioDb.Priviegio = usuario.Priviegio;

            _bancoContext.Usuarios.Update(UsuarioDb);
            _bancoContext.SaveChanges();
            return UsuarioDb;
        }

        public bool ApagarUsuario(int id)
        {
            UsuarioModel usuario = BuscarPorId(id);

            if (usuario == null) throw new Exception("Nenhum usuario retornado");

            _bancoContext.Usuarios.Remove(usuario);
            _bancoContext.SaveChanges();
            return true;
        }
    }
}
