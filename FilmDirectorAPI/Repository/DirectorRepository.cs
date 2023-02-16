using FilmDirectorAPI.Context;
using FilmDirectorAPI.Models;
using FilmDirectorAPI.Repository.Interfaces;

namespace FilmDirectorAPI.Repository
{
    public class DirectorRepository : Repository<Director>, IDirectorRepository // TEntity in Repository class is replaced with Director Model
    {
        public DirectorRepository(MovieContext dBcontext) : base(dBcontext)
        {

        }
    }
}
