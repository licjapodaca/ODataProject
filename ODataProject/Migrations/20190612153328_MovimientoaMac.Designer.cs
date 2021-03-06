﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ODataProject.Context;

namespace ODataProject.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20190612153328_MovimientoaMac")]
    partial class MovimientoaMac
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ODataProject.Models.School", b =>
                {
                    b.Property<Guid>("SchoolId")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("SchoolId");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("ODataProject.Models.Student", b =>
                {
                    b.Property<Guid>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<Guid>("SchoolId");

                    b.Property<int>("Score");

                    b.HasKey("StudentId");

                    b.HasIndex("SchoolId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ODataProject.Models.Student", b =>
                {
                    b.HasOne("ODataProject.Models.School", "School")
                        .WithMany("Students")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
