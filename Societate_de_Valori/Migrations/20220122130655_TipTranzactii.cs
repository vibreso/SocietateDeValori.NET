using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Societate_de_Valori.Migrations
{
    public partial class TipTranzactii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipTranzactieID",
                table: "Tranzactie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TipTranzactie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipTranzactie", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tranzactie_TipTranzactieID",
                table: "Tranzactie",
                column: "TipTranzactieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tranzactie_TipTranzactie_TipTranzactieID",
                table: "Tranzactie",
                column: "TipTranzactieID",
                principalTable: "TipTranzactie",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tranzactie_TipTranzactie_TipTranzactieID",
                table: "Tranzactie");

            migrationBuilder.DropTable(
                name: "TipTranzactie");

            migrationBuilder.DropIndex(
                name: "IX_Tranzactie_TipTranzactieID",
                table: "Tranzactie");

            migrationBuilder.DropColumn(
                name: "TipTranzactieID",
                table: "Tranzactie");
        }
    }
}
