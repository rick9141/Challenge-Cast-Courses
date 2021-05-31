﻿// <auto-generated />
using System;
using CastCourses.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CastCourses.Infra.Data.Migrations
{
    [DbContext(typeof(ContextBase))]
    [Migration("20210531194152_MigrationV4")]
    partial class MigrationV4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CastCourses.Domain.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<int>("NumberOfStudentsPerClass")
                        .HasColumnType("int")
                        .HasColumnName("num_students_slass");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_start");

                    b.Property<DateTime>("Termination")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_end");

                    b.Property<int>("TypeCategory")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.HasKey("Id");

                    b.ToTable("courses");
                });
#pragma warning restore 612, 618
        }
    }
}