using Microsoft.EntityFrameworkCore.Migrations;

namespace EFSuperHero.Data.Migrations
{
    public partial class AddedNameProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SuperHeroes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "SuperHeroes");
        }
    }
}
