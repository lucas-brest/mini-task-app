using System.ComponentModel.DataAnnotations;

namespace backend.Model
{
    public class Grupo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public List<Tarea> Tareas { get; set; }
    }
}
