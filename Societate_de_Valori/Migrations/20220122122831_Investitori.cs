using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Societate_de_Valori.Migrations
{
    public partial class Investitori : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Investitor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubiectDeDreptID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investitor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Investitor_SubiectDeDrept_SubiectDeDreptID",
                        column: x => x.SubiectDeDreptID,
                        principalTable: "SubiectDeDrept",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Investitor_SubiectDeDreptID",
                table: "Investitor",
                column: "SubiectDeDreptID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Investitor");
        }
    }
}
