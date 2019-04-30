using Microsoft.EntityFrameworkCore.Migrations;

namespace AISFormations.Web.Migrations
{
    public partial class MajModeleFormationAddEstActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EstActive",
                table: "Formations",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstActive",
                table: "Formations");
        }
    }
}
