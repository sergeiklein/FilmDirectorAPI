using FilmDirectorAPI.Models;
using FilmDirectorAPI.Repository;
using FilmDirectorAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmDirectorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
        private readonly IFilmRepository filmrepository;

        public FilmsController(IFilmRepository filmrepository)
        {
            this.filmrepository = filmrepository;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Film>>> GetFilm()//recomended not to asysn Get song
        {
            return await filmrepository.GetAllAsync();
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<Film>> GetFilm(int id)
        {
            var film = await filmrepository.GetByIdAsync(id);

            if (film == null)
            {
                return NotFound();
            }

            return film;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Film>> PutFilm(int id, Film film)
        {
            if (id != film.Id)
            {
                return BadRequest();
            }

            film = await filmrepository.UpdateAsync(film);


            return Ok(film);
        }

        // POST: api/Songs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Film>> PostFilm(Film film)
        {
            film = await filmrepository.AddAsync(film);
            return Ok(film);
        }

        // DELETE: api/Songs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteFilmAsync(int id)
        {
            await filmrepository.DeleteAsync(id);

            return NoContent();
        }
    }
}
