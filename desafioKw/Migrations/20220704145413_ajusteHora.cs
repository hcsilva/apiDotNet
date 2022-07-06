using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace desafioKw.Migrations
{
    public partial class ajusteHora : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SaldoHora",
                table: "cartoes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeOnly>(
                name: "SaldoHora",
                table: "cartoes",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }
    }
}
