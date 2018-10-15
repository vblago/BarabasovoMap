﻿// <auto-generated />
using System;
using BarabasovoMap.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BarabasovoMap.Database.Migrations
{
    [DbContext(typeof(BarabasovoDbContext))]
    [Migration("20181015215831_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BarabasovoMap.Database.Models.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("BarabasovoMap.Database.Models.Owner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("Info");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("BarabasovoMap.Database.Models.Point", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("LocationId");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Points");
                });

            modelBuilder.Entity("BarabasovoMap.Database.Models.Property", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Info");

                    b.Property<Guid>("OwnerId");

                    b.Property<Guid>("PointId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("PointId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("BarabasovoMap.Database.Models.Seller", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("Info");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.Property<Guid>("PointId");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("PointId");

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("BarabasovoMap.Database.Models.Point", b =>
                {
                    b.HasOne("BarabasovoMap.Database.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BarabasovoMap.Database.Models.Property", b =>
                {
                    b.HasOne("BarabasovoMap.Database.Models.Owner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BarabasovoMap.Database.Models.Point", "Point")
                        .WithMany()
                        .HasForeignKey("PointId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BarabasovoMap.Database.Models.Seller", b =>
                {
                    b.HasOne("BarabasovoMap.Database.Models.Point", "Point")
                        .WithMany("Sellers")
                        .HasForeignKey("PointId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
