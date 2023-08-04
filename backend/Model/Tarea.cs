using System.ComponentModel.DataAnnotations;

namespace backend.Model
{
    public class Tarea
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Description { get; set; }
        public List<Usuario> Asignados { get; set; }
    }
}
