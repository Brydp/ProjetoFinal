using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    public class Pais
    {
        [Column("PaisId")]
        [Display(Name = "Cód. Pais")]
        public int PaisId { get; set; }

        [Column("PaisNome")]
        [Display(Name = "Nome do Pais")]
        public string PaisNome { get; set; } = string.Empty;
    }
}
