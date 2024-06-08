﻿// <auto-generated />
using HireMePortalSubmitter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HireMePortalSubmitter.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240608193533_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HireMePortalSubmitter.Models.Career", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ExperienceRange")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Careers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExperienceRange = "2-4 years",
                            JobCode = "DEV001",
                            JobDetails = "Develop and maintain web applications.",
                            Location = "New York",
                            Name = "Developer"
                        },
                        new
                        {
                            Id = 2,
                            ExperienceRange = "3-5 years",
                            JobCode = "DES001",
                            JobDetails = "Design user interfaces and graphics.",
                            Location = "Los Angeles",
                            Name = "Designer"
                        },
                        new
                        {
                            Id = 3,
                            ExperienceRange = "1-3 years",
                            JobCode = "TES001",
                            JobDetails = "Test software applications for bugs.",
                            Location = "Chicago",
                            Name = "Tester"
                        },
                        new
                        {
                            Id = 4,
                            ExperienceRange = "5-7 years",
                            JobCode = "MAN001",
                            JobDetails = "Manage project teams and deliverables.",
                            Location = "San Francisco",
                            Name = "Manager"
                        },
                        new
                        {
                            Id = 5,
                            ExperienceRange = "2-4 years",
                            JobCode = "SUP001",
                            JobDetails = "Provide technical support to clients.",
                            Location = "Miami",
                            Name = "Support"
                        });
                });

            modelBuilder.Entity("HireMePortalSubmitter.Models.CareerApply", b =>
                {
                    b.Property<int>("CareerApplyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CareerApplyId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YearofExperinace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CareerApplyId");

                    b.ToTable("CareerApply");
                });
#pragma warning restore 612, 618
        }
    }
}
