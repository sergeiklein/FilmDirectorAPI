﻿// <auto-generated />
using FilmDirectorAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FilmDirectorAPI.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FilmDirectorAPI.Models.Director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Oscars")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Directors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 76,
                            FirstName = "Steven",
                            LastName = "Spielberg",
                            Oscars = 3
                        },
                        new
                        {
                            Id = 2,
                            Age = 68,
                            FirstName = "James",
                            LastName = "Cameron",
                            Oscars = 3
                        },
                        new
                        {
                            Id = 3,
                            Age = 61,
                            FirstName = "Peter",
                            LastName = "Jackson",
                            Oscars = 3
                        },
                        new
                        {
                            Id = 4,
                            Age = 59,
                            FirstName = "Quentin",
                            LastName = "Tarantino",
                            Oscars = 2
                        },
                        new
                        {
                            Id = 5,
                            Age = 56,
                            FirstName = "Jon",
                            LastName = "Favreu",
                            Oscars = 0
                        },
                        new
                        {
                            Id = 6,
                            Age = 64,
                            FirstName = "Tim",
                            LastName = "Burton",
                            Oscars = 8
                        },
                        new
                        {
                            Id = 7,
                            Age = 52,
                            FirstName = "Christopher",
                            LastName = "Nolan",
                            Oscars = 0
                        });
                });

            modelBuilder.Entity("FilmDirectorAPI.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DirectorId")
                        .HasColumnType("int");

                    b.Property<int>("FilmLength")
                        .HasColumnType("int");

                    b.Property<string>("FilmName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("FilmYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DirectorId");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DirectorId = 1,
                            FilmLength = 130,
                            FilmName = "Schindler's List",
                            FilmYear = 1975
                        },
                        new
                        {
                            Id = 2,
                            DirectorId = 1,
                            FilmLength = 127,
                            FilmName = "Saving Private Ryan",
                            FilmYear = 1993
                        },
                        new
                        {
                            Id = 3,
                            DirectorId = 2,
                            FilmLength = 196,
                            FilmName = "Titanic",
                            FilmYear = 1997
                        },
                        new
                        {
                            Id = 4,
                            DirectorId = 2,
                            FilmLength = 162,
                            FilmName = "Avatar",
                            FilmYear = 2009
                        },
                        new
                        {
                            Id = 5,
                            DirectorId = 3,
                            FilmLength = 178,
                            FilmName = "Fellowship of the Rings",
                            FilmYear = 2001
                        },
                        new
                        {
                            Id = 6,
                            DirectorId = 3,
                            FilmLength = 201,
                            FilmName = "King Kong",
                            FilmYear = 2005
                        },
                        new
                        {
                            Id = 7,
                            DirectorId = 4,
                            FilmLength = 154,
                            FilmName = "Pulp Fiction",
                            FilmYear = 1994
                        },
                        new
                        {
                            Id = 8,
                            DirectorId = 4,
                            FilmLength = 159,
                            FilmName = "Once Upon a Time in Hollywood",
                            FilmYear = 2019
                        },
                        new
                        {
                            Id = 9,
                            DirectorId = 5,
                            FilmLength = 126,
                            FilmName = "Iron Man",
                            FilmYear = 2008
                        },
                        new
                        {
                            Id = 10,
                            DirectorId = 5,
                            FilmLength = 97,
                            FilmName = "Elf",
                            FilmYear = 2003
                        },
                        new
                        {
                            Id = 11,
                            DirectorId = 6,
                            FilmLength = 105,
                            FilmName = "Sleepy Hollow",
                            FilmYear = 1999
                        },
                        new
                        {
                            Id = 12,
                            DirectorId = 6,
                            FilmLength = 126,
                            FilmName = "Batman",
                            FilmYear = 1989
                        },
                        new
                        {
                            Id = 13,
                            DirectorId = 7,
                            FilmLength = 152,
                            FilmName = "Interstellar",
                            FilmYear = 2014
                        },
                        new
                        {
                            Id = 14,
                            DirectorId = 7,
                            FilmLength = 148,
                            FilmName = "Inseption",
                            FilmYear = 2012
                        });
                });

            modelBuilder.Entity("FilmDirectorAPI.Models.Film", b =>
                {
                    b.HasOne("FilmDirectorAPI.Models.Director", "Director")
                        .WithMany("Films")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Director");
                });

            modelBuilder.Entity("FilmDirectorAPI.Models.Director", b =>
                {
                    b.Navigation("Films");
                });
#pragma warning restore 612, 618
        }
    }
}