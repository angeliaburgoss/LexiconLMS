using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LexiconLMS.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Fullname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2024, 6, 28, 11, 23, 46, 229, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2024, 6, 28, 11, 23, 46, 229, DateTimeKind.Local).AddTicks(6481));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fullname",
                table: "AspNetUsers");

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
