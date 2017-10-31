﻿// <auto-generated />
using DTL.MRA.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DTL.MRA.Data.Migrations
{
    [DbContext(typeof(MraDbContext))]
    [Migration("20171030220426_initialmigration")]
    partial class initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("DTL.MRA.Data.Domains.Customer", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DTL.MRA.Data.Domains.Meter", b =>
                {
                    b.Property<Guid>("MeterId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CustomerId");

                    b.Property<string>("Icp");

                    b.Property<string>("Provider");

                    b.Property<string>("SerialId");

                    b.HasKey("MeterId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Meters");
                });

            modelBuilder.Entity("DTL.MRA.Data.Domains.MeterRead", b =>
                {
                    b.Property<Guid>("MeterReadId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("MeterId");

                    b.Property<string>("MeterNumber");

                    b.Property<int>("Provider");

                    b.Property<int>("Reading");

                    b.Property<int>("ReadingTime");

                    b.HasKey("MeterReadId");

                    b.HasIndex("MeterId");

                    b.ToTable("MeterReads");
                });

            modelBuilder.Entity("DTL.MRA.Data.Domains.Meter", b =>
                {
                    b.HasOne("DTL.MRA.Data.Domains.Customer", "Customer")
                        .WithMany("Meters")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("DTL.MRA.Data.Domains.MeterRead", b =>
                {
                    b.HasOne("DTL.MRA.Data.Domains.Meter", "Meter")
                        .WithMany("MeterReads")
                        .HasForeignKey("MeterId");
                });
#pragma warning restore 612, 618
        }
    }
}
