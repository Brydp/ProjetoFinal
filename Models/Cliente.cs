using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    public class Cliente
    {
        [Column("ClienteId")]
        [Display(Name = "Cód. Cliente")]
        public int ClienteId { get; set; }

        [Column("NomeCliente")]
        [Display(Name = "Nome do Cliente")]
        public string NomeCliente { get; set; } = string.Empty;

        [Column("DataNacimento")]
        [Display(Name = "Data de Nacimento")]
        public DateTime DataNacimento { get; set; }

        [Column("CpfClientes")]
        [Display(Name = "Nome do Cpf do Cliente")]
        public string CpfCliente { get; set; } = string.Empty;

        [Column("EnderecoCliente")]
        [Display(Name = "Endereço do Cliente")]
        public string EnderecoCliente { get; set; } = string.Empty;

        [Column("NumeroCasaCliente")]
        [Display(Name = "Numero da Casa do Cliente")]
        public string NumeroCasaCliente { get; set; } = string.Empty;

        [Column("BairroCliente")]
        [Display(Name = "Bairro do Cliente")]
        public string BairroCliente { get; set; } = string.Empty;

        [Column("CidadeId")]
        [Display(Name = "Nome da Cidade")]
        public int CidadeId { get; set; }

        [Column("TelefoneCliente")]
        [Display(Name = "Telefone do Cliente")]
        public string TelefoneCliente { get; set; } = string.Empty;
    }
}
