using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiPrueba.WebAPi.Migrations
{
    public partial class relacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaisId",
                table: "Provincias",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Provincias_PaisId",
                table: "Provincias",
                column: "PaisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Provincias_Paises_PaisId",
                table: "Provincias",
                column: "PaisId",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Provincias_Paises_PaisId",
                table: "Provincias");

            migrationBuilder.DropIndex(
                name: "IX_Provincias_PaisId",
                table: "Provincias");

            migrationBuilder.DropColumn(
                name: "PaisId",
                table: "Provincias");
        }
    }
}
