﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoFinal.Models;

#nullable disable

namespace ProjetoFinal.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjetoFinal.Models.CasdastroProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Produto");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Fornecedor")
                        .HasColumnType("int")
                        .HasColumnName("FornecedorId");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeProduto");

                    b.Property<string>("Peso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Peso");

                    b.Property<int>("QuantidadeEstoque")
                        .HasColumnType("int")
                        .HasColumnName("QuantidadeEstoque");

                    b.Property<int>("TipoProduto")
                        .HasColumnType("int")
                        .HasColumnName("TipoProdutoId");

                    b.HasKey("Id");

                    b.ToTable("CasdastroProduto");
                });

            modelBuilder.Entity("ProjetoFinal.Models.Cidade", b =>
                {
                    b.Property<int>("CidadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CidadeId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CidadeId"), 1L, 1);

                    b.Property<string>("CidadeNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CidadeNome");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int")
                        .HasColumnName("EstadoId");

                    b.HasKey("CidadeId");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("ProjetoFinal.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ClienteId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"), 1L, 1);

                    b.Property<string>("BairroCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BairroCliente");

                    b.Property<int>("CidadeId")
                        .HasColumnType("int")
                        .HasColumnName("CidadeId");

                    b.Property<string>("CpfCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CpfClientes");

                    b.Property<DateTime>("DataNacimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataNacimento");

                    b.Property<string>("EnderecoCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EnderecoCliente");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeCliente");

                    b.Property<string>("NumeroCasaCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NumeroCasaCliente");

                    b.Property<string>("TelefoneCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TelefoneCliente");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ProjetoFinal.Models.EntradaProduto", b =>
                {
                    b.Property<int>("EntradaProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EntradaProdutoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EntradaProdutoId"), 1L, 1);

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataEntrada");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int")
                        .HasColumnName("ProdutoId");

                    b.Property<int>("QuantidadeEntradaId")
                        .HasColumnType("int")
                        .HasColumnName("QuantidadeEntrada");

                    b.HasKey("EntradaProdutoId");

                    b.ToTable("EntradaProduto");
                });

            modelBuilder.Entity("ProjetoFinal.Models.Estado", b =>
                {
                    b.Property<int>("EstadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EstadoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstadoId"), 1L, 1);

                    b.Property<string>("EstadoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EstadoNome");

                    b.Property<int>("PaisId")
                        .HasColumnType("int")
                        .HasColumnName("PaisId");

                    b.HasKey("EstadoId");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("ProjetoFinal.Models.Pais", b =>
                {
                    b.Property<int>("PaisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PaisId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaisId"), 1L, 1);

                    b.Property<string>("PaisNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PaisNome");

                    b.HasKey("PaisId");

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("ProjetoFinal.Models.SaidaProduto", b =>
                {
                    b.Property<int>("SaidaProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SaidaProdutoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaidaProdutoId"), 1L, 1);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int")
                        .HasColumnName("ClienteId");

                    b.Property<DateTime>("DataSaida")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataSaida");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int")
                        .HasColumnName("ProdutoId");

                    b.Property<int>("QuantidadeSaidaId")
                        .HasColumnType("int")
                        .HasColumnName("QuantidadeSaida");

                    b.Property<int>("TipoSaidaId")
                        .HasColumnType("int")
                        .HasColumnName("TipoSaidaId");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int")
                        .HasColumnName("UsuarioId");

                    b.HasKey("SaidaProdutoId");

                    b.ToTable("SaidaProduto");
                });

            modelBuilder.Entity("ProjetoFinal.Models.TipoProduto", b =>
                {
                    b.Property<int>("TipoProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TipoProdutoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoProdutoId"), 1L, 1);

                    b.Property<string>("TipoProdutoDescricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TipoProdutoDescricao");

                    b.HasKey("TipoProdutoId");

                    b.ToTable("TipoProduto");
                });

            modelBuilder.Entity("ProjetoFinal.Models.TipoSaida", b =>
                {
                    b.Property<int>("TipoSaidaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TipoSaidaId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoSaidaId"), 1L, 1);

                    b.Property<string>("TipoSaidaDescricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TipoSaidaDescricao");

                    b.HasKey("TipoSaidaId");

                    b.ToTable("TipoSaida");
                });

            modelBuilder.Entity("ProjetoFinal.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UsuarioId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeUsuario");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Senha");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
