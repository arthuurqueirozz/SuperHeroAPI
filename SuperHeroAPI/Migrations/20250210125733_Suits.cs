using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperHeroAPI.Migrations
{
    /// <inheritdoc />
    public partial class Suits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Place",
                table: "SuperHeroes");

            migrationBuilder.AddColumn<int>(
                name: "PlaceId",
                table: "SuperHeroes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Suits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuitName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsTechnological = table.Column<bool>(type: "bit", nullable: false),
                    HeroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suits", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SuperHeroes_PlaceId",
                table: "SuperHeroes",
                column: "PlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_SuperHeroes_Suits_PlaceId",
                table: "SuperHeroes",
                column: "PlaceId",
                principalTable: "Suits",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuperHeroes_Suits_PlaceId",
                table: "SuperHeroes");

            migrationBuilder.DropTable(
                name: "Suits");

            migrationBuilder.DropIndex(
                name: "IX_SuperHeroes_PlaceId",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "PlaceId",
                table: "SuperHeroes");

            migrationBuilder.AddColumn<string>(
                name: "Place",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
