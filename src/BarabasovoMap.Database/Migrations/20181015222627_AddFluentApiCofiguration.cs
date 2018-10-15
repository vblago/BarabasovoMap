using Microsoft.EntityFrameworkCore.Migrations;

namespace BarabasovoMap.Database.Migrations
{
    public partial class AddFluentApiCofiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Properties_OwnerId",
                table: "Properties");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Properties_OwnerId_PointId",
                table: "Properties",
                columns: new[] { "OwnerId", "PointId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Properties_OwnerId_PointId",
                table: "Properties");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_OwnerId",
                table: "Properties",
                column: "OwnerId");
        }
    }
}
