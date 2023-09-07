using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4644), new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4655), "Black", "System" },
                    { 2, "System", new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4657), new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4658), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4817), new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4818), "Toyota", "System" },
                    { 2, "System", new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4819), new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4820), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4881), new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4881), "Prius", "System" },
                    { 2, "System", new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4882), new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4883), "Vitz", "System" },
                    { 3, "System", new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4884), new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4884), "3 Series", "System" },
                    { 4, "System", new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4885), new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4885), "XS", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
