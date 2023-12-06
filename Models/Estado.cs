using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    public class Estado
    {
        [Column("EstadoId")]
        [Display(Name = "Cód. Estado")]
        public int EstadoId { get; set; }

        [Column("EstadoNome")]
        [Display(Name = "Nome do Estado")]
        public string EstadoNome { get; set; } = string.Empty;

        [Column("PaisId")]
        [Display(Name = "Nome do Pais")]
        public int PaisId { get; set; }
    }
}
