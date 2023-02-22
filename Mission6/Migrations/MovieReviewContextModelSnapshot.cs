﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission7.Models;

namespace Mission7.Migrations
{
    [DbContext(typeof(MovieReviewContext))]
    partial class MovieReviewContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Mission7.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("MovieReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

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

                    b.Property<ushort>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieReviewID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieReviewID = 1,
                            CategoryID = 1,
                            Director = "Kenny Ortega",
                            Edited = false,
                            LentTo = "NA",
                            Notes = "NA",
                            Rating = "G",
                            Title = "High School Musical",
                            Year = (ushort)2006
                        },
                        new
                        {
                            MovieReviewID = 2,
                            CategoryID = 1,
                            Director = "Kenny Ortega",
                            Edited = true,
                            LentTo = "NA",
                            Notes = "NA",
                            Rating = "G",
                            Title = "High School Musical 2",
                            Year = (ushort)2007
                        },
                        new
                        {
                            MovieReviewID = 3,
                            CategoryID = 1,
                            Director = "Kenny Ortega",
                            Edited = false,
                            LentTo = "NA",
                            Notes = "NA",
                            Rating = "G",
                            Title = "High School Musical 3: Senior Year",
                            Year = (ushort)2008
                        });
                });

            modelBuilder.Entity("Mission7.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Musical"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Action"
                        });
                });

            modelBuilder.Entity("Mission7.Models.ApplicationResponse", b =>
                {
                    b.HasOne("Mission7.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}