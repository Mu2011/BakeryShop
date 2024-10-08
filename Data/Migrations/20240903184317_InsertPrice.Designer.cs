﻿// <auto-generated />
using BakeryShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BakeryShop.Data.Migrations
{
    [DbContext(typeof(BakeryShopContext))]
    [Migration("20240903184317_InsertPrice")]
    partial class InsertPrice
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("BakeryShop.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("IamgeName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("IamgeFileName");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Carrot Cake Any Description",
                            IamgeName = "carrot_cake.webp",
                            Name = "Carrot Cake",
                            Price = 15m
                        },
                        new
                        {
                            ID = 2,
                            Description = "Lemo Tart Any Description",
                            IamgeName = "lemo_tart.webp",
                            Name = "Lemo Tart",
                            Price = 0m
                        },
                        new
                        {
                            ID = 4,
                            Description = "Mutech Cake Any Description",
                            IamgeName = "carrot_cake.webp",
                            Name = "Mutech Cake",
                            Price = 50m
                        },
                        new
                        {
                            ID = 3,
                            Description = "Cup Cake Any Description",
                            IamgeName = "cup_cake.webp",
                            Name = "Cup Cake",
                            Price = 20m
                        },
                        new
                        {
                            ID = 5,
                            Description = "bread Any Description",
                            IamgeName = "bread.webp",
                            Name = "bread",
                            Price = 10m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
