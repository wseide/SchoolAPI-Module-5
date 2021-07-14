﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SchoolAPI.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.AssignmentManagement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AssignmentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AssignmentTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CourseSectionID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseSectionID");

                    b.ToTable("Assignments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479816"),
                            AssignmentTitle = "Module 1",
                            CourseID = "IS690",
                            CourseSectionID = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479814"),
                            Description = "Create a website that can receive user input"
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479830"),
                            AssignmentTitle = "Module 1",
                            CourseID = "IS601",
                            CourseSectionID = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479815"),
                            Description = "Create a website that can receive user input"
                        });
                });

            modelBuilder.Entity("Entities.Models.CourseManagement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CourseManagementID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CourseTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479812"),
                            CourseTitle = "Web Services and Middleware",
                            CreatedDate = new DateTime(2021, 7, 13, 18, 19, 26, 874, DateTimeKind.Local).AddTicks(9882),
                            Description = "Web services enable integration of web-based applications and feature sets to any other web-based system in a modular way. Middleware is a set of functionality positioned in between and enabling interoperability among different, distributed enterprise and other computing applications. This course provides an introduction to web services and middleware in the context of digital libraries - large scale multimedia information repositories. Students will gain hands on experience in developing their own web services managing a complex distributed computing platform.",
                            UpdatedDate = new DateTime(2021, 7, 13, 18, 19, 26, 875, DateTimeKind.Local).AddTicks(558)
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                            CourseTitle = "Web Systems Development",
                            CreatedDate = new DateTime(2021, 7, 13, 18, 19, 26, 875, DateTimeKind.Local).AddTicks(1201),
                            Description = "Students will gain experience in open source web development through an intensive hands-on project, applying real-world problem-solving skills to meeting information systems requirements. Students will learn Web development principles, as well as professionally relevant skills including industry standards, conventions, and procedures within large-scale programming projects. Also covered are the communication tools, technologies, and practices that individuals use to coordinate and collaborate within the open source software development community.",
                            UpdatedDate = new DateTime(2021, 7, 13, 18, 19, 26, 875, DateTimeKind.Local).AddTicks(1230)
                        });
                });

            modelBuilder.Entity("Entities.Models.CourseSectionManagement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CourseSectionID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CourseID")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CourseSections");

                    b.HasData(
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479814"),
                            CourseID = "IS690",
                            CreatedDate = new DateTime(2021, 7, 13, 18, 19, 26, 879, DateTimeKind.Local).AddTicks(5549),
                            EndDate = new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2021, 7, 13, 18, 19, 26, 879, DateTimeKind.Local).AddTicks(6087)
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479815"),
                            CourseID = "IS601",
                            CreatedDate = new DateTime(2021, 7, 13, 18, 19, 26, 879, DateTimeKind.Local).AddTicks(6815),
                            EndDate = new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2021, 7, 13, 18, 19, 26, 879, DateTimeKind.Local).AddTicks(6843)
                        });
                });

            modelBuilder.Entity("Entities.Models.SectionEnrollmentManagement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SectionEnrollmentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SectionID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("SectionEnrollment");

                    b.HasData(
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479820"),
                            CreatedDate = new DateTime(2021, 7, 13, 18, 19, 26, 881, DateTimeKind.Local).AddTicks(4370),
                            EndDate = new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SectionID = "IS690-001",
                            StartDate = new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2021, 7, 13, 18, 19, 26, 881, DateTimeKind.Local).AddTicks(4823),
                            UserID = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                            UserName = "awash"
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479821"),
                            CreatedDate = new DateTime(2021, 7, 13, 18, 19, 26, 881, DateTimeKind.Local).AddTicks(6255),
                            EndDate = new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SectionID = "IS601-001",
                            StartDate = new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedDate = new DateTime(2021, 7, 13, 18, 19, 26, 881, DateTimeKind.Local).AddTicks(6285),
                            UserID = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                            UserName = "thupchick"
                        });
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SectionEnrollmentManagementId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("SystemRoleID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("SectionEnrollmentManagementId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                            CreatedDate = new DateTime(2021, 7, 13, 18, 19, 26, 880, DateTimeKind.Local).AddTicks(5269),
                            Email = "ajw53@njit.edu",
                            Status = true,
                            SystemRoleID = "student",
                            UpdatedDate = new DateTime(2021, 7, 13, 18, 19, 26, 880, DateTimeKind.Local).AddTicks(5762),
                            UserName = "awash"
                        },
                        new
                        {
                            Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                            CreatedDate = new DateTime(2021, 7, 13, 18, 19, 26, 880, DateTimeKind.Local).AddTicks(6290),
                            Email = "tjhupchick24@njit.edu",
                            Status = false,
                            SystemRoleID = "student",
                            UpdatedDate = new DateTime(2021, 7, 13, 18, 19, 26, 880, DateTimeKind.Local).AddTicks(6319),
                            UserName = "thupchick"
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            CreatedDate = new DateTime(2021, 7, 13, 18, 19, 26, 880, DateTimeKind.Local).AddTicks(6339),
                            Email = "keith.a.williams@njit.edu",
                            Status = true,
                            SystemRoleID = "profesor",
                            UpdatedDate = new DateTime(2021, 7, 13, 18, 19, 26, 880, DateTimeKind.Local).AddTicks(6344),
                            UserName = "kwilliams"
                        });
                });

            modelBuilder.Entity("Entities.Models.AssignmentManagement", b =>
                {
                    b.HasOne("Entities.Models.CourseSectionManagement", "CourseSectionManagement")
                        .WithMany()
                        .HasForeignKey("CourseSectionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.SectionEnrollmentManagement", b =>
                {
                    b.HasOne("Entities.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.HasOne("Entities.Models.SectionEnrollmentManagement", null)
                        .WithMany("Users")
                        .HasForeignKey("SectionEnrollmentManagementId");
                });
#pragma warning restore 612, 618
        }
    }
}
