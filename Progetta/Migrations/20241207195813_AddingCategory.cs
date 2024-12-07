using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Progetta.Migrations
{
    /// <inheritdoc />
    public partial class AddingCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 7, 19, 58, 13, 128, DateTimeKind.Utc).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 7, 19, 58, 13, 128, DateTimeKind.Utc).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 7, 19, 58, 13, 128, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 12, 7, 19, 58, 13, 128, DateTimeKind.Utc).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 12, 7, 19, 58, 13, 128, DateTimeKind.Utc).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "TasksToDo",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 7, 19, 58, 13, 128, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "TasksToDo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate" },
                values: new object[] { new DateTime(2024, 12, 7, 19, 58, 13, 128, DateTimeKind.Utc).AddTicks(7125), new DateTime(2024, 12, 7, 20, 58, 13, 128, DateTimeKind.Local).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "TasksToDo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DueDate" },
                values: new object[] { new DateTime(2024, 12, 7, 19, 58, 13, 128, DateTimeKind.Utc).AddTicks(7176), new DateTime(2024, 12, 7, 20, 58, 13, 128, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "TasksToDo",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 7, 19, 58, 13, 128, DateTimeKind.Utc).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "UserProjects",
                keyColumns: new[] { "ProjectId", "UsernameId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTime(2024, 12, 7, 19, 58, 13, 128, DateTimeKind.Utc).AddTicks(7326));

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CategoryId",
                table: "Projects",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Category_CategoryId",
                table: "Projects",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Category_CategoryId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Projects_CategoryId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Projects");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 29, 0, 37, 37, 188, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 29, 0, 37, 37, 188, DateTimeKind.Utc).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 29, 0, 37, 37, 188, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 29, 0, 37, 37, 188, DateTimeKind.Utc).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 29, 0, 37, 37, 188, DateTimeKind.Utc).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "TasksToDo",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 29, 0, 37, 37, 188, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "TasksToDo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate" },
                values: new object[] { new DateTime(2024, 11, 29, 0, 37, 37, 188, DateTimeKind.Utc).AddTicks(6456), new DateTime(2024, 11, 29, 1, 37, 37, 188, DateTimeKind.Local).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "TasksToDo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DueDate" },
                values: new object[] { new DateTime(2024, 11, 29, 0, 37, 37, 188, DateTimeKind.Utc).AddTicks(6505), new DateTime(2024, 11, 29, 1, 37, 37, 188, DateTimeKind.Local).AddTicks(6506) });

            migrationBuilder.UpdateData(
                table: "TasksToDo",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 29, 0, 37, 37, 188, DateTimeKind.Utc).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "UserProjects",
                keyColumns: new[] { "ProjectId", "UsernameId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTime(2024, 11, 29, 0, 37, 37, 188, DateTimeKind.Utc).AddTicks(6591));
        }
    }
}
