using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Societate_de_Valori.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ValutID",
                table: "Tranzactie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ValutaID",
                table: "Tranzactie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tranzactie_ValutaID",
                table: "Tranzactie",
                column: "ValutaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tranzactie_Valuta_ValutaID",
                table: "Tranzactie",
                column: "ValutaID",
                principalTable: "Valuta",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tranzactie_Valuta_ValutaID",
                table: "Tranzactie");

            migrationBuilder.DropIndex(
                name: "IX_Tranzactie_ValutaID",
                table: "Tranzactie");

            migrationBuilder.DropColumn(
                name: "ValutID",
                table: "Tranzactie");

            migrationBuilder.DropColumn(
                name: "ValutaID",
                table: "Tranzactie");
        }
    }
}
