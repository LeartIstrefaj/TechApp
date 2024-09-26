using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTables_Updated_contentTable3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryItem_Content_ContentId",
                table: "CategoryItem");

            migrationBuilder.DropIndex(
                name: "IX_CategoryItem_ContentId",
                table: "CategoryItem");

            migrationBuilder.DropColumn(
                name: "ContentId",
                table: "CategoryItem");

            migrationBuilder.AddColumn<int>(
                name: "CategoryItemId",
                table: "Content",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Content_CategoryItemId",
                table: "Content",
                column: "CategoryItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Content_CategoryItem_CategoryItemId",
                table: "Content",
                column: "CategoryItemId",
                principalTable: "CategoryItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Content_CategoryItem_CategoryItemId",
                table: "Content");

            migrationBuilder.DropIndex(
                name: "IX_Content_CategoryItemId",
                table: "Content");

            migrationBuilder.DropColumn(
                name: "CategoryItemId",
                table: "Content");

            migrationBuilder.AddColumn<int>(
                name: "ContentId",
                table: "CategoryItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CategoryItem_ContentId",
                table: "CategoryItem",
                column: "ContentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryItem_Content_ContentId",
                table: "CategoryItem",
                column: "ContentId",
                principalTable: "Content",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
