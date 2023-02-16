using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmDirectorAPI.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }//-----------------------------------------------------------------------------this will be the unique ID to identify artist
        [Required]//----------------------------------------------------------------------------------------------film name will be a requirement
        [StringLength(100)]//-------------------------------------------------------------------------------------film name character limit
        public string FilmName { get; set; } = null!;//-----------------------------------------------------------tthat this will never be null(empty)
        public int FilmLength { get; set; }
        public int FilmYear { get; set; }
        public string MoneyEarned { get; set; }//-----------------------------------------------------------------added last

        [ForeignKey("Director")]//--------------------------------------------------------------------------------this is a constregnt so the server has to find id for the director
        public int DirectorId { get; set; }//---------------------------------------------------------------------this will link film to the director hopefully
        public virtual Director Director { get; set; } = null;//--------------------------------------------------this will be virtual refrence to the director. like a placeholder
    }
}
