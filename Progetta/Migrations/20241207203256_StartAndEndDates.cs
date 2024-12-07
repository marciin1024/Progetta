using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Progetta.Migrations
{
    /// <inheritdoc />
    public partial class StartAndEndDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "TasksToDo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndAt",
                table: "TasksToDo",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartAt",
                table: "TasksToDo",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "Projects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndAt",
                table: "Projects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartAt",
                table: "Projects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 7, 20, 32, 56, 280, DateTimeKind.Utc).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 7, 20, 32, 56, 280, DateTimeKind.Utc).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 7, 20, 32, 56, 280, DateTimeKind.Utc).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 12, 7, 20, 32, 56, 280, DateTimeKind.Utc).AddTicks(1317), null, null, null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 12, 7, 20, 32, 56, 280, DateTimeKind.Utc).AddTicks(1321), null, null, null });

            migrationBuilder.UpdateData(
                table: "TasksToDo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedById", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 12, 7, 20, 32, 56, 280, DateTimeKind.Utc).AddTicks(1342), null, null, null });

            migrationBuilder.UpdateData(
                table: "TasksToDo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedById", "DueDate", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 12, 7, 20, 32, 56, 280, DateTimeKind.Utc).AddTicks(1344), null, new DateTime(2024, 12, 7, 21, 32, 56, 280, DateTimeKind.Local).AddTicks(1349), null, null });

            migrationBuilder.UpdateData(
                table: "TasksToDo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedById", "DueDate", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 12, 7, 20, 32, 56, 280, DateTimeKind.Utc).AddTicks(1391), null, new DateTime(2024, 12, 7, 21, 32, 56, 280, DateTimeKind.Local).AddTicks(1392), null, null });

            migrationBuilder.UpdateData(
                table: "TasksToDo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedById", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 12, 7, 20, 32, 56, 280, DateTimeKind.Utc).AddTicks(1394), null, null, null });

            migrationBuilder.UpdateData(
                table: "UserProjects",
                keyColumns: new[] { "ProjectId", "UsernameId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTime(2024, 12, 7, 20, 32, 56, 280, DateTimeKind.Utc).AddTicks(1467));

            migrationBuilder.CreateIndex(
                name: "IX_TasksToDo_CreatedById",
                table: "TasksToDo",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_TasksToDo_Users_CreatedById",
                table: "TasksToDo",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TasksToDo_Users_CreatedById",
                table: "TasksToDo");

            migrationBuilder.DropIndex(
                name: "IX_TasksToDo_CreatedById",
                table: "TasksToDo");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "TasksToDo");

            migrationBuilder.DropColumn(
                name: "EndAt",
                table: "TasksToDo");

            migrationBuilder.DropColumn(
                name: "StartAt",
                table: "TasksToDo");

            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "EndAt",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "StartAt",
                table: "Projects");

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
                column: "CreatedAt",
                value: new DateTime(2024, 12, 7, 19, 58, 13, 128, DateTimeKind.Utc).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 7, 19, 58, 13, 128, DateTimeKind.Utc).AddTicks(7104));

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
        }
    }
}
