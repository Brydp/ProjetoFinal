using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    public class Usuario
    {
        [Column("UsuarioId")]
        [Display(Name = "Cód. Usuario")]
        public int UsuarioId { get; set; }

        [Column("NomeUsuario")]
        [Display(Name = "Nome do Usuario")]
        public string NomeUsuario { get; set; } = string.Empty;

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Column("Senha")]
        [Display(Name = "Senha")]
        public string Senha { get; set; } = string.Empty;
    }
}
