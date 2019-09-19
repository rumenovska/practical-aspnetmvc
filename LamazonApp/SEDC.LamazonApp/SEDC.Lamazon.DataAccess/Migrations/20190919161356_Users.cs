using Microsoft.EntityFrameworkCore.Migrations;

namespace SEDC.Lamazon.DataAccess.Migrations
{
    public partial class Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "64b5f16b-a189-466c-ac0d-d2e8458b04cd", "006a99b9-afef-4a70-8ba4-96b464463ae6", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aa08c475-3f44-41cf-9017-ad97f76e0002", "d8d085f5-9f44-483e-b663-dec7e70c0007", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b571cbab-9251-441f-8d84-6e209e7630ee", 0, "ea09a030-a155-47aa-8d79-80a99f130fe3", "supplier@mail.com", true, null, false, null, "supplier@mail.com", "SUPPLIER", "AQAAAAEAACcQAAAAEBgzR8ijyQB7F42Kxx8ZHMNeg7oTTXq++/T6/V9SDNwGvTsftE2e0RWnKcqAfPY6Vw==", null, false, "", false, "supplier" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "b571cbab-9251-441f-8d84-6e209e7630ee", "64b5f16b-a189-466c-ac0d-d2e8458b04cd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "aa08c475-3f44-41cf-9017-ad97f76e0002", "d8d085f5-9f44-483e-b663-dec7e70c0007" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b571cbab-9251-441f-8d84-6e209e7630ee", "64b5f16b-a189-466c-ac0d-d2e8458b04cd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "64b5f16b-a189-466c-ac0d-d2e8458b04cd", "006a99b9-afef-4a70-8ba4-96b464463ae6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b571cbab-9251-441f-8d84-6e209e7630ee", "ea09a030-a155-47aa-8d79-80a99f130fe3" });
        }
    }
}
