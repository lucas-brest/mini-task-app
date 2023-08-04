using Microsoft.EntityFrameworkCore;

namespace backend.Model
{
    public class TaskDBContext : DbContext
    {
        public TaskDBContext(DbContextOptions<TaskDBContext> options) : base (options) { }

        public DbSet<Usuario> Usuario { get; set;}
        public DbSet<Tarea> Tarea { get; set;}
        public DbSet<Grupo> Grupo { get; set;}
        public DbSet<UsuarioDeGrupo> UsuarioDeGrupo { get; set;}
    }
}
