using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaNotas.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SefazDTO",
                columns: table => new
                {
                    SefazId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoUf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NfNumero = table.Column<int>(type: "int", nullable: false),
                    Danfe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataEmissao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorNf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UfEminente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CnpjEminente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RSocialEminente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chassi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Renavam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnoFabricacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnoModelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SefazDTO", x => x.SefazId);
                });

            migrationBuilder.CreateTable(
                name: "Sefazs",
                columns: table => new
                {
                    SefazId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoUf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NfNumero = table.Column<int>(type: "int", nullable: false),
                    Danfe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataEmissao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorNf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UfEminente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CnpjEminente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RSocialEminente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chassi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Renavam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnoFabricacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnoModelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sefazs", x => x.SefazId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SefazDTO");

            migrationBuilder.DropTable(
                name: "Sefazs");
        }
    }
}
