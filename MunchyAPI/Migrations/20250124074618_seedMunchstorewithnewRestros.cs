using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MunchyAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedMunchstorewithnewRestros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Munches_API",
                columns: new[] { "Id", "CreatedDate", "ImgUrl", "Location", "Name", "Price", "Rating", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 24, 13, 31, 17, 639, DateTimeKind.Local).AddTicks(2440), "https://images.unsplash.com/photo-1555992336-03a23c424159", "Downtown", "The Gourmet Spot", 150, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2025, 1, 24, 13, 31, 17, 660, DateTimeKind.Local).AddTicks(4315), "https://images.unsplash.com/photo-1528605248644-14dd04022da1", "City Center", "Bistro Bliss", 120, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2025, 1, 24, 13, 31, 17, 660, DateTimeKind.Local).AddTicks(4334), "https://images.unsplash.com/photo-1565299507177-b0ac66763828", "Uptown", "Culinary Haven", 200, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2025, 1, 24, 13, 31, 17, 660, DateTimeKind.Local).AddTicks(4337), "https://images.unsplash.com/photo-1586190848861-99aa4a171e90", "Suburbs", "Savory Delight", 90, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2025, 1, 24, 13, 31, 17, 660, DateTimeKind.Local).AddTicks(4340), "https://images.unsplash.com/photo-1504674900247-0877df9cc836", "Midtown", "Urban Feast", 130, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Munches_API",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Munches_API",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Munches_API",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Munches_API",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Munches_API",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
