using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addUsersToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 5, 28, 23, 31, 1, 356, DateTimeKind.Local).AddTicks(4377), "https://dotnetmastery.com/bluevillaimages/villa1.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 11, 1, 480, DateTimeKind.Local).AddTicks(4282), "https://www.google.com/url?sa=i&url=https%3A%2F%2Fmcmtenerife.com%2Fkakie-sushhestvuyut-razlichiya-mezhdu-villoj-i-osobnyakom%2F&psig=AOvVaw2AaMNX-GZ4-4Rpipf5Q8iQ&ust=1705954550626000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCOjkwvWl74MDFQAAAAAdAAAAABAD" });
        }
    }
}
