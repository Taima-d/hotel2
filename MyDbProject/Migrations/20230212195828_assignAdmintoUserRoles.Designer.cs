﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyDbProject;

namespace MyDbProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230212195828_assignAdmintoUserRoles")]
    partial class assignAdmintoUserRoles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("Roles", "security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", "security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", "security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", "security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", "security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", "security");
                });

            modelBuilder.Entity("My_Tables.Entities.BillEntity", b =>
                {
                    b.Property<int>("BillEntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerEntityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("pdfFile")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BillEntityId");

                    b.HasIndex("CustomerEntityId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("My_Tables.Entities.BookingEntity", b =>
                {
                    b.Property<int>("BookingEntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BillEntityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<string>("Reviews")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("RoomEntityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("checkIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("checkOut")
                        .HasColumnType("datetime2");

                    b.HasKey("BookingEntityId");

                    b.HasIndex("BillEntityId");

                    b.HasIndex("RoomEntityId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("My_Tables.Entities.Booking_ExtraEntity", b =>
                {
                    b.Property<int>("Booking_ExtraEntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookingEntityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Hotel_ExtraEntityId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Booking_ExtraEntityId");

                    b.HasIndex("BookingEntityId");

                    b.HasIndex("Hotel_ExtraEntityId");

                    b.ToTable("Booking_Extras");
                });

            modelBuilder.Entity("My_Tables.Entities.CustomerEntity", b =>
                {
                    b.Property<int>("CustomerEntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<byte[]>("Identity_Certificate")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserEntityId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("gender")
                        .HasColumnType("int");

                    b.Property<int>("phoneNumber")
                        .HasColumnType("int");

                    b.HasKey("CustomerEntityId");

                    b.HasIndex("UserEntityId")
                        .IsUnique();

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("My_Tables.Entities.Extra_ServicesEntity", b =>
                {
                    b.Property<int>("Extra_ServicesEntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Extra_ServicesName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("Extra_ServicesPicture")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Extra_ServicesEntityId");

                    b.ToTable("Extra_Services");
                });

            modelBuilder.Entity("My_Tables.Entities.HotelEntity", b =>
                {
                    b.Property<int>("HotelEntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("City")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("HotelAddress")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("HotelName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("HotelPicture")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("IdentityCertifcate")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ManagerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManegerPhone")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("Phone1")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("Phone2")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("UserEntityId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("numOfStars")
                        .HasColumnType("int");

                    b.HasKey("HotelEntityId");

                    b.HasIndex("UserEntityId")
                        .IsUnique()
                        .HasFilter("[UserEntityId] IS NOT NULL");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("My_Tables.Entities.Hotel_ExtraEntity", b =>
                {
                    b.Property<int>("Hotel_ExtraEntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Extra_ServiceEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Extra_ServicesEntityId")
                        .HasColumnType("int");

                    b.Property<int>("HotelEntityId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Hotel_ExtraEntityId");

                    b.HasIndex("Extra_ServicesEntityId");

                    b.HasIndex("HotelEntityId");

                    b.ToTable("Hotel_Extras");
                });

            modelBuilder.Entity("My_Tables.Entities.RoomEntity", b =>
                {
                    b.Property<int>("RoomEntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("HotelEntityId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("RoomDirection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomNum")
                        .HasColumnType("int");

                    b.Property<byte[]>("RoomPicture")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("RoomSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numOfBeds")
                        .HasColumnType("int");

                    b.Property<int?>("numOfRoom")
                        .HasColumnType("int");

                    b.Property<int>("phone")
                        .HasColumnType("int");

                    b.Property<bool>("suite")
                        .HasColumnType("bit");

                    b.HasKey("RoomEntityId");

                    b.HasIndex("HotelEntityId");

                    b.ToTable("RoomEntities");
                });

            modelBuilder.Entity("My_Tables.Entities.UserEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
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

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", "security");
                });

            modelBuilder.Entity("My_Tables.Entities.WebsiteEntity", b =>
                {
                    b.Property<int>("WebsiteEntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("WebsiteImage")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("WebsiteEntityId");

                    b.ToTable("WebsiteEntities");
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
                    b.HasOne("My_Tables.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("My_Tables.Entities.UserEntity", null)
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

                    b.HasOne("My_Tables.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("My_Tables.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("My_Tables.Entities.BillEntity", b =>
                {
                    b.HasOne("My_Tables.Entities.CustomerEntity", "CustomerEntity")
                        .WithMany("BillEntities")
                        .HasForeignKey("CustomerEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerEntity");
                });

            modelBuilder.Entity("My_Tables.Entities.BookingEntity", b =>
                {
                    b.HasOne("My_Tables.Entities.BillEntity", "BillEntity")
                        .WithMany("BookingEntities")
                        .HasForeignKey("BillEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("My_Tables.Entities.RoomEntity", "RoomEntity")
                        .WithMany("BookingEntities")
                        .HasForeignKey("RoomEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BillEntity");

                    b.Navigation("RoomEntity");
                });

            modelBuilder.Entity("My_Tables.Entities.Booking_ExtraEntity", b =>
                {
                    b.HasOne("My_Tables.Entities.BookingEntity", "BookingEntity")
                        .WithMany("Booking_ExtraEntities")
                        .HasForeignKey("BookingEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("My_Tables.Entities.Hotel_ExtraEntity", "Hotel_ExtraEntity")
                        .WithMany("Booking_ExtraEntities")
                        .HasForeignKey("Hotel_ExtraEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookingEntity");

                    b.Navigation("Hotel_ExtraEntity");
                });

            modelBuilder.Entity("My_Tables.Entities.CustomerEntity", b =>
                {
                    b.HasOne("My_Tables.Entities.UserEntity", "UserEntity")
                        .WithOne("CustomerEntity")
                        .HasForeignKey("My_Tables.Entities.CustomerEntity", "UserEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserEntity");
                });

            modelBuilder.Entity("My_Tables.Entities.HotelEntity", b =>
                {
                    b.HasOne("My_Tables.Entities.UserEntity", "UserEntity")
                        .WithOne("HotelEntity")
                        .HasForeignKey("My_Tables.Entities.HotelEntity", "UserEntityId");

                    b.Navigation("UserEntity");
                });

            modelBuilder.Entity("My_Tables.Entities.Hotel_ExtraEntity", b =>
                {
                    b.HasOne("My_Tables.Entities.Extra_ServicesEntity", "Extra_ServicesEntity")
                        .WithMany("Hotel_ExtraEntities")
                        .HasForeignKey("Extra_ServicesEntityId");

                    b.HasOne("My_Tables.Entities.HotelEntity", "HotelEntity")
                        .WithMany("Hotel_ExtraEntities")
                        .HasForeignKey("HotelEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Extra_ServicesEntity");

                    b.Navigation("HotelEntity");
                });

            modelBuilder.Entity("My_Tables.Entities.RoomEntity", b =>
                {
                    b.HasOne("My_Tables.Entities.HotelEntity", "HotelEntity")
                        .WithMany("RoomEntities")
                        .HasForeignKey("HotelEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HotelEntity");
                });

            modelBuilder.Entity("My_Tables.Entities.BillEntity", b =>
                {
                    b.Navigation("BookingEntities");
                });

            modelBuilder.Entity("My_Tables.Entities.BookingEntity", b =>
                {
                    b.Navigation("Booking_ExtraEntities");
                });

            modelBuilder.Entity("My_Tables.Entities.CustomerEntity", b =>
                {
                    b.Navigation("BillEntities");
                });

            modelBuilder.Entity("My_Tables.Entities.Extra_ServicesEntity", b =>
                {
                    b.Navigation("Hotel_ExtraEntities");
                });

            modelBuilder.Entity("My_Tables.Entities.HotelEntity", b =>
                {
                    b.Navigation("Hotel_ExtraEntities");

                    b.Navigation("RoomEntities");
                });

            modelBuilder.Entity("My_Tables.Entities.Hotel_ExtraEntity", b =>
                {
                    b.Navigation("Booking_ExtraEntities");
                });

            modelBuilder.Entity("My_Tables.Entities.RoomEntity", b =>
                {
                    b.Navigation("BookingEntities");
                });

            modelBuilder.Entity("My_Tables.Entities.UserEntity", b =>
                {
                    b.Navigation("CustomerEntity");

                    b.Navigation("HotelEntity");
                });
#pragma warning restore 612, 618
        }
    }
}
