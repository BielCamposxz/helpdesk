using HelpDesk.Data;
using HelpDesk.Helper;
using HelpDesk.Models;

namespace HelpDesk.Repositorios.Chamados
{
    public class ChamadoRepositorio : IChamadoRepositorio
    {
        private readonly BancoContext _bancoContext;
        private readonly ISessionUser _sessionUser;

        public ChamadoRepositorio(BancoContext BancoContext, ISessionUser sessionUser)
        {
            _bancoContext = BancoContext;
            _sessionUser = sessionUser;
        }

        public ChamadoModel CriarChamado(ChamadoModel chamado)
        {
            chamado.DataAbertura = DateTime.Now;
            chamado.Status = Enums.StatusEnum.aberto;
            chamado.DataAtualizacao = DateTime.Now;
            chamado.UsuarioLogin = _sessionUser.BuscarSessao().Login;
           _bancoContext.Chamados.Add(chamado);
           _bancoContext.SaveChanges();
           return chamado;
        }

        public List<ChamadoModel> BuscarChamados()
        {
            UsuarioModel usuario = _sessionUser.BuscarSessao();

            if(usuario.Priviegio == Enums.PrivilegiosEnum.Tecnico)
            {
                return _bancoContext.Chamados.ToList();
            }
            else
            {
                string idUsuario = usuario.Login;
                return _bancoContext.Chamados.Where(o => o.UsuarioLogin == idUsuario).ToList();

            }
        }

    
    }
}
