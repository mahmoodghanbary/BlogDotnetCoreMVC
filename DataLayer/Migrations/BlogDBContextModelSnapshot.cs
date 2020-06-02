﻿// <auto-generated />
using System;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(BlogDBContext))]
    partial class BlogDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DataLayer.Models.PageComments", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(150) CHARACTER SET utf8mb4")
                        .HasMaxLength(150);

                    b.Property<int>("PageID")
                        .HasColumnType("int");

                    b.Property<string>("WebSite")
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.HasKey("CommentID");

                    b.HasIndex("PageID");

                    b.ToTable("PageComments");
                });

            modelBuilder.Entity("DataLayer.Models.PageGroups", b =>
                {
                    b.Property<int>("GroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GroupTitle")
                        .IsRequired()
                        .HasColumnType("varchar(150) CHARACTER SET utf8mb4")
                        .HasMaxLength(150);

                    b.HasKey("GroupID");

                    b.ToTable("PageGroups");
                });

            modelBuilder.Entity("DataLayer.Models.Pages", b =>
                {
                    b.Property<int>("PageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("GroupID")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("PageGroupsGroupID")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("varchar(350) CHARACTER SET utf8mb4")
                        .HasMaxLength(350);

                    b.Property<bool>("ShowInSlider")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(250) CHARACTER SET utf8mb4")
                        .HasMaxLength(250);

                    b.Property<int>("Visit")
                        .HasColumnType("int");

                    b.HasKey("PageID");

                    b.HasIndex("PageGroupsGroupID");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("DataLayer.Models.PageComments", b =>
                {
                    b.HasOne("DataLayer.Models.Pages", "Page")
                        .WithMany("PageComments")
                        .HasForeignKey("PageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataLayer.Models.Pages", b =>
                {
                    b.HasOne("DataLayer.Models.PageGroups", "PageGroups")
                        .WithMany("Pages")
                        .HasForeignKey("PageGroupsGroupID");
                });
#pragma warning restore 612, 618
        }
    }
}
