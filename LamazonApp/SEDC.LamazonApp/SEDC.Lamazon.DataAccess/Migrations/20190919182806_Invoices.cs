using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEDC.Lamazon.DataAccess.Migrations
{
    public partial class Invoices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "InvoiceId",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Invoises",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Payment = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoises_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Invoises_OrderId",
                table: "Invoises",
                column: "OrderId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoises");

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

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "Orders");

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
    }
}
