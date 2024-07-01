using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LexiconLMS.Migrations
{
    /// <inheritdoc />
    public partial class NyDatabas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 8, 15, 34, 6, 814, DateTimeKind.Local).AddTicks(6811), new DateTime(2024, 7, 1, 15, 34, 6, 814, DateTimeKind.Local).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2024, 7, 1, 15, 34, 6, 814, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2024, 7, 1, 15, 34, 6, 814, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "ModuleId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 31, 15, 34, 6, 814, DateTimeKind.Local).AddTicks(6629), new DateTime(2024, 7, 1, 15, 34, 6, 814, DateTimeKind.Local).AddTicks(6629) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
