﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WelcomeToTheZoo.API.Data;

#nullable disable

namespace WelcomeToTheZoo.API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220516071504_ZoosAnimalsUsers")]
    partial class ZoosAnimalsUsers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("WelcomeToTheZoo.API.Domain.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EatingHabit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Legs")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ZooId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ZooId");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("WelcomeToTheZoo.API.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WelcomeToTheZoo.API.Domain.Zoo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Acres")
                        .HasColumnType("REAL");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Zoos");
                });

            modelBuilder.Entity("WelcomeToTheZoo.API.Domain.Animal", b =>
                {
                    b.HasOne("WelcomeToTheZoo.API.Domain.Zoo", "Zoo")
                        .WithMany("Animals")
                        .HasForeignKey("ZooId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Zoo");
                });

            modelBuilder.Entity("WelcomeToTheZoo.API.Domain.Zoo", b =>
                {
                    b.Navigation("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}
