using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LexiconLMS.Migrations
{
    /// <inheritdoc />
    public partial class Roles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2024, 6, 28, 11, 18, 34, 69, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2024, 6, 28, 11, 18, 34, 69, DateTimeKind.Local).AddTicks(4387));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2024, 6, 28, 10, 4, 41, 28, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2024, 6, 28, 10, 4, 41, 28, DateTimeKind.Local).AddTicks(6272));
        }
    }
}
