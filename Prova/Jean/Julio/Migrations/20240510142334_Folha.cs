using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Julio.Migrations
{
    /// <inheritdoc />
    public partial class Folha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Folha",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    valor = table.Column<double>(type: "REAL", nullable: true),
                    quantidade = table.Column<int>(type: "INTEGER", nullable: true),
                    mes = table.Column<int>(type: "INTEGER", nullable: true),
                    ano = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Folha", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Folha");
        }
    }
}
