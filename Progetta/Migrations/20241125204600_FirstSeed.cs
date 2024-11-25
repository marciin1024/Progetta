using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Progetta.Migrations
{
    /// <inheritdoc />
    public partial class FirstSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Web" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "Role" },
                values: new object[,]
                {
                    { 1, "marcin@gmail.com", "Marcin", "Nowak", "1234", 0 },
                    { 2, "sebastian@gmail.com", "Sebastian", "Kowalski", "1234", 1 },
                    { 3, "leszek@gmail.com", "Leszek", "Malinowski", "1234", 1 }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "OwnerId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 25, 20, 45, 59, 800, DateTimeKind.Utc).AddTicks(8869), "To jest opis projektu", "Pierwszy projekt", 1, null },
                    { 2, new DateTime(2024, 11, 25, 20, 45, 59, 800, DateTimeKind.Utc).AddTicks(8873), "To jest opis projektu", "Drugi projekt", 2, null }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "AssignedToId", "CreatedAt", "Description", "DueDate", "Name", "Priority", "ProjectId", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 11, 25, 20, 45, 59, 800, DateTimeKind.Utc).AddTicks(8890), null, null, "Pierwsze zadanie", 1, 1, 0, null },
                    { 2, 2, new DateTime(2024, 11, 25, 20, 45, 59, 800, DateTimeKind.Utc).AddTicks(8892), null, new DateTime(2024, 11, 25, 21, 45, 59, 800, DateTimeKind.Local).AddTicks(8896), "Drugie zadanie", 2, 2, 0, null },
                    { 3, null, new DateTime(2024, 11, 25, 20, 45, 59, 800, DateTimeKind.Utc).AddTicks(8939), null, new DateTime(2024, 11, 25, 21, 45, 59, 800, DateTimeKind.Local).AddTicks(8940), "Trzecie zadanie", 0, 2, 2, null },
                    { 4, 1, new DateTime(2024, 11, 25, 20, 45, 59, 800, DateTimeKind.Utc).AddTicks(8942), "To jest opis zadania", null, "Czwarte zadanie", 2, 1, 0, null }
                });

            migrationBuilder.InsertData(
                table: "UserProjects",
                columns: new[] { "ProjectId", "UsernameId", "CreatedAt", "Role", "UserId" },
                values: new object[] { 2, 1, new DateTime(2024, 11, 25, 20, 45, 59, 800, DateTimeKind.Utc).AddTicks(9067), 1, null });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedAt", "Message", "TaskId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 25, 20, 45, 59, 800, DateTimeKind.Utc).AddTicks(8960), "Lubię to!", 1, null, 1 },
                    { 2, new DateTime(2024, 11, 25, 20, 45, 59, 800, DateTimeKind.Utc).AddTicks(8962), "Super!", 2, null, 1 },
                    { 3, new DateTime(2024, 11, 25, 20, 45, 59, 800, DateTimeKind.Utc).AddTicks(9006), "Wow!", 1, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "TaskTags",
                columns: new[] { "TagId", "TaskId" },
                values: new object[] { 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TaskTags",
                keyColumns: new[] { "TagId", "TaskId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserProjects",
                keyColumns: new[] { "ProjectId", "UsernameId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
