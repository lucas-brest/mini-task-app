namespace backend.Model
{
    public class Grupo
    {
        public int Id { get; set; }
        public List<Usuario> Miembros { get; set; }
        public List<Tarea> Tareas { get; set; }
    }
}
