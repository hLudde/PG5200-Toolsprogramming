using Microsoft.EntityFrameworkCore.Migrations;

namespace EFSuperHero.Data.Migrations
{
    public partial class fixedrelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HairDesign",
                table: "SuperHeroes");

            migrationBuilder.AddColumn<int>(
                name: "HairStyle",
                table: "SuperHeroes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_SuperHeroRefId",
                table: "Quotes",
                column: "SuperHeroRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_SuperHeroes_SuperHeroRefId",
                table: "Quotes",
                column: "SuperHeroRefId",
                principalTable: "SuperHeroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_SuperHeroes_SuperHeroRefId",
                table: "Quotes");

            migrationBuilder.DropIndex(
                name: "IX_Quotes_SuperHeroRefId",
                table: "Quotes");

            migrationBuilder.DropColumn(
                name: "HairStyle",
                table: "SuperHeroes");

            migrationBuilder.AddColumn<int>(
                name: "HairDesign",
                table: "SuperHeroes",
                nullable: false,
                defaultValue: 0);
        }
    }
}
