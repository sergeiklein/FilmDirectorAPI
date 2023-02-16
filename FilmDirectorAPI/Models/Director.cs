using System.ComponentModel.DataAnnotations;

namespace FilmDirectorAPI.Models
{
    public class Director
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = null!;
        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = null!;
        public int Age { get; set; }
        public int Oscars { get; set; }
        public virtual ICollection<Film> Films { get; set; } = null!;
    }
}
