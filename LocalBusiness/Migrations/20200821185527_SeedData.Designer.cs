﻿// <auto-generated />
using LocalBusiness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalBusiness.Migrations
{
    [DbContext(typeof(LocalBusinessContext))]
    [Migration("20200821185527_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LocalBusiness.Models.Business", b =>
                {
                    b.Property<int>("BusinessId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Hours");

                    b.Property<string>("Name");

                    b.Property<string>("Rating");

                    b.Property<string>("ServicesOffered");

                    b.Property<string>("Type");

                    b.HasKey("BusinessId");

                    b.ToTable("Businesses");

                    b.HasData(
                        new
                        {
                            BusinessId = 1,
                            Address = "1234 Camphor St.",
                            Hours = "10 AM - 5 PM",
                            Name = "Totoro's Seeds & Trees",
                            Rating = "5",
                            ServicesOffered = "Planting Services",
                            Type = "Nursery"
                        },
                        new
                        {
                            BusinessId = 2,
                            Address = "44 Jiji Rd",
                            Hours = "7 AM - 12 PM",
                            Name = "Kiki's Delivery Service",
                            Rating = "5",
                            ServicesOffered = "Broomstick Delivery, Cleaning Service",
                            Type = "Delivery"
                        },
                        new
                        {
                            BusinessId = 3,
                            Address = "7853 Sen Lane",
                            Hours = "24/7",
                            Name = "Yubaba's BathHouse",
                            Rating = "2",
                            ServicesOffered = "Spirit Relaxation, Cleaning and Luxury Pampering",
                            Type = "Bathhouse"
                        },
                        new
                        {
                            BusinessId = 4,
                            Address = "Seaside Cliff",
                            Hours = "6 AM - 10 PM",
                            Name = "Ponyo & Sōsuke Boat Rental",
                            Rating = "5",
                            ServicesOffered = "Boat Rental, Boat Repair",
                            Type = "Boating"
                        },
                        new
                        {
                            BusinessId = 5,
                            Address = "",
                            Hours = "6757 Gina Lane",
                            Name = "Hotel Adriano",
                            Rating = "4",
                            ServicesOffered = "Nightly Accommodations",
                            Type = "Hotel"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}