using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MunchyAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedingwithstaticdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Munches_API",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImgUrl", "Name" },
                values: new object[] { new DateTime(2025, 1, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1612195610857-d20a1a4c38fb", "Truffle Risotto" });

            migrationBuilder.UpdateData(
                table: "Munches_API",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImgUrl", "Name" },
                values: new object[] { new DateTime(2025, 1, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1576659000105-f03f4533b30d", "Lobster Bisque" });

            migrationBuilder.UpdateData(
                table: "Munches_API",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImgUrl", "Name" },
                values: new object[] { new DateTime(2025, 1, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1598939359644-c2c6f678ef45", "Wagyu Beef Steak" });

            migrationBuilder.UpdateData(
                table: "Munches_API",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImgUrl", "Name" },
                values: new object[] { new DateTime(2025, 1, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1511381242551-df92d18062b0", "Duck Confit" });

            migrationBuilder.UpdateData(
                table: "Munches_API",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImgUrl", "Name" },
                values: new object[] { new DateTime(2025, 1, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1565104283-5d78c063ac8a", "Sushi Platter" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Munches_API",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImgUrl", "Name" },
                values: new object[] { new DateTime(2025, 1, 24, 13, 34, 35, 526, DateTimeKind.Local).AddTicks(8293), "https://images.unsplash.com/photo-1555992336-03a23c424159", "The Gourmet Spot" });

            migrationBuilder.UpdateData(
                table: "Munches_API",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImgUrl", "Name" },
                values: new object[] { new DateTime(2025, 1, 24, 13, 34, 35, 527, DateTimeKind.Local).AddTicks(4989), "https://images.unsplash.com/photo-1528605248644-14dd04022da1", "Bistro Bliss" });

            migrationBuilder.UpdateData(
                table: "Munches_API",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImgUrl", "Name" },
                values: new object[] { new DateTime(2025, 1, 24, 13, 34, 35, 527, DateTimeKind.Local).AddTicks(4996), "https://images.unsplash.com/photo-1565299507177-b0ac66763828", "Culinary Haven" });

            migrationBuilder.UpdateData(
                table: "Munches_API",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImgUrl", "Name" },
                values: new object[] { new DateTime(2025, 1, 24, 13, 34, 35, 527, DateTimeKind.Local).AddTicks(4997), "https://images.unsplash.com/photo-1586190848861-99aa4a171e90", "Savory Delight" });

            migrationBuilder.UpdateData(
                table: "Munches_API",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImgUrl", "Name" },
                values: new object[] { new DateTime(2025, 1, 24, 13, 34, 35, 527, DateTimeKind.Local).AddTicks(4999), "https://images.unsplash.com/photo-1504674900247-0877df9cc836", "Urban Feast" });
        }
    }
}
