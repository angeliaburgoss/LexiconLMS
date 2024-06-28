using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LexiconLMS.Migrations
{
    /// <inheritdoc />
    public partial class SeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ActivityId", "ActivityDescription", "ActivityName", "EndDate", "ModuleId", "StartDate" },
                values: new object[] { 1, "Blazor + API", "LexiconLMS", new DateTime(2024, 7, 5, 15, 30, 42, 887, DateTimeKind.Local).AddTicks(3238), 0, new DateTime(2024, 6, 28, 15, 30, 42, 887, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "CourseDescription", "StartDate" },
                values: new object[] { "Learn  C#", new DateTime(2024, 6, 28, 15, 30, 42, 887, DateTimeKind.Local).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "CourseDescription", "StartDate" },
                values: new object[] { "Database Design", new DateTime(2024, 6, 28, 15, 30, 42, 887, DateTimeKind.Local).AddTicks(2926) });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "ModuleId", "CourseId", "EndDate", "ModuleDescription", "ModuleName", "StartDate" },
                values: new object[] { 1, 0, new DateTime(2024, 7, 28, 15, 30, 42, 887, DateTimeKind.Local).AddTicks(3211), "Fullstack developer", ".NET", new DateTime(2024, 6, 28, 15, 30, 42, 887, DateTimeKind.Local).AddTicks(3211) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "CourseDescription", "StartDate" },
                values: new object[] { "Learn  C#.", new DateTime(2024, 6, 28, 11, 18, 34, 69, DateTimeKind.Local).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "CourseDescription", "StartDate" },
                values: new object[] { " database design .", new DateTime(2024, 6, 28, 11, 18, 34, 69, DateTimeKind.Local).AddTicks(4387) });
        }
    }
}
