using Microsoft.EntityFrameworkCore;

namespace backend.Model
{
    public class TaskDBContext : DbContext
    {
        public TaskDBContext(DbContextOptions<TaskDBContext> options) : base (options) { }

        public DbSet<Usuario> Usuarios { get; set;}
        public DbSet<Task> Tasks { get; set;}
        public DbSet<Grupo> Grupos { get; set;}
    }
}
