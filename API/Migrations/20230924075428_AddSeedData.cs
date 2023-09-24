using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DepartmentHistories",
                columns: new[] { "DepartmentHistoryId", "Available", "DepartmentId", "EmployeeId" },
                values: new object[,]
                {
                    { 1, true, "D1", 1 },
                    { 2, true, "D2", 2 },
                    { 3, true, "D1", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DepartmentHistories",
                keyColumn: "DepartmentHistoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DepartmentHistories",
                keyColumn: "DepartmentHistoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DepartmentHistories",
                keyColumn: "DepartmentHistoryId",
                keyValue: 3);
        }
    }
}
