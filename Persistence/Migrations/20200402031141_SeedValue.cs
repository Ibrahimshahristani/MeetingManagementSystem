using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "values",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Value 01" });

            migrationBuilder.InsertData(
                table: "values",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Value 02" });

            migrationBuilder.InsertData(
                table: "values",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Value 03" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "values",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "values",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "values",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
