using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class Inita : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chocolates",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PercentualCacau = table.Column<float>(type: "real", nullable: false),
                    PercentualAcucar = table.Column<float>(type: "real", nullable: false),
                    PercentualLeite = table.Column<float>(type: "real", nullable: false),
                    PercentualManteiga = table.Column<float>(type: "real", nullable: false),
                    OrigemCacau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temperatura = table.Column<int>(type: "int", nullable: false),
                    Temperado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chocolates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmbbEmbalagems",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Altura = table.Column<float>(type: "real", nullable: false),
                    Largura = table.Column<float>(type: "real", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmbbEmbalagems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmbalagemId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ChocolateId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Chocolates_ChocolateId",
                        column: x => x.ChocolateId,
                        principalTable: "Chocolates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Produtos_EmbbEmbalagems_EmbalagemId",
                        column: x => x.EmbalagemId,
                        principalTable: "EmbbEmbalagems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ChocolateId",
                table: "Produtos",
                column: "ChocolateId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_EmbalagemId",
                table: "Produtos",
                column: "EmbalagemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Chocolates");

            migrationBuilder.DropTable(
                name: "EmbbEmbalagems");
        }
    }
}
