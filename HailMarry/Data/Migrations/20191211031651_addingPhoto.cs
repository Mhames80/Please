using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HailMarry.Data.Migrations
{
    public partial class addingPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Discussion",
                keyColumn: "DiscussionId",
                keyValue: 1,
                column: "PostedAt",
                value: new DateTime(2019, 12, 10, 22, 16, 50, 925, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Discussion",
                keyColumn: "DiscussionId",
                keyValue: 2,
                column: "PostedAt",
                value: new DateTime(2019, 12, 10, 22, 16, 50, 928, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Discussion",
                keyColumn: "DiscussionId",
                keyValue: 1,
                column: "PostedAt",
                value: new DateTime(2019, 12, 10, 22, 7, 14, 740, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Discussion",
                keyColumn: "DiscussionId",
                keyValue: 2,
                column: "PostedAt",
                value: new DateTime(2019, 12, 10, 22, 7, 14, 743, DateTimeKind.Local));
        }
    }
}
