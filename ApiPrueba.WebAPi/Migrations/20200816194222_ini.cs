using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiPrueba.WebAPi.Migrations
{
    public partial class ini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodPais = table.Column<string>(nullable: false),
                    NomPais = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodProv = table.Column<string>(nullable: false),
                    NomProv = table.Column<string>(nullable: false),
                    PaisId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Provincias_Paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Paises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "UQ_CodPais",
                table: "Paises",
                column: "CodPais",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_NomPais",
                table: "Paises",
                column: "NomPais",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_CodProv",
                table: "Provincias",
                column: "CodProv",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_NomProv",
                table: "Provincias",
                column: "NomProv",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Provincias_PaisId",
                table: "Provincias",
                column: "PaisId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Provincias");

            migrationBuilder.DropTable(
                name: "Paises");
        }
    }
}
