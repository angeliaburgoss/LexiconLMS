using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LexiconLMS.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseDescription", "CourseName", "StartDate", "UserId" },
                values: new object[,]
                {
                    { 1, "Learn  C#.", " Programming", new DateTime(2024, 6, 28, 10, 4, 41, 28, DateTimeKind.Local).AddTicks(6229), 0 },
                    { 2, " database design .", "Databases", new DateTime(2024, 6, 28, 10, 4, 41, 28, DateTimeKind.Local).AddTicks(6272), 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2);
        }
    }
}
