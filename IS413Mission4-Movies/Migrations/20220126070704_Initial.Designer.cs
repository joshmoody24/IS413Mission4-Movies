﻿// <auto-generated />
using IS413Mission4_Movies.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IS413Mission4_Movies.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20220126070704_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("IS413Mission4_Movies.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MovieId");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Meme",
                            Director = "Andrew Adamson",
                            Edited = false,
                            Rating = "PG",
                            Title = "Shrek"
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Idk",
                            Director = "Steve Binder",
                            Edited = true,
                            Notes = "Really good movie",
                            Rating = "PG",
                            Title = "Star Wars Holiday Special"
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Action",
                            Director = "Himself",
                            Edited = false,
                            LentTo = "Fred",
                            Notes = "Do not watch under any circumstances",
                            Rating = "R",
                            Title = "Big Chungus"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
