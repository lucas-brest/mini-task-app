using System.ComponentModel.DataAnnotations;

namespace backend.Model
{
    public class Grupo
    {
        [Key]
        public int Id { get; set; }
        public List<Usuario> Miembros { get; set; }
        public List<Tarea> Tareas { get; set; }
    }
}
