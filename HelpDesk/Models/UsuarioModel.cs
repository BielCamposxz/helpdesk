using HelpDesk.Enums;
using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite um nome valido")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite um login valido")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite um senha valido")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Escolha um tipo de usuario valido")]
        public PrivilegiosEnum Priviegio { get; set; } = PrivilegiosEnum.Usuario;
        public DateTime DataDeCriacao { get; set; }
    }
}
