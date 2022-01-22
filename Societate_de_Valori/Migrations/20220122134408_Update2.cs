using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Societate_de_Valori.Migrations
{
    public partial class Update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValutID",
                table: "Tranzactie");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ValutID",
                table: "Tranzactie",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
