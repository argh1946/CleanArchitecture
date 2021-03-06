// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampleProject.Infrastructure.Data;

namespace SampleProject.Infrastructure.Migrations
{
    [DbContext(typeof(SampleProjectDbContext))]
    [Migration("20200404170551_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SampleProject.Core.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Awesome",
                            EndDate = new DateTime(2020, 4, 9, 21, 35, 50, 183, DateTimeKind.Local).AddTicks(5505),
                            Name = "c#",
                            StartDate = new DateTime(2020, 4, 4, 21, 35, 50, 165, DateTimeKind.Local).AddTicks(2659)
                        },
                        new
                        {
                            Id = 2,
                            Description = "WOW",
                            EndDate = new DateTime(2020, 4, 9, 21, 35, 50, 183, DateTimeKind.Local).AddTicks(7779),
                            Name = "JavaScript",
                            StartDate = new DateTime(2020, 4, 4, 21, 35, 50, 183, DateTimeKind.Local).AddTicks(7676)
                        });
                });

            modelBuilder.Entity("SampleProject.Core.Entities.RegisteredCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("RegisteredCourses");
                });

            modelBuilder.Entity("SampleProject.Core.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "John",
                            LastName = "Cena"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Alex",
                            LastName = "Morgan"
                        });
                });

            modelBuilder.Entity("SampleProject.Core.Entities.RegisteredCourse", b =>
                {
                    b.HasOne("SampleProject.Core.Entities.Student", null)
                        .WithMany("RegisteredCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
