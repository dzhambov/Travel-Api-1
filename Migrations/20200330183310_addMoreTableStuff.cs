using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelAPI.Migrations
{
    public partial class addMoreTableStuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Review",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 1,
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 2,
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 3,
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 4,
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 5,
                column: "Rating",
                value: 0);

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "DestinationId", "Rating", "ReviewText", "user_name" },
                values: new object[,]
                {
                    { 1, 1, 7, "United States", "New York user_name" },
                    { 2, 2, 10, "England", "London" },
                    { 3, 3, 2, "Canada", "Toronto" },
                    { 4, 4, 4, "China", "Guangzho" },
                    { 5, 5, 10, "Northern Ireland", "Belfast" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Review_DestinationId",
                table: "Review",
                column: "DestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Destination_DestinationId",
                table: "Review",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Destination_DestinationId",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_DestinationId",
                table: "Review");

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Review");

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 1,
                column: "Rating",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 2,
                column: "Rating",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 3,
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 4,
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "DestinationId",
                keyValue: 5,
                column: "Rating",
                value: 10);
        }
    }
}
