using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFSuperHero.Data.Migrations
{
    public partial class battlelogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BattleLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    BattleRefId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BattleLogs_battles_BattleRefId",
                        column: x => x.BattleRefId,
                        principalTable: "battles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BattleEvents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Order = table.Column<int>(nullable: false),
                    Summary = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    BattleLogRefId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BattleEvents_BattleLogs_BattleLogRefId",
                        column: x => x.BattleLogRefId,
                        principalTable: "BattleLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BattleEvents_BattleLogRefId",
                table: "BattleEvents",
                column: "BattleLogRefId");

            migrationBuilder.CreateIndex(
                name: "IX_BattleLogs_BattleRefId",
                table: "BattleLogs",
                column: "BattleRefId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BattleEvents");

            migrationBuilder.DropTable(
                name: "BattleLogs");
        }
    }
}
