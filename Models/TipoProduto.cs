using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    public class TipoProduto
    {
        [Column("TipoProdutoId")]
        [Display(Name = "Cód. TipoProduto")]
        public int TipoProdutoId { get; set; }

        [Column("TipoProdutoDescricao")]
        [Display(Name = "Nome do Produto")]
        public string TipoProdutoDescricao { get; set; }
    }
}
