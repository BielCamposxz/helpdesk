using HelpDesk.Enums;

namespace HelpDesk.Models
{
    public class ChamadoModel
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int? TecnicoId { get; set; }
        public StatusEnum Status { get; set; }

        public string Tipo { get; set; }

        public string Categoria { get; set; }
        public UrgenciaEnum Urgencia { get; set; }
        
        public string Localizacao { get; set; }

        public string Titulo { get; set; }

        public string? Ip {  get; set; }

        public string? Ramal { get; set; }

        public string NomeUsuario { get; set; }

        public string Descricao { get; set; }

        public DateTime DataAbertura { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public DateTime? DataFechamento { get; set; }

    }
}
