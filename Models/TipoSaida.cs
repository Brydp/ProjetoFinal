using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    public class TipoSaida
    {
        [Column("TipoSaidaId")]
        [Display(Name = "Cód. TipoSaida")]
        public int TipoSaidaId { get; set; }

        [Column("TipoSaidaDescricao")]
        [Display(Name = "Nome de Saida")]
        public string TipoSaidaDescricao { get; set; }
    }
}
