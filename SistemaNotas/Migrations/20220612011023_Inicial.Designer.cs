// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaNotas.Context;

namespace SistemaNotas.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220612011023_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SistemaNotas.DTOs.SefazDTO", b =>
                {
                    b.Property<int>("SefazId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnoFabricacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnoModelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Chassi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cnpj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CnpjEminente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Danfe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataEmissao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoUf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Municipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NfNumero")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RSocialEminente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Renavam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UfEminente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValorNf")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SefazId");

                    b.ToTable("SefazDTO");
                });

            modelBuilder.Entity("SistemaNotas.Models.Sefaz", b =>
                {
                    b.Property<int>("SefazId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnoFabricacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnoModelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Chassi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cnpj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CnpjEminente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Danfe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataEmissao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoUf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Municipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NfNumero")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RSocialEminente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Renavam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UfEminente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValorNf")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SefazId");

                    b.ToTable("Sefazs");
                });
#pragma warning restore 612, 618
        }
    }
}
