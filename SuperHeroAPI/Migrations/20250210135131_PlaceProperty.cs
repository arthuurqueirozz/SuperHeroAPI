using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperHeroAPI.Migrations
{
    /// <inheritdoc />
    public partial class PlaceProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "marvel",
                table: "SuperHeroes");

            migrationBuilder.AddColumn<int>(
                name: "PlaceOfActionId",
                table: "SuperHeroes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "places",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsReal = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_places", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SuperHeroes_PlaceOfActionId",
                table: "SuperHeroes",
                column: "PlaceOfActionId");

            migrationBuilder.AddForeignKey(
                name: "FK_SuperHeroes_places_PlaceOfActionId",
                table: "SuperHeroes",
                column: "PlaceOfActionId",
                principalTable: "places",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuperHeroes_places_PlaceOfActionId",
                table: "SuperHeroes");

            migrationBuilder.DropTable(
                name: "places");

            migrationBuilder.DropIndex(
                name: "IX_SuperHeroes_PlaceOfActionId",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "PlaceOfActionId",
                table: "SuperHeroes");

            migrationBuilder.AddColumn<bool>(
                name: "marvel",
                table: "SuperHeroes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
