using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TripLog.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Destination = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    AccommodationName = table.Column<string>(nullable: true),
                    AccommodationPhone = table.Column<string>(nullable: true),
                    AccommodationEmail = table.Column<string>(nullable: true),
                    ThingToDo1 = table.Column<string>(nullable: true),
                    ThingToDo2 = table.Column<string>(nullable: true),
                    ThingToDo3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripID);
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripID", "AccommodationEmail", "AccommodationName", "AccommodationPhone", "Destination", "EndDate", "StartDate", "ThingToDo1", "ThingToDo2", "ThingToDo3" },
                values: new object[] { 1, "info@nyhabitat.com", "NY Habitat", "212.255.8018", "New York City", new DateTime(2010, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visit Times Square", "See 30 Rockefeller Plaza", "Check out Union Square farmer's market" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trips");
        }
    }
}
