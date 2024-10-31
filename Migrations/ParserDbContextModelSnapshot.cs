﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.Data.EF;

#nullable disable

namespace Project.Migrations
{
    [DbContext(typeof(ParserDbContext))]
    partial class ParserDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Project.Models.Parser.Discipline", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Coursework")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Score_mark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Score_no_mark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SpecialityId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SpecialityId");

                    b.ToTable("Disciplines", (string)null);
                });

            modelBuilder.Entity("Project.Models.Parser.Semester", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int?>("DisciplineId")
                        .HasColumnType("int");

                    b.Property<int?>("Number")
                        .HasColumnType("int");

                    b.Property<int?>("SelfStudyHours")
                        .HasColumnType("int");

                    b.Property<int?>("StudyHours")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DisciplineId");

                    b.ToTable("Semesters", (string)null);
                });

            modelBuilder.Entity("Project.Models.Parser.Speciality", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Specialities", (string)null);
                });

            modelBuilder.Entity("Project.Models.Parser.Discipline", b =>
                {
                    b.HasOne("Project.Models.Parser.Speciality", "Speciality")
                        .WithMany("Disciplines")
                        .HasForeignKey("SpecialityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Speciality");
                });

            modelBuilder.Entity("Project.Models.Parser.Semester", b =>
                {
                    b.HasOne("Project.Models.Parser.Discipline", "Discipline")
                        .WithMany("Semesters")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Discipline");
                });

            modelBuilder.Entity("Project.Models.Parser.Discipline", b =>
                {
                    b.Navigation("Semesters");
                });

            modelBuilder.Entity("Project.Models.Parser.Speciality", b =>
                {
                    b.Navigation("Disciplines");
                });
#pragma warning restore 612, 618
        }
    }
}
