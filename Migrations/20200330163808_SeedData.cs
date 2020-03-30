using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "DestinationId", "City", "Country", "Rating" },
                values: new object[,]
                {
                    { 1, "New York City", "United States", 7 },
                    { 2, "London", "England", 10 },
                    { 3, "Toronto", "Canada", 2 },
                    { 4, "Guangzho", "China", 4 },
                    { 5, "Belfast", "Northern Ireland", 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 5);
        }
    }
}
