using HelpDesk.Models;
using Microsoft.EntityFrameworkCore;

namespace HelpDesk.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> Options) : base(Options)
        {
            

        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TipoModel> Tipos { get; set; }
        public DbSet<CategoriaModel> Categorias { get; set; }
        public DbSet<LocalizacaoModel> Localizacoes { get; set; }
        public DbSet<ChamadoModel> Chamados { get; set; }

    }
}
