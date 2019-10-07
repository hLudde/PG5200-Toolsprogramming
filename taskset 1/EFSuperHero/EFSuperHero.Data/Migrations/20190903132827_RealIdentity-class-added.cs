using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFSuperHero.Data.Migrations
{
    public partial class RealIdentityclassadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RealIdentities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RealName = table.Column<string>(nullable: true),
                    SuperHeroRefId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RealIdentities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RealIdentities_SuperHeroes_SuperHeroRefId",
                        column: x => x.SuperHeroRefId,
                        principalTable: "SuperHeroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RealIdentities_SuperHeroRefId",
                table: "RealIdentities",
                column: "SuperHeroRefId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RealIdentities");
        }
    }
}
