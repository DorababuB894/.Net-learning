using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bulkyweb.Migrations
{
    /// <inheritdoc />
    public partial class seedmorecategorydata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "DisplayOrder", "Name" },
                values: new object[] { 3, "action movies", 3, "Comedy" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
