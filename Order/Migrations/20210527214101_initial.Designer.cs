﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ordermicroservice.Database;

namespace ordermicroservice.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20210527214101_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ordermicroservice.Model.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OccuredAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("PriceAtPointInTime")
                        .HasColumnType("float");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderID = 1,
                            OccuredAt = new DateTime(2021, 5, 28, 3, 11, 0, 999, DateTimeKind.Local).AddTicks(8937),
                            PriceAtPointInTime = 10000.0,
                            ProductID = 1,
                            Quantity = 1.0,
                            Total = 10000.0,
                            UserID = 1
                        },
                        new
                        {
                            OrderID = 2,
                            OccuredAt = new DateTime(2021, 5, 28, 3, 11, 1, 1, DateTimeKind.Local).AddTicks(1852),
                            PriceAtPointInTime = 20000.0,
                            ProductID = 2,
                            Quantity = 1.0,
                            Total = 20000.0,
                            UserID = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
