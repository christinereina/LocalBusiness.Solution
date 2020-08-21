﻿// <auto-generated />
using LocalBusiness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalBusiness.Migrations
{
    [DbContext(typeof(LocalBusinessContext))]
    [Migration("20200821170330_Initial")]
    partial class Initial
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

                    b.Property<int>("Hours");

                    b.Property<string>("Name");

                    b.Property<string>("Rating");

                    b.Property<string>("ServicesOffered");

                    b.Property<string>("Type");

                    b.HasKey("BusinessId");

                    b.ToTable("Businesses");
                });
#pragma warning restore 612, 618
        }
    }
}
