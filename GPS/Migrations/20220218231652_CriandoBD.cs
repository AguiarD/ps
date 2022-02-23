using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GPS.Migrations
{
    public partial class CriandoBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescConta = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    TipoConta = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    ObsConta = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Inativo = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jogadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameJogador = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mensalista = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    ObsMensalista = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Inativo = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parametros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescParametro = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Ponto = table.Column<int>(type: "int", nullable: false),
                    Inativo = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Financeiros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContaId = table.Column<int>(type: "int", nullable: false),
                    JogadorId = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ObsLancamento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DtPrevisao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DtBaixa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inativo = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Financeiros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Financeiros_Contas_ContaId",
                        column: x => x.ContaId,
                        principalTable: "Contas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Financeiros_Jogadores_JogadorId",
                        column: x => x.JogadorId,
                        principalTable: "Jogadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Financeiros_ContaId",
                table: "Financeiros",
                column: "ContaId");

            migrationBuilder.CreateIndex(
                name: "IX_Financeiros_JogadorId",
                table: "Financeiros",
                column: "JogadorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Financeiros");

            migrationBuilder.DropTable(
                name: "Parametros");

            migrationBuilder.DropTable(
                name: "Contas");

            migrationBuilder.DropTable(
                name: "Jogadores");
        }
    }
}
