using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Progetta.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OwnerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TasksToDo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    AssignedToId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksToDo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TasksToDo_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TasksToDo_Users_AssignedToId",
                        column: x => x.AssignedToId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserProjects",
                columns: table => new
                {
                    UsernameId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProjects", x => new { x.UsernameId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_UserProjects_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProjects_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserProjects_Users_UsernameId",
                        column: x => x.UsernameId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_TasksToDo_TaskId",
                        column: x => x.TaskId,
                        principalTable: "TasksToDo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskTags",
                columns: table => new
                {
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTags", x => new { x.TaskId, x.TagId });
                    table.ForeignKey(
                        name: "FK_TaskTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskTags_TasksToDo_TaskId",
                        column: x => x.TaskId,
                        principalTable: "TasksToDo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    { 1, new DateTime(2024, 11, 29, 0, 37, 37, 188, DateTimeKind.Utc).AddTicks(6367), "To jest opis projektu", "Pierwszy projekt", 1, null },
                    { 2, new DateTime(2024, 11, 29, 0, 37, 37, 188, DateTimeKind.Utc).AddTicks(6371), "To jest opis projektu", "Drugi projekt", 2, null }
                });

            migrationBuilder.InsertData(
                table: "TasksToDo",
                columns: new[] { "Id", "AssignedToId", "CreatedAt", "Description", "DueDate", "Name", "Priority", "ProjectId", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 11, 29, 0, 37, 37, 188, DateTimeKind.Utc).AddTicks(6450), null, null, "Pierwsze zadanie", 1, 1, 0, null },
                    { 2, 2, new DateTime(2024, 11, 29, 0, 37, 37, 188, DateTimeKind.Utc).AddTicks(6456), null, new DateTime(2024, 11, 29, 1, 37, 37, 188, DateTimeKind.Local).AddTicks(6462), "Drugie zadanie", 2, 2, 0, null },
                    { 3, null, new DateTime(2024, 11, 29, 0, 37, 37, 188, DateTimeKind.Utc).AddTicks(6505), null, new DateTime(2024, 11, 29, 1, 37, 37, 188, DateTimeKind.Local).AddTicks(6506), "Trzecie zadanie", 0, 2, 2, null },
                    { 4, 1, new DateTime(2024, 11, 29, 0, 37, 37, 188, DateTimeKind.Utc).AddTicks(6508), "To jest opis zadania", null, "Czwarte zadanie", 2, 1, 0, null }
                });

            migrationBuilder.InsertData(
                table: "UserProjects",
                columns: new[] { "ProjectId", "UsernameId", "CreatedAt", "Role", "UserId" },
                values: new object[] { 2, 1, new DateTime(2024, 11, 29, 0, 37, 37, 188, DateTimeKind.Utc).AddTicks(6591), 1, null });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedAt", "Message", "TaskId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 29, 0, 37, 37, 188, DateTimeKind.Utc).AddTicks(6529), "Lubię to!", 1, null, 1 },
                    { 2, new DateTime(2024, 11, 29, 0, 37, 37, 188, DateTimeKind.Utc).AddTicks(6533), "Super!", 2, null, 1 },
                    { 3, new DateTime(2024, 11, 29, 0, 37, 37, 188, DateTimeKind.Utc).AddTicks(6534), "Wow!", 1, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "TaskTags",
                columns: new[] { "TagId", "TaskId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TaskId",
                table: "Comments",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_OwnerId",
                table: "Projects",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_TasksToDo_AssignedToId",
                table: "TasksToDo",
                column: "AssignedToId");

            migrationBuilder.CreateIndex(
                name: "IX_TasksToDo_ProjectId",
                table: "TasksToDo",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskTags_TagId",
                table: "TaskTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProjects_ProjectId",
                table: "UserProjects",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProjects_UserId",
                table: "UserProjects",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "TaskTags");

            migrationBuilder.DropTable(
                name: "UserProjects");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "TasksToDo");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
