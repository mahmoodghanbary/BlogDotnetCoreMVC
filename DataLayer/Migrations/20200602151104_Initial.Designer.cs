﻿// <auto-generated />
using System;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(BlogDBContext))]
    [Migration("20200602151104_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DataLayer.Models.Page", b =>
                {
                    b.Property<int>("PageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PageID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<int>("GroupId")
                        .HasColumnName("GroupID")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .HasColumnType("varchar(250)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("varchar(450)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.Property<sbyte?>("ShowInSlider")
                        .HasColumnType("tinyint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.Property<int>("Visit")
                        .HasColumnType("int");

                    b.HasKey("PageId");

                    b.HasIndex("PageId")
                        .IsUnique()
                        .HasName("PageID_UNIQUE");

                    b.ToTable("Page");
                });

            modelBuilder.Entity("DataLayer.Models.PageComments", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CommentID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(250)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.Property<int?>("PageId")
                        .HasColumnName("PageID")
                        .HasColumnType("int");

                    b.Property<string>("WebSite")
                        .HasColumnType("varchar(255)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.HasKey("CommentId")
                        .HasName("PRIMARY");

                    b.ToTable("PageComments");
                });

            modelBuilder.Entity("DataLayer.Models.PageGroups", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PageTitle")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.HasKey("GroupId")
                        .HasName("PRIMARY");

                    b.HasIndex("GroupId")
                        .IsUnique()
                        .HasName("GroupId_UNIQUE");

                    b.ToTable("PageGroups");
                });
#pragma warning restore 612, 618
        }
    }
}