using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace desafioKw.Migrations
{
    public partial class createdDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cartoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Situacao = table.Column<int>(type: "integer", nullable: false),
                    TituloCard = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Projeto = table.Column<string>(type: "text", nullable: false),
                    DataPrevisao = table.Column<DateOnly>(type: "date", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    Equipe = table.Column<int>(type: "integer", nullable: false),
                    Fase = table.Column<int>(type: "integer", nullable: false),
                    SaldoHora = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    posicaoVertical = table.Column<int>(type: "integer", nullable: false),
                    posicaoHorizontal = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cartoes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cartoes");
        }
    }
}
