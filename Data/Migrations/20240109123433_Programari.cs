using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProiectMediiProgramare.Data.Migrations
{
    public partial class Programari : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StilistID",
                table: "Programare",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Programare_StilistID",
                table: "Programare",
                column: "StilistID");

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_Stilist_StilistID",
                table: "Programare",
                column: "StilistID",
                principalTable: "Stilist",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programare_Stilist_StilistID",
                table: "Programare");

            migrationBuilder.DropIndex(
                name: "IX_Programare_StilistID",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "StilistID",
                table: "Programare");
        }
    }
}
