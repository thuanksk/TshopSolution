using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TshopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 3, 23, 54, 55, 74, DateTimeKind.Local).AddTicks(698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 3, 23, 44, 33, 559, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.InsertData(
                table: "AppRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("1ae3c148-f37d-4cce-a563-2d9814a5b8e1"), "ff0d9c94-bc25-47a0-8bce-32f98c425da8", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("6f13f2d8-ec4b-4e8e-b43b-40d7de5e0df0"), 0, "43379a18-41f8-4827-8311-4e62578d0917", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "thuanit2306@gmail.com", true, "Thuan", "Nguyen", false, null, "thuanit2306@gmail.com", "admin", "AQAAAAEAACcQAAAAEAVud1ZjdTqTJE6M5ALrgDJfmtZUP+34FUSKBDuDJODjVt4Emaw/E1JORk+q29L8aw==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("1ae3c148-f37d-4cce-a563-2d9814a5b8e1"), new Guid("6f13f2d8-ec4b-4e8e-b43b-40d7de5e0df0") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 3, 23, 54, 55, 89, DateTimeKind.Local).AddTicks(5482));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("1ae3c148-f37d-4cce-a563-2d9814a5b8e1"));

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("6f13f2d8-ec4b-4e8e-b43b-40d7de5e0df0"));

            migrationBuilder.DeleteData(
                table: "AppUserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1ae3c148-f37d-4cce-a563-2d9814a5b8e1"), new Guid("6f13f2d8-ec4b-4e8e-b43b-40d7de5e0df0") });

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 3, 23, 44, 33, 559, DateTimeKind.Local).AddTicks(9740),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 3, 23, 54, 55, 74, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 3, 23, 44, 33, 574, DateTimeKind.Local).AddTicks(8210));
        }
    }
}
