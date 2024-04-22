using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[] { 1, "", new DateTime(2024, 4, 23, 0, 44, 32, 939, DateTimeKind.Local).AddTicks(8660), "\r\nA royal villa, often characterized by opulence and grandeur,stands as an epitome of regal luxury and architectural magnificence. Situated amidst lush landscapes, these stately residences serve as a testament to the historical significance and refined taste of royalty. Here, I'll provide an English description of a royal villa, capturing its essence in approximately 100 words.", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fmcmtenerife.com%2Fkakie-sushhestvuyut-razlichiya-mezhdu-villoj-i-osobnyakom%2F&psig=AOvVaw2AaMNX-GZ4-4Rpipf5Q8iQ&ust=1705954550626000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCOjkwvWl74MDFQAAAAAdAAAAABAD", "Royal villa", 5, 200.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
