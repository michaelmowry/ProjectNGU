﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ProjectNGU.Models;
using System;

namespace ProjectNGU.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180307203100_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectNGU.Model.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("State");

                    b.Property<string>("StreetAddressLine1");

                    b.Property<string>("StreetAddressLine2");

                    b.Property<string>("ZipCode");

                    b.HasKey("AddressId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("ProjectNGU.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("FormerLegalLastName");

                    b.Property<string>("Gender");

                    b.Property<string>("LegalFirstName");

                    b.Property<string>("LegalLastName");

                    b.Property<string>("LegalMiddleName");

                    b.Property<int?>("MailingAddressAddressId");

                    b.Property<string>("PreferredFirstName");

                    b.Property<int?>("ResidentialAddressAddressId");

                    b.HasKey("UserId");

                    b.HasIndex("MailingAddressAddressId");

                    b.HasIndex("ResidentialAddressAddressId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ProjectNGU.Model.User", b =>
                {
                    b.HasOne("ProjectNGU.Model.Address", "MailingAddress")
                        .WithMany()
                        .HasForeignKey("MailingAddressAddressId");

                    b.HasOne("ProjectNGU.Model.Address", "ResidentialAddress")
                        .WithMany()
                        .HasForeignKey("ResidentialAddressAddressId");
                });
#pragma warning restore 612, 618
        }
    }
}