using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Societate_de_Valori.Migrations
{
    public partial class Tranzactii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tranzactie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvestitorID = table.Column<int>(type: "int", nullable: false),
                    PlatformaID = table.Column<int>(type: "int", nullable: false),
                    FirmaID = table.Column<int>(type: "int", nullable: false),
                    Suma = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tranzactie", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tranzactie_Firma_FirmaID",
                        column: x => x.FirmaID,
                        principalTable: "Firma",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tranzactie_Investitor_InvestitorID",
                        column: x => x.InvestitorID,
                        principalTable: "Investitor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tranzactie_Platforma_PlatformaID",
                        column: x => x.PlatformaID,
                        principalTable: "Platforma",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tranzactie_FirmaID",
                table: "Tranzactie",
                column: "FirmaID");

            migrationBuilder.CreateIndex(
                name: "IX_Tranzactie_InvestitorID",
                table: "Tranzactie",
                column: "InvestitorID");

            migrationBuilder.CreateIndex(
                name: "IX_Tranzactie_PlatformaID",
                table: "Tranzactie",
                column: "PlatformaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tranzactie");
        }
    }
}
