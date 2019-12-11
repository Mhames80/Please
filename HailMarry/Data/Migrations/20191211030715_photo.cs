using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HailMarry.Data.Migrations
{
    public partial class photo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "RaceCars",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "RaceCars");

            migrationBuilder.UpdateData(
                table: "Discussion",
                keyColumn: "DiscussionId",
                keyValue: 1,
                column: "PostedAt",
                value: new DateTime(2019, 12, 10, 21, 0, 45, 144, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Discussion",
                keyColumn: "DiscussionId",
                keyValue: 2,
                column: "PostedAt",
                value: new DateTime(2019, 12, 10, 21, 0, 45, 146, DateTimeKind.Local));
        }
    }
}
