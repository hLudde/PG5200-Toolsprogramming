using Microsoft.EntityFrameworkCore.Migrations;

namespace EFSuperHero.Data.Migrations
{
    public partial class trytofixerrors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "HairStyle",
                table: "SuperHeroes",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "HairStyle",
                table: "SuperHeroes",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
