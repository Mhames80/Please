using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HailMarry.Data.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ContactInfo",
                columns: new[] { "ContactInfoId", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Sam", "Dean", "555-555-5555" },
                    { 2, "Barry", "Smith", "908-908-0077" }
                });

            migrationBuilder.InsertData(
                table: "RaceCars",
                columns: new[] { "RaceCarsId", "Make", "Model", "Year" },
                values: new object[,]
                {
                    { 1, "PORSCHE", "911", "2018" },
                    { 2, "BMW", "M2 Competition", "2019" }
                });

            migrationBuilder.InsertData(
                table: "Venue",
                columns: new[] { "VenueId", "Description", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Canadian Tire Motorsport Park is a multi-track motorsport venue located north of Bowmanville, in Ontario, Canada, 40 miles east of Toronto", "3233 Concession Rd 10, Bowmanville, ON L1C 3K6", "Canadian Tire Motorsport Park" },
                    { 2, "Kawartha Speedway is a 3/8 mile paved oval located in Fraserville, Ontario, approximately 10 km southwest of Peterborough.", "1382 County Rd 28, Fraserville, ON K0L 1V0", "Kawartha Downs & Speedway" }
                });

            migrationBuilder.InsertData(
                table: "Discussion",
                columns: new[] { "DiscussionId", "Comment", "ContactInfoId", "PostedAt" },
                values: new object[] { 1, "WE WON!!!!!", 1, new DateTime(2019, 12, 10, 21, 0, 45, 144, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Discussion",
                columns: new[] { "DiscussionId", "Comment", "ContactInfoId", "PostedAt" },
                values: new object[] { 2, "WE LOST!!!!!", 2, new DateTime(2019, 12, 10, 21, 0, 45, 146, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Discussion",
                keyColumn: "DiscussionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Discussion",
                keyColumn: "DiscussionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RaceCars",
                keyColumn: "RaceCarsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RaceCars",
                keyColumn: "RaceCarsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ContactInfo",
                keyColumn: "ContactInfoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ContactInfo",
                keyColumn: "ContactInfoId",
                keyValue: 2);
        }
    }
}
