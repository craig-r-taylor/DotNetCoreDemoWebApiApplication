// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DotNetCoreDemoWebApiApplication.Data;

namespace DotNetCoreDemoWebApiApplication.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20211220215357_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<int>("AuthorsAuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BooksProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AuthorsAuthorId", "BooksProductId");

                    b.HasIndex("BooksProductId");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("PhdSolutionsDemoWebApiApplication.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleNames")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("AuthorId");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("PhdSolutionsDemoWebApiApplication.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("ClientId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("PhdSolutionsDemoWebApiApplication.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ShoppingCartId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("PhdSolutionsDemoWebApiApplication.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int?>("ShoppingCartId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("PhdSolutionsDemoWebApiApplication.Models.ShoppingCart", b =>
                {
                    b.Property<int>("ShoppingCartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClientId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ShoppingCartId");

                    b.HasIndex("ClientId");

                    b.ToTable("ShoppingCart");
                });

            modelBuilder.Entity("PhdSolutionsDemoWebApiApplication.Models.Book", b =>
                {
                    b.HasBaseType("PhdSolutionsDemoWebApiApplication.Models.Product");

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("PhdSolutionsDemoWebApiApplication.Models.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsAuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PhdSolutionsDemoWebApiApplication.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PhdSolutionsDemoWebApiApplication.Models.Product", b =>
                {
                    b.HasOne("PhdSolutionsDemoWebApiApplication.Models.ShoppingCart", null)
                        .WithMany("Products")
                        .HasForeignKey("ShoppingCartId");
                });

            modelBuilder.Entity("PhdSolutionsDemoWebApiApplication.Models.ShoppingCart", b =>
                {
                    b.HasOne("PhdSolutionsDemoWebApiApplication.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("PhdSolutionsDemoWebApiApplication.Models.Book", b =>
                {
                    b.HasOne("PhdSolutionsDemoWebApiApplication.Models.Product", null)
                        .WithOne()
                        .HasForeignKey("PhdSolutionsDemoWebApiApplication.Models.Book", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PhdSolutionsDemoWebApiApplication.Models.ShoppingCart", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
