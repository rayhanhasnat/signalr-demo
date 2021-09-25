﻿// <auto-generated />
using AvengersMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AvengersMVC.Migrations
{
    [DbContext(typeof(AvengersContext))]
    partial class AvengersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("AvengersMVC.Models.Avenger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CanFly")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("RealName")
                        .HasColumnType("TEXT");

                    b.Property<string>("SuperheroName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Weapons")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Avengers");
                });
#pragma warning restore 612, 618
        }
    }
}
