﻿// <auto-generated />
using System;
using BlazorFilmCatalogCourse.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorFilmCatalogCourse.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210304144042_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazorFilmCatalogCourse.Shared.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OnBillboard")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trailer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("BlazorFilmCatalogCourse.Shared.Models.FilmActor", b =>
                {
                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<string>("Character")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("PersonId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("FilmActors");
                });

            modelBuilder.Entity("BlazorFilmCatalogCourse.Shared.Models.FilmGenre", b =>
                {
                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.HasKey("GenreId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("FilmGenres");
                });

            modelBuilder.Entity("BlazorFilmCatalogCourse.Shared.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("BlazorFilmCatalogCourse.Shared.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biography")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("BlazorFilmCatalogCourse.Shared.Models.FilmActor", b =>
                {
                    b.HasOne("BlazorFilmCatalogCourse.Shared.Models.Film", "Film")
                        .WithMany("FilmActors")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorFilmCatalogCourse.Shared.Models.Person", "Person")
                        .WithMany("FilmActors")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("BlazorFilmCatalogCourse.Shared.Models.FilmGenre", b =>
                {
                    b.HasOne("BlazorFilmCatalogCourse.Shared.Models.Film", "Film")
                        .WithMany("FilmGenres")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorFilmCatalogCourse.Shared.Models.Genre", "Genre")
                        .WithMany("filmGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("BlazorFilmCatalogCourse.Shared.Models.Film", b =>
                {
                    b.Navigation("FilmActors");

                    b.Navigation("FilmGenres");
                });

            modelBuilder.Entity("BlazorFilmCatalogCourse.Shared.Models.Genre", b =>
                {
                    b.Navigation("filmGenres");
                });

            modelBuilder.Entity("BlazorFilmCatalogCourse.Shared.Models.Person", b =>
                {
                    b.Navigation("FilmActors");
                });
#pragma warning restore 612, 618
        }
    }
}
