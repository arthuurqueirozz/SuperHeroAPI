using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperHeroAPI.Migrations
{
    /// <inheritdoc />
    public partial class PlacePropertyUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuperHeroes_places_PlaceOfActionId",
                table: "SuperHeroes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_places",
                table: "places");

            migrationBuilder.RenameTable(
                name: "places",
                newName: "Places");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Places",
                table: "Places",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SuperHeroes_Places_PlaceOfActionId",
                table: "SuperHeroes",
                column: "PlaceOfActionId",
                principalTable: "Places",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuperHeroes_Places_PlaceOfActionId",
                table: "SuperHeroes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Places",
                table: "Places");

            migrationBuilder.RenameTable(
                name: "Places",
                newName: "places");

            migrationBuilder.AddPrimaryKey(
                name: "PK_places",
                table: "places",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SuperHeroes_places_PlaceOfActionId",
                table: "SuperHeroes",
                column: "PlaceOfActionId",
                principalTable: "places",
                principalColumn: "Id");
        }
    }
}
