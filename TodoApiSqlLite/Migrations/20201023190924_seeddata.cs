using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApiSqlLite.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TodoItems",
                columns: new[] { "Id", "IsComplete", "Name" },
                values: new object[] { 1L, true, "Write Backend" });

            migrationBuilder.InsertData(
                table: "TodoItems",
                columns: new[] { "Id", "IsComplete", "Name" },
                values: new object[] { 2L, false, "Write Xamarin app" });

            migrationBuilder.InsertData(
                table: "TodoItems",
                columns: new[] { "Id", "IsComplete", "Name" },
                values: new object[] { 3L, false, "Unit Testing" });

            migrationBuilder.InsertData(
                table: "TodoItems",
                columns: new[] { "Id", "IsComplete", "Name" },
                values: new object[] { 4L, false, "Prepare demo" });

            migrationBuilder.InsertData(
                table: "TodoItems",
                columns: new[] { "Id", "IsComplete", "Name" },
                values: new object[] { 5L, false, "Study for examination" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: 5L);
        }
    }
}
