using Microsoft.EntityFrameworkCore.Migrations;

namespace AISFormations.Web.Migrations
{
    public partial class MajModeleFormation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NombrePlacesDisponibles",
                table: "Formations",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombrePlacesDisponibles",
                table: "Formations");
        }
    }
}
