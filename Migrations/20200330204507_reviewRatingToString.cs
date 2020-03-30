using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelAPI.Migrations
{
    public partial class reviewRatingToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Review",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                columns: new[] { "Rating", "user_name" },
                values: new object[] { "7", "New York" });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "Rating",
                value: "10");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "Rating",
                value: "2");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "Rating",
                value: "4");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5,
                column: "Rating",
                value: "10");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Review",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                columns: new[] { "Rating", "user_name" },
                values: new object[] { 7, "New York user_name" });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "Rating",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5,
                column: "Rating",
                value: 10);
        }
    }
}
