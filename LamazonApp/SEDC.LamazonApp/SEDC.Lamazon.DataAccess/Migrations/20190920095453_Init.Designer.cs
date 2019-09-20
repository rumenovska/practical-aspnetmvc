﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SEDC.Lamazon.DataAccess;

namespace SEDC.Lamazon.DataAccess.Migrations
{
    [DbContext(typeof(LamazonDbContext))]
    [Migration("20190920095453_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new { Id = "542b2a7b-6c31-46cd-aaa2-f3962be4ad93", ConcurrencyStamp = "f211ba5a-f16a-497a-abd6-15e805a5ff57", Name = "admin", NormalizedName = "ADMIN" },
                        new { Id = "00ad9fda-5dec-4007-9a3c-bb78e4a4a533", ConcurrencyStamp = "9f454c19-5977-4ec3-827c-6bbf6712bc23", Name = "user", NormalizedName = "USER" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new { UserId = "ddc3adf5-2301-4727-ae32-16670c5e16cd", RoleId = "542b2a7b-6c31-46cd-aaa2-f3962be4ad93" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int>("OrderId");

                    b.Property<int>("Payment");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("Invoises");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfOrder");

                    b.Property<string>("InvoiceId");

                    b.Property<int>("Status");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Category");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = 1, Category = 2, Description = "Very good phone. Bad batery", Name = "Samsung A40", Price = 200.0 },
                        new { Id = 2, Category = 2, Description = "Large SSD of high quality", Name = "SSD 1TB", Price = 400.0 },
                        new { Id = 3, Category = 3, Description = "C# Book for everyone", Name = "C# in depth", Price = 40.0 },
                        new { Id = 4, Category = 3, Description = "Book for clean code", Name = "Clean Code", Price = 60.0 },
                        new { Id = 5, Category = 1, Description = "Magical Elixir of Power", Name = "Rakija", Price = 20.0 },
                        new { Id = 6, Category = 1, Description = "When you have too much Rakija", Name = "Sparkling Water", Price = 2.0 },
                        new { Id = 7, Category = 0, Description = "All in one pack of appetizers", Name = "Meze", Price = 15.0 },
                        new { Id = 8, Category = 0, Description = "Stew for good morning", Name = "Stew in a can", Price = 8.0 },
                        new { Id = 9, Category = 4, Description = "Set of 6 glasses", Name = "Glasses set", Price = 10.0 },
                        new { Id = 10, Category = 4, Description = "Set of 20 plastic knives and forks", Name = "Plastic knives and forks", Price = 4.0 },
                        new { Id = 11, Category = 4, Description = "A bag of ice", Name = "Ice", Price = 3.0 },
                        new { Id = 12, Category = 4, Description = "Plates for the whole family", Name = "Plastic plates", Price = 5.0 }
                    );
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Models.ProductOrder", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<int>("OrderId");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("ProductId", "OrderId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("ProductOrders");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new { Id = "ddc3adf5-2301-4727-ae32-16670c5e16cd", AccessFailedCount = 0, ConcurrencyStamp = "71d7c7b1-fa04-4a32-a0ea-ffb05296a13c", Email = "supplier@mail.com", EmailConfirmed = true, LockoutEnabled = false, NormalizedEmail = "supplier@mail.com", NormalizedUserName = "SUPPLIER", PasswordHash = "AQAAAAEAACcQAAAAEPK9JGbgiYkZ2eulhjdaP7V+tEuvE8w42nonMNelxTjnh5t2Wc1VOqxWtYj4Y1NdiQ==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "supplier" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SEDC.Lamazon.Domain.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SEDC.Lamazon.Domain.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SEDC.Lamazon.Domain.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SEDC.Lamazon.Domain.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Models.Invoice", b =>
                {
                    b.HasOne("SEDC.Lamazon.Domain.Models.Order", "Order")
                        .WithOne("Invoice")
                        .HasForeignKey("SEDC.Lamazon.Domain.Models.Invoice", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Models.Order", b =>
                {
                    b.HasOne("SEDC.Lamazon.Domain.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Models.ProductOrder", b =>
                {
                    b.HasOne("SEDC.Lamazon.Domain.Models.Order", "Order")
                        .WithMany("ProductOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SEDC.Lamazon.Domain.Models.Product", "Product")
                        .WithMany("ProductOrders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
