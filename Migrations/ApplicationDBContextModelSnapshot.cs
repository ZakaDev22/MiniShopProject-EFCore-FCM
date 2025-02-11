﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniShopProject_EFCore_FCM.Data;

#nullable disable

namespace MiniShopProject_EFCore_FCM.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MiniShopProject_EFCore_FCM.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Customers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "zaka"
                        },
                        new
                        {
                            Id = 2,
                            Name = "koko"
                        },
                        new
                        {
                            Id = 3,
                            Name = "zika"
                        },
                        new
                        {
                            Id = 4,
                            Name = "sss"
                        },
                        new
                        {
                            Id = 5,
                            Name = "aaa"
                        });
                });

            modelBuilder.Entity("MiniShopProject_EFCore_FCM.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.ToTable("Orders", (string)null);

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            Amount = 22m,
                            CustomerId = 1
                        },
                        new
                        {
                            OrderId = 2,
                            Amount = 23m,
                            CustomerId = 1
                        },
                        new
                        {
                            OrderId = 3,
                            Amount = 500m,
                            CustomerId = 2
                        },
                        new
                        {
                            OrderId = 4,
                            Amount = 1400m,
                            CustomerId = 5
                        },
                        new
                        {
                            OrderId = 5,
                            Amount = 420m,
                            CustomerId = 3
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
