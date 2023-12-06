using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    public class SaidaProduto
    {
        [Column("SaidaProdutoId")]
        [Display(Name = "Saida do Produto")]
        public int SaidaProdutoId { get; set; }

        [Column("ProdutoId")]
        [Display(Name = "Nome do Produto")]
        public int ProdutoId { get; set; }

        [Column("DataSaida")]
        [Display(Name = "Data de Saida")]
        public DateTime DataSaida { get; set; }

        [Column("QuantidadeSaida")]
        [Display(Name = "Quantidade de Saida")]
        public int QuantidadeSaidaId { get; set; }

        [Column("UsuarioId")]
        [Display(Name = "Usuário")]
        public int UsuarioId { get; set; }

        [Column("ClienteId")]
        [Display(Name = "Nome do Cliente")]
        public int ClienteId { get; set; }

        [Column("TipoSaidaId")]
        [Display(Name = "Tipo de Saida")]
        public int TipoSaidaId { get; set; }
    }
}
