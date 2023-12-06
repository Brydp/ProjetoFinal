using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Models;

namespace ProjetoFinal.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Cidade> Cidade { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Estado> Estado { get; set; }

        public DbSet<Pais> Pais { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<ProjetoFinal.Models.EntradaProduto>? EntradaProduto { get; set; }

        public DbSet<ProjetoFinal.Models.SaidaProduto>? SaidaProduto { get; set; }

        public DbSet<ProjetoFinal.Models.TipoProduto>? TipoProduto { get; set; }

        public DbSet<ProjetoFinal.Models.TipoSaida>? TipoSaida { get; set; }
    }
}
