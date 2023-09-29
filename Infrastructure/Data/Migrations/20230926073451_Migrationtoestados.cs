using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.migrations
{
    /// <inheritdoc />
    public partial class Migrationtoestados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "codEstado",
                table: "Regiones",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "estadocodEstado",
                table: "Regiones",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "codPais",
                table: "Estados",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "paiscodPais",
                table: "Estados",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Regiones_estadocodEstado",
                table: "Regiones",
                column: "estadocodEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Estados_paiscodPais",
                table: "Estados",
                column: "paiscodPais");

            migrationBuilder.AddForeignKey(
                name: "FK_Estados_Paises_paiscodPais",
                table: "Estados",
                column: "paiscodPais",
                principalTable: "Paises",
                principalColumn: "codPais",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Regiones_Estados_estadocodEstado",
                table: "Regiones",
                column: "estadocodEstado",
                principalTable: "Estados",
                principalColumn: "codEstado");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estados_Paises_paiscodPais",
                table: "Estados");

            migrationBuilder.DropForeignKey(
                name: "FK_Regiones_Estados_estadocodEstado",
                table: "Regiones");

            migrationBuilder.DropIndex(
                name: "IX_Regiones_estadocodEstado",
                table: "Regiones");

            migrationBuilder.DropIndex(
                name: "IX_Estados_paiscodPais",
                table: "Estados");

            migrationBuilder.DropColumn(
                name: "codEstado",
                table: "Regiones");

            migrationBuilder.DropColumn(
                name: "estadocodEstado",
                table: "Regiones");

            migrationBuilder.DropColumn(
                name: "codPais",
                table: "Estados");

            migrationBuilder.DropColumn(
                name: "paiscodPais",
                table: "Estados");
        }
    }
}
