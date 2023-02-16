using FilmDirectorAPI.Models;
using FilmDirectorAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmDirectorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private readonly IDirectorRepository directorrepository;

        public DirectorController(IDirectorRepository directorrepository)
        {
            this.directorrepository = directorrepository;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Director>>> GetDirector()
        {
            return await directorrepository.GetAllAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Director>> GetDirector(int id)
        {
            var director = await directorrepository.GetByIdAsync(id);

            if (director == null)
            {
                return NotFound();
            }

            return director;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Director>> PutDirector(int id, Director director)
        {
            if (id != director.Id)
            {
                return BadRequest();
            }

            director = await directorrepository.UpdateAsync(director);


            return Ok(director);
        }

        [HttpPost]
        public async Task<ActionResult<Director>> PostDirector(Director director)
        {
            director = await directorrepository.AddAsync(director);
            return Ok(director);
        }

        
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteDirectorAsync(int id)
        {
            await directorrepository.DeleteAsync(id);

            return NoContent();
        }
    }
}
