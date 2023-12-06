using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    public class EntradaProduto
    {
        [Column("EntradaProdutoId")]
        [Display(Name = "Entrada do Produto")]
        public int EntradaProdutoId { get; set; }

        [Column("ProdutoId")]
        [Display(Name = "Nome do Produto")]
        public int ProdutoId { get; set; }

        [Column("DataEntrada")]
        [Display(Name = "Data de Entrada")]
        public DateTime DataEntrada { get; set; }

        [Column("QuantidadeEntrada")]
        [Display(Name = "Quantidade de Entrada")]
        public int QuantidadeEntradaId { get; set; }
    }
}
