namespace backend.Model
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Description { get; set; }
        public List<Usuario> Asignados { get; set; }
    }
}
