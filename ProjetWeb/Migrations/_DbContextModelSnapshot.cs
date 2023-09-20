﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetWeb.Models;

#nullable disable

namespace ProjetWeb.Migrations
{
    [DbContext(typeof(_DbContext))]
    partial class _DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.Property<string>("NormalizedName")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.HasKey("Id");

                b.HasIndex("NormalizedName")
                    .IsUnique()
                    .HasDatabaseName("RoleNameIndex")
                    .HasFilter("[NormalizedName] IS NOT NULL");

                b.ToTable("AspNetRoles", (string)null);
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                b.Property<string>("ClaimType")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ClaimValue")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("RoleId")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.HasKey("Id");

                b.HasIndex("RoleId");

                b.ToTable("AspNetRoleClaims", (string)null);
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                b.Property<string>("ClaimType")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ClaimValue")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("UserId")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.ToTable("AspNetUserClaims", (string)null);
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
            {
                b.Property<string>("LoginProvider")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("ProviderKey")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("ProviderDisplayName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("UserId")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.HasKey("LoginProvider", "ProviderKey");

                b.HasIndex("UserId");

                b.ToTable("AspNetUserLogins", (string)null);
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
            {
                b.Property<string>("UserId")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("RoleId")
                    .HasColumnType("nvarchar(450)");

                b.HasKey("UserId", "RoleId");

                b.HasIndex("RoleId");

                b.ToTable("AspNetUserRoles", (string)null);
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
            {
                b.Property<string>("UserId")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("LoginProvider")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("Value")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("UserId", "LoginProvider", "Name");

                b.ToTable("AspNetUserTokens", (string)null);
            });

            modelBuilder.Entity("ProjetWeb.Models.Order", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                b.Property<bool>("Accepted")
                    .HasColumnType("bit");

                b.Property<string>("Comment")
                    .HasMaxLength(1000)
                    .HasColumnType("nvarchar(1000)");

                b.Property<string>("Content")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<string>("CustomerId")
                    .HasColumnType("nvarchar(450)");

                b.Property<bool>("Delivered")
                    .HasColumnType("bit");

                b.Property<string>("Destination")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("DriverId")
                    .HasColumnType("nvarchar(450)");

                b.Property<DateTime>("EndDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Source")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("StartDate")
                    .HasColumnType("datetime2");

                b.Property<int?>("TruckId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("CustomerId");

                b.HasIndex("DriverId");

                b.HasIndex("TruckId");

                b.ToTable("Orders");

                b.HasData(
                    new
                    {
                        Id = 50,
                        Accepted = false,
                        Content = "20 tonnes de poisson",
                        Delivered = false,
                        Destination = "rue de Take my Money, 77 4128 Anvers",
                        EndDate = new DateTime(2024, 1, 5, 12, 0, 0, 0, DateTimeKind.Unspecified),
                        Source = "rue de Croix, 100 4047 Ans",
                        StartDate = new DateTime(2023, 1, 5, 12, 0, 0, 0, DateTimeKind.Unspecified)
                    },
                    new
                    {
                        Id = 51,
                        Accepted = false,
                        Content = "un chat",
                        Delivered = false,
                        Destination = "rue de Nuit, 29 4233 Mons",
                        EndDate = new DateTime(2024, 2, 6, 13, 10, 0, 0, DateTimeKind.Unspecified),
                        Source = "rue de Croix, 94 4648 Charleroi",
                        StartDate = new DateTime(2023, 2, 6, 13, 10, 0, 0, DateTimeKind.Unspecified)
                    },
                    new
                    {
                        Id = 52,
                        Accepted = false,
                        Content = "10 tonnes de bois",
                        Delivered = false,
                        Destination = "rue de Take my Money, 112 4545 Ans",
                        EndDate = new DateTime(2024, 3, 7, 14, 20, 0, 0, DateTimeKind.Unspecified),
                        Source = "rue de Pegasuslaan, 107 4204 Ans",
                        StartDate = new DateTime(2023, 3, 7, 14, 20, 0, 0, DateTimeKind.Unspecified)
                    },
                    new
                    {
                        Id = 53,
                        Accepted = false,
                        Content = "des tables et chaises pour helmo",
                        Delivered = false,
                        Destination = "rue de Kleetlaan, 120 4023 Anvers",
                        EndDate = new DateTime(2024, 4, 8, 15, 30, 0, 0, DateTimeKind.Unspecified),
                        Source = "rue de Pegasuslaan, 106 4576 Ans",
                        StartDate = new DateTime(2023, 4, 8, 15, 30, 0, 0, DateTimeKind.Unspecified)
                    },
                    new
                    {
                        Id = 54,
                        Accepted = false,
                        Content = "une bombe nucléaire",
                        Delivered = false,
                        Destination = "rue de Nuit, 41 4476 Anvers",
                        EndDate = new DateTime(2024, 5, 9, 16, 40, 0, 0, DateTimeKind.Unspecified),
                        Source = "rue de Pegasuslaan, 121 4602 Liège",
                        StartDate = new DateTime(2023, 5, 9, 16, 40, 0, 0, DateTimeKind.Unspecified)
                    },
                    new
                    {
                        Id = 55,
                        Accepted = false,
                        Content = "20 tonnes de poisson",
                        Delivered = false,
                        Destination = "rue de Help, 10 4370 Ans",
                        EndDate = new DateTime(2024, 6, 10, 17, 50, 0, 0, DateTimeKind.Unspecified),
                        Source = "rue de Take my Money, 44 4096 Mons",
                        StartDate = new DateTime(2023, 6, 10, 17, 50, 0, 0, DateTimeKind.Unspecified)
                    },
                    new
                    {
                        Id = 56,
                        Accepted = false,
                        Content = "un chat",
                        Delivered = false,
                        Destination = "rue de Pegasuslaan, 92 4046 Charleroi",
                        EndDate = new DateTime(2024, 7, 11, 18, 0, 0, 0, DateTimeKind.Unspecified),
                        Source = "rue de Croix, 90 4216 Charleroi",
                        StartDate = new DateTime(2023, 7, 11, 18, 0, 0, 0, DateTimeKind.Unspecified)
                    },
                    new
                    {
                        Id = 57,
                        Accepted = false,
                        Content = "10 tonnes de bois",
                        Delivered = false,
                        Destination = "rue de Pegasuslaan, 31 4100 Liège",
                        EndDate = new DateTime(2024, 8, 12, 19, 10, 0, 0, DateTimeKind.Unspecified),
                        Source = "rue de Take my Money, 87 4127 Anvers",
                        StartDate = new DateTime(2023, 8, 12, 19, 10, 0, 0, DateTimeKind.Unspecified)
                    },
                    new
                    {
                        Id = 58,
                        Accepted = false,
                        Content = "des tables et chaises pour helmo",
                        Delivered = false,
                        Destination = "rue de Croix, 52 4663 Anvers",
                        EndDate = new DateTime(2024, 9, 13, 20, 20, 0, 0, DateTimeKind.Unspecified),
                        Source = "rue de Pegasuslaan, 103 4149 Charleroi",
                        StartDate = new DateTime(2023, 9, 13, 20, 20, 0, 0, DateTimeKind.Unspecified)
                    },
                    new
                    {
                        Id = 59,
                        Accepted = false,
                        Content = "une bombe nucléaire",
                        Delivered = false,
                        Destination = "rue de Help, 70 4160 Ans",
                        EndDate = new DateTime(2024, 10, 14, 21, 30, 0, 0, DateTimeKind.Unspecified),
                        Source = "rue de Kleetlaan, 122 4454 Charleroi",
                        StartDate = new DateTime(2023, 10, 14, 21, 30, 0, 0, DateTimeKind.Unspecified)
                    });
            });

            modelBuilder.Entity("ProjetWeb.Models.Truck", b =>
            {
                b.Property<int?>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                b.Property<string>("Brand")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<int>("MaxWeight")
                    .HasColumnType("int");

                b.Property<string>("Model")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<string>("Plate")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<string>("Types")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.HasKey("Id");

                b.ToTable("Trucks");

                b.HasData(
                    new
                    {
                        Id = 1,
                        Brand = "Iveco",
                        MaxWeight = 3200,
                        Model = "Eurocargo",
                        Plate = "1-VUP-133",
                        Types = "C"
                    },
                    new
                    {
                        Id = 2,
                        Brand = "Iveco",
                        MaxWeight = 2300,
                        Model = "Eurocargo",
                        Plate = "1-EZR-398",
                        Types = "CE"
                    },
                    new
                    {
                        Id = 3,
                        Brand = "Iveco",
                        MaxWeight = 2900,
                        Model = "Eurocargo",
                        Plate = "1-XCL-540",
                        Types = "C"
                    },
                    new
                    {
                        Id = 4,
                        Brand = "Iveco",
                        MaxWeight = 7100,
                        Model = "Eurocargo",
                        Plate = "1-DLC-389",
                        Types = "CE"
                    },
                    new
                    {
                        Id = 5,
                        Brand = "Iveco",
                        MaxWeight = 4900,
                        Model = "Eurocargo",
                        Plate = "1-ZBL-440",
                        Types = "C"
                    },
                    new
                    {
                        Id = 6,
                        Brand = "Iveco",
                        MaxWeight = 1800,
                        Model = "Eurocargo",
                        Plate = "1-OUS-280",
                        Types = "C"
                    },
                    new
                    {
                        Id = 7,
                        Brand = "Iveco",
                        MaxWeight = 7400,
                        Model = "Eurocargo",
                        Plate = "1-JLL-654",
                        Types = "CE"
                    },
                    new
                    {
                        Id = 8,
                        Brand = "Iveco",
                        MaxWeight = 5600,
                        Model = "Eurocargo",
                        Plate = "1-FQT-207",
                        Types = "C"
                    },
                    new
                    {
                        Id = 9,
                        Brand = "Iveco",
                        MaxWeight = 3600,
                        Model = "Eurocargo",
                        Plate = "1-RGF-842",
                        Types = "C"
                    },
                    new
                    {
                        Id = 10,
                        Brand = "Iveco",
                        MaxWeight = 1100,
                        Model = "Eurocargo",
                        Plate = "1-JQX-842",
                        Types = "CE"
                    });
            });

            modelBuilder.Entity("ProjetWeb.Models.User", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("nvarchar(450)");

                b.Property<int>("AccessFailedCount")
                    .HasColumnType("int");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Discriminator")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Email")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.Property<bool>("EmailConfirmed")
                    .HasColumnType("bit");

                b.Property<bool>("LockoutEnabled")
                    .HasColumnType("bit");

                b.Property<DateTimeOffset?>("LockoutEnd")
                    .HasColumnType("datetimeoffset");

                b.Property<string>("Matricule")
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<string>("NormalizedEmail")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.Property<string>("NormalizedUserName")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.Property<string>("PasswordHash")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("PhoneNumber")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("PhoneNumberConfirmed")
                    .HasColumnType("bit");

                b.Property<string>("SecurityStamp")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("TwoFactorEnabled")
                    .HasColumnType("bit");

                b.Property<string>("UserName")
                    .HasMaxLength(256)
                    .HasColumnType("nvarchar(256)");

                b.HasKey("Id");

                b.HasIndex("NormalizedEmail")
                    .HasDatabaseName("EmailIndex");

                b.HasIndex("NormalizedUserName")
                    .IsUnique()
                    .HasDatabaseName("UserNameIndex")
                    .HasFilter("[NormalizedUserName] IS NOT NULL");

                b.ToTable("AspNetUsers", (string)null);

                b.HasDiscriminator<string>("Discriminator").HasValue("User");
            });

            modelBuilder.Entity("ProjetWeb.Models.Admin", b =>
            {
                b.HasBaseType("ProjetWeb.Models.User");

                b.HasDiscriminator().HasValue("Admin");
            });

            modelBuilder.Entity("ProjetWeb.Models.Customer", b =>
            {
                b.HasBaseType("ProjetWeb.Models.User");

                b.Property<string>("Address")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("BadPayer")
                    .HasColumnType("bit");

                b.HasDiscriminator().HasValue("Customer");
            });

            modelBuilder.Entity("ProjetWeb.Models.Dispatcher", b =>
            {
                b.HasBaseType("ProjetWeb.Models.User");

                b.Property<string>("StudyLvl")
                    .HasColumnType("nvarchar(max)");

                b.HasDiscriminator().HasValue("Dispatcher");
            });

            modelBuilder.Entity("ProjetWeb.Models.Driver", b =>
            {
                b.HasBaseType("ProjetWeb.Models.User");

                b.Property<string>("License")
                    .HasColumnType("nvarchar(max)");

                b.HasDiscriminator().HasValue("Driver");
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
            {
                b.HasOne("ProjetWeb.Models.User", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
            {
                b.HasOne("ProjetWeb.Models.User", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
            {
                b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("ProjetWeb.Models.User", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
            {
                b.HasOne("ProjetWeb.Models.User", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("ProjetWeb.Models.Order", b =>
            {
                b.HasOne("ProjetWeb.Models.Customer", "Customer")
                    .WithMany("Orders")
                    .HasForeignKey("CustomerId");

                b.HasOne("ProjetWeb.Models.Driver", "Driver")
                    .WithMany("Orders")
                    .HasForeignKey("DriverId");

                b.HasOne("ProjetWeb.Models.Truck", "Truck")
                    .WithMany("Orders")
                    .HasForeignKey("TruckId");

                b.Navigation("Customer");

                b.Navigation("Driver");

                b.Navigation("Truck");
            });

            modelBuilder.Entity("ProjetWeb.Models.Truck", b =>
            {
                b.Navigation("Orders");
            });

            modelBuilder.Entity("ProjetWeb.Models.Customer", b =>
            {
                b.Navigation("Orders");
            });

            modelBuilder.Entity("ProjetWeb.Models.Driver", b =>
            {
                b.Navigation("Orders");
            });
#pragma warning restore 612, 618
        }
    }
}
