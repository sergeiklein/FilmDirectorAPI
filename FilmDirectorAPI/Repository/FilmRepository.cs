using FilmDirectorAPI.Context;
using FilmDirectorAPI.Models;
using FilmDirectorAPI.Repository.Interfaces;

namespace FilmDirectorAPI.Repository
{
    public class FilmRepository : Repository<Film>,IFilmRepository   // TEntity in Repository class is replaced with Film Data Model
    {
        public FilmRepository(MovieContext dBcontext):base(dBcontext)
        {

        }
    }
}
