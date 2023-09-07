using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "90e07582-6644-4423-b45f-28af21735353");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "60b20566-b0d1-46b4-a47e-eeee126ce0ca");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "9d31929b-24b4-4ebd-96b2-2fbc4a0b65ba", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEOo8jgTXApH7vfCzUGRbvBKimUfYCcDxRDjXzRPJehGsprSLCrbLJrMxQs8nHD18BQ==", null, false, "50a4df74-c056-41dd-8c41-4497ce59e556", false, "admin@localhost.com" },
                    { "9e224968-33e4-4652-b7b7-8574d048cdb9", 0, "cb1eddef-190f-4bd3-8a86-ff83d98f848c", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEKgt9qJWRbieueFUlRAqQ+Zs6RNTM5hBuAP6W3E1X2iBIJw1FJh7XQVl+Cy6YHHGrQ==", null, false, "2f79098c-abda-4ec5-9567-8cd2e1e3b8bc", false, "user@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 10, 6, 3, 342, DateTimeKind.Local).AddTicks(645), new DateTime(2023, 9, 7, 10, 6, 3, 342, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 10, 6, 3, 342, DateTimeKind.Local).AddTicks(657), new DateTime(2023, 9, 7, 10, 6, 3, 342, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 10, 6, 3, 342, DateTimeKind.Local).AddTicks(826), new DateTime(2023, 9, 7, 10, 6, 3, 342, DateTimeKind.Local).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 10, 6, 3, 342, DateTimeKind.Local).AddTicks(828), new DateTime(2023, 9, 7, 10, 6, 3, 342, DateTimeKind.Local).AddTicks(829) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 10, 6, 3, 342, DateTimeKind.Local).AddTicks(892), new DateTime(2023, 9, 7, 10, 6, 3, 342, DateTimeKind.Local).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 10, 6, 3, 342, DateTimeKind.Local).AddTicks(894), new DateTime(2023, 9, 7, 10, 6, 3, 342, DateTimeKind.Local).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 10, 6, 3, 342, DateTimeKind.Local).AddTicks(895), new DateTime(2023, 9, 7, 10, 6, 3, 342, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 10, 6, 3, 342, DateTimeKind.Local).AddTicks(896), new DateTime(2023, 9, 7, 10, 6, 3, 342, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "1f5ca0be-c650-4eb3-a036-8d6d802313ab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "4fc7cb2a-a999-4ad7-a8da-70e942d7e0df");

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
    }
}
