using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Societate_de_Valori.Migrations
{
    public partial class Tip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tip",
                table: "SubiectDeDrept",
                newName: "Nume");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nume",
                table: "SubiectDeDrept",
                newName: "Tip");
        }
    }
}
