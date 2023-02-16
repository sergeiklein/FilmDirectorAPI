using FilmDirectorAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FilmDirectorAPI.Context // set this up first
{
    public class MovieContext : DbContext //setting up Database context child class
    {
        public DbSet<Film> Films { get; set; } //make sure the name is plural
        public DbSet<Director> Directors { get; set; }//These classes are going to be the context of the database

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=MovieData;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)// this will be seed data for the database
        {
            modelBuilder.Entity<Director>().HasData(
                new Director { Id = 1, FirstName = "Steven", LastName = "Spielberg", Age = 76, Oscars = 3, },
                new Director { Id = 2, FirstName = "James", LastName = "Cameron", Age = 68, Oscars = 3, },
                new Director { Id = 3, FirstName = "Peter", LastName = "Jackson", Age = 61, Oscars = 3},
                new Director { Id = 4, FirstName = "Quentin", LastName = "Tarantino", Age = 59, Oscars = 2 },
                new Director { Id = 5, FirstName = "Jon", LastName = "Favreu", Age = 56, Oscars = 0},
                new Director { Id = 6, FirstName = "Tim", LastName = "Burton", Age = 64, Oscars = 8},
                new Director { Id = 7, FirstName = "Christopher", LastName = "Nolan", Age = 52, Oscars = 0});

            modelBuilder.Entity<Film>().HasData(
                new Film { Id = 1, FilmName = "Schindler's List", FilmLength = 130, FilmYear = 1975, DirectorId = 1,MoneyEarned = "322.2 million USD" },
                new Film { Id = 2, FilmName = "Saving Private Ryan", FilmLength = 127, FilmYear = 1993, DirectorId = 1, MoneyEarned = "481.8 million USD" },
                new Film { Id = 3, FilmName = "Titanic", FilmLength = 196, FilmYear = 1997, DirectorId = 2, MoneyEarned = "2.216 billion USD" },
                new Film { Id = 4, FilmName = "Avatar", FilmLength = 162, FilmYear = 2009, DirectorId = 2, MoneyEarned = "2.923 billion USD" },
                new Film { Id = 5, FilmName = "Fellowship of the Rings", FilmLength = 178, FilmYear = 2001, DirectorId = 3, MoneyEarned = "898.2 million USD" },
                new Film { Id = 6, FilmName = "King Kong", FilmLength = 201, FilmYear = 2005, DirectorId = 3, MoneyEarned = "562.1 million USD" },
                new Film { Id = 7, FilmName = "Pulp Fiction", FilmLength = 154, FilmYear = 1994, DirectorId = 4, MoneyEarned = "213.9 million USD" },
                new Film { Id = 8, FilmName = "Once Upon a Time in Hollywood", FilmLength = 159, FilmYear = 2019, DirectorId = 4, MoneyEarned = "377.4 million USD" },
                new Film { Id = 9, FilmName = "Iron Man", FilmLength = 126, FilmYear = 2008, DirectorId = 5, MoneyEarned = "585.8 million USD" },
                new Film { Id = 10, FilmName = "Elf", FilmLength = 97, FilmYear = 2003, DirectorId = 5, MoneyEarned = "225.11 million USD" },
                new Film { Id = 11, FilmName = "Sleepy Hollow", FilmLength = 105, FilmYear = 1999, DirectorId = 6, MoneyEarned = "207 million USD" },
                new Film { Id = 12, FilmName = "Batman", FilmLength = 126, FilmYear = 1989, DirectorId = 6, MoneyEarned = "411.6 million USD" },
                new Film { Id = 13, FilmName = "Interstellar", FilmLength = 152, FilmYear = 2014, DirectorId = 7, MoneyEarned = "701.7 million USD" },
                new Film { Id = 14, FilmName = "Inseption", FilmLength = 148, FilmYear = 2012, DirectorId = 7, MoneyEarned = "836.8 million USD" });
        }
    }
}
