using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitialCreate12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "values",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_values", x => x.Id);
                });

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
            migrationBuilder.DropTable(
                name: "values");
        }
    }
}
