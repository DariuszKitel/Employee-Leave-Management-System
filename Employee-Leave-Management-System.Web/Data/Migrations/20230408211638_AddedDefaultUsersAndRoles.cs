using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Employee_Leave_Management_System.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "409aa945-3b98-2231-7321-9870eb22d922", null, "Administrator", "ADMINISTRATOR" },
                    { "411aa945-3b98-2231-7321-9870eb22d832", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "408aa925-3b98-2231-7321-9870eb22d332", 0, "7a234e19-160e-498f-b36a-33277996ab03", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAIAAYagAAAAED1StCu3o0tybikEhLPwSNAjCgjKNVGSYrUPeNWra8TPzO+0Tlrgsg85B+ajfcI3kA==", null, false, "47195a71-da93-4701-ba14-06c043839837", null, false, null },
                    { "408aa945-3b98-2231-7321-9870eb22d909", 0, "cefe3c14-fe17-40da-ac50-c4039391e19b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAIAAYagAAAAEN7ycSdvesxiNBcVIRMsMXCstH3es7AFWjhv50H/2YxkuBzjy9HE/8ZBLuu7aiV7mg==", null, false, "48c242c8-6043-4147-86ba-1f4b93baba93", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "411aa945-3b98-2231-7321-9870eb22d832", "408aa925-3b98-2231-7321-9870eb22d332" },
                    { "409aa945-3b98-2231-7321-9870eb22d922", "408aa945-3b98-2231-7321-9870eb22d909" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "411aa945-3b98-2231-7321-9870eb22d832", "408aa925-3b98-2231-7321-9870eb22d332" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "409aa945-3b98-2231-7321-9870eb22d922", "408aa945-3b98-2231-7321-9870eb22d909" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "409aa945-3b98-2231-7321-9870eb22d922");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "411aa945-3b98-2231-7321-9870eb22d832");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa925-3b98-2231-7321-9870eb22d332");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3b98-2231-7321-9870eb22d909");
        }
    }
}
