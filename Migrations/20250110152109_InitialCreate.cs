using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleDeHoras.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataDeInicio = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    HoraDeInicio = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    HoraDeTermino = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    HorasUtilizadas = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    Ticket = table.Column<string>(type: "TEXT", nullable: true),
                    Cliente = table.Column<string>(type: "TEXT", nullable: true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true),
                    Ativo = table.Column<bool>(type: "INTEGER", nullable: false),
                    DataDeCriacao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataDeModificacao = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registros");
        }
    }
}
