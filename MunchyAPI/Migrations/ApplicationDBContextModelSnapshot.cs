﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MunchyAPI.Data;

#nullable disable

namespace MunchyAPI.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MunchyAPI.Models.munch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Munches_API");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2025, 1, 24, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgUrl = "https://images.unsplash.com/photo-1612195610857-d20a1a4c38fb",
                            Location = "Downtown",
                            Name = "Truffle Risotto",
                            Price = 150,
                            Rating = 5,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2025, 1, 24, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgUrl = "https://images.unsplash.com/photo-1576659000105-f03f4533b30d",
                            Location = "City Center",
                            Name = "Lobster Bisque",
                            Price = 120,
                            Rating = 4,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2025, 1, 24, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgUrl = "https://images.unsplash.com/photo-1598939359644-c2c6f678ef45",
                            Location = "Uptown",
                            Name = "Wagyu Beef Steak",
                            Price = 200,
                            Rating = 5,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2025, 1, 24, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgUrl = "https://images.unsplash.com/photo-1511381242551-df92d18062b0",
                            Location = "Suburbs",
                            Name = "Duck Confit",
                            Price = 90,
                            Rating = 3,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2025, 1, 24, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            ImgUrl = "https://images.unsplash.com/photo-1565104283-5d78c063ac8a",
                            Location = "Midtown",
                            Name = "Sushi Platter",
                            Price = 130,
                            Rating = 4,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
