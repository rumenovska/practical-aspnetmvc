using Microsoft.EntityFrameworkCore.Migrations;

namespace SEDC.Lamazon.DataAccess.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "720b8d2d-1276-4eb7-b091-60f60b4c3d46", "2783a7ba-9af1-49ec-9241-eb011002733d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d3eb0e4b-4aed-4633-8ec2-e6ee261981ba", "66e681a4-c0ea-4ce7-8922-e3ff6011b4cf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "66e681a4-c0ea-4ce7-8922-e3ff6011b4cf", "7055d712-eaf3-4033-b7fa-ee3c973984a1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "d3eb0e4b-4aed-4633-8ec2-e6ee261981ba", "9d363156-9dfc-4d6e-a831-66590723d091" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "542b2a7b-6c31-46cd-aaa2-f3962be4ad93", "f211ba5a-f16a-497a-abd6-15e805a5ff57", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00ad9fda-5dec-4007-9a3c-bb78e4a4a533", "9f454c19-5977-4ec3-827c-6bbf6712bc23", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ddc3adf5-2301-4727-ae32-16670c5e16cd", 0, "71d7c7b1-fa04-4a32-a0ea-ffb05296a13c", "supplier@mail.com", true, null, false, null, "supplier@mail.com", "SUPPLIER", "AQAAAAEAACcQAAAAEPK9JGbgiYkZ2eulhjdaP7V+tEuvE8w42nonMNelxTjnh5t2Wc1VOqxWtYj4Y1NdiQ==", null, false, "", false, "supplier" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "ddc3adf5-2301-4727-ae32-16670c5e16cd", "542b2a7b-6c31-46cd-aaa2-f3962be4ad93" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "00ad9fda-5dec-4007-9a3c-bb78e4a4a533", "9f454c19-5977-4ec3-827c-6bbf6712bc23" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ddc3adf5-2301-4727-ae32-16670c5e16cd", "542b2a7b-6c31-46cd-aaa2-f3962be4ad93" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "542b2a7b-6c31-46cd-aaa2-f3962be4ad93", "f211ba5a-f16a-497a-abd6-15e805a5ff57" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ddc3adf5-2301-4727-ae32-16670c5e16cd", "71d7c7b1-fa04-4a32-a0ea-ffb05296a13c" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "66e681a4-c0ea-4ce7-8922-e3ff6011b4cf", "7055d712-eaf3-4033-b7fa-ee3c973984a1", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "720b8d2d-1276-4eb7-b091-60f60b4c3d46", "2783a7ba-9af1-49ec-9241-eb011002733d", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d3eb0e4b-4aed-4633-8ec2-e6ee261981ba", 0, "9d363156-9dfc-4d6e-a831-66590723d091", "supplier@mail.com", true, null, false, null, "supplier@mail.com", "SUPPLIER", "AQAAAAEAACcQAAAAEOlMcXLiPV8NeNZPIasL5U6lQcvp/Gu3TMXRIgpXvJqz2YargHAvoR4Tkh/JEbqLOw==", null, false, "", false, "supplier" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "d3eb0e4b-4aed-4633-8ec2-e6ee261981ba", "66e681a4-c0ea-4ce7-8922-e3ff6011b4cf" });
        }
    }
}
