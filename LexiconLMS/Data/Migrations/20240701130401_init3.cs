using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LexiconLMS.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 8, 15, 3, 59, 267, DateTimeKind.Local).AddTicks(7211), new DateTime(2024, 7, 1, 15, 3, 59, 267, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2024, 7, 1, 15, 3, 59, 267, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2024, 7, 1, 15, 3, 59, 267, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 31, 15, 3, 59, 267, DateTimeKind.Local).AddTicks(7060), new DateTime(2024, 7, 1, 15, 3, 59, 267, DateTimeKind.Local).AddTicks(7060) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 5, 15, 30, 42, 887, DateTimeKind.Local).AddTicks(3238), new DateTime(2024, 6, 28, 15, 30, 42, 887, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2024, 6, 28, 15, 30, 42, 887, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2024, 6, 28, 15, 30, 42, 887, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 28, 15, 30, 42, 887, DateTimeKind.Local).AddTicks(3211), new DateTime(2024, 6, 28, 15, 30, 42, 887, DateTimeKind.Local).AddTicks(3211) });
        }
    }
}
