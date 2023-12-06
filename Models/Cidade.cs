using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    public class Cidade
    {
        [Column("CidadeId")]
        [Display(Name = "Cód. Cidade")]
        public int CidadeId { get; set; }

        [Column("CidadeNome")]
        [Display(Name = "Nome da Cidade")]
        public string CidadeNome { get; set; } = string.Empty;

        [Column("EstadoId")]
        [Display(Name = "Nome do Estado")]
        public int EstadoId { get; set; }
    }
}
