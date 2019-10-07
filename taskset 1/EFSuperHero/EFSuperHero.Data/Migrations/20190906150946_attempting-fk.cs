using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFSuperHero.Data.Migrations
{
    public partial class attemptingfk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "battles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsBrutal = table.Column<bool>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_battles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SuperHeroBattles",
                columns: table => new
                {
                    SuperHeroId = table.Column<int>(nullable: false),
                    BattleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperHeroBattles", x => new { x.SuperHeroId, x.BattleId });
                    table.UniqueConstraint("AK_SuperHeroBattles_BattleId_SuperHeroId", x => new { x.BattleId, x.SuperHeroId });
                    table.ForeignKey(
                        name: "FK_SuperHeroBattles_battles_BattleId",
                        column: x => x.BattleId,
                        principalTable: "battles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SuperHeroBattles_SuperHeroes_SuperHeroId",
                        column: x => x.SuperHeroId,
                        principalTable: "SuperHeroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuperHeroBattles");

            migrationBuilder.DropTable(
                name: "battles");
        }
    }
}
