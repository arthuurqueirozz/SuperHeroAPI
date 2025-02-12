using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperHeroAPI.Migrations
{
    /// <inheritdoc />
    public partial class SuitsRenameModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuperHeroes_Suits_PlaceId",
                table: "SuperHeroes");

            migrationBuilder.RenameColumn(
                name: "PlaceId",
                table: "SuperHeroes",
                newName: "SuitId");

            migrationBuilder.RenameIndex(
                name: "IX_SuperHeroes_PlaceId",
                table: "SuperHeroes",
                newName: "IX_SuperHeroes_SuitId");

            migrationBuilder.AddForeignKey(
                name: "FK_SuperHeroes_Suits_SuitId",
                table: "SuperHeroes",
                column: "SuitId",
                principalTable: "Suits",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuperHeroes_Suits_SuitId",
                table: "SuperHeroes");

            migrationBuilder.RenameColumn(
                name: "SuitId",
                table: "SuperHeroes",
                newName: "PlaceId");

            migrationBuilder.RenameIndex(
                name: "IX_SuperHeroes_SuitId",
                table: "SuperHeroes",
                newName: "IX_SuperHeroes_PlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_SuperHeroes_Suits_PlaceId",
                table: "SuperHeroes",
                column: "PlaceId",
                principalTable: "Suits",
                principalColumn: "Id");
        }
    }
}
