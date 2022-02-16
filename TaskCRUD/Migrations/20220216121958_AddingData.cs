using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskCRUD.Migrations
{
    public partial class AddingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Completed", "Description", "Title" },
                values: new object[,]
                {
                    { 1, false, "description 1", "Task 1" },
                    { 2, false, "description 2", "Task 2" },
                    { 3, false, "description 3", "Task 3" },
                    { 4, false, "description 4", "Task 4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
