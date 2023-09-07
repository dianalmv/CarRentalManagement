using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "1f5ca0be-c650-4eb3-a036-8d6d802313ab", "User", "USER" },
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "4fc7cb2a-a999-4ad7-a8da-70e942d7e0df", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 23, 53, 730, DateTimeKind.Local).AddTicks(987), new DateTime(2023, 9, 7, 9, 23, 53, 730, DateTimeKind.Local).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 23, 53, 730, DateTimeKind.Local).AddTicks(1003), new DateTime(2023, 9, 7, 9, 23, 53, 730, DateTimeKind.Local).AddTicks(1004) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 23, 53, 730, DateTimeKind.Local).AddTicks(1172), new DateTime(2023, 9, 7, 9, 23, 53, 730, DateTimeKind.Local).AddTicks(1173) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 23, 53, 730, DateTimeKind.Local).AddTicks(1175), new DateTime(2023, 9, 7, 9, 23, 53, 730, DateTimeKind.Local).AddTicks(1175) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 23, 53, 730, DateTimeKind.Local).AddTicks(1274), new DateTime(2023, 9, 7, 9, 23, 53, 730, DateTimeKind.Local).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 23, 53, 730, DateTimeKind.Local).AddTicks(1276), new DateTime(2023, 9, 7, 9, 23, 53, 730, DateTimeKind.Local).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 23, 53, 730, DateTimeKind.Local).AddTicks(1278), new DateTime(2023, 9, 7, 9, 23, 53, 730, DateTimeKind.Local).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 23, 53, 730, DateTimeKind.Local).AddTicks(1279), new DateTime(2023, 9, 7, 9, 23, 53, 730, DateTimeKind.Local).AddTicks(1280) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4644), new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4657), new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4658) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4817), new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4819), new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4881), new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4882), new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4883) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4884), new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4885), new DateTime(2023, 9, 7, 9, 11, 2, 315, DateTimeKind.Local).AddTicks(4885) });
        }
    }
}
