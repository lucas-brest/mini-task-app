using backend.Model;

namespace backend.Services
{
    public class TaskService
    {
        private readonly TaskDBContext _context;

        public TaskService(TaskDBContext context)
        {
            _context = context;
        }

        public Usuario GetUsuarioByUsername(string username)
        {
            try
            {
                return _context.Usuarios.Find(username);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString);
                return null;
            }
        }

        public List<Usuario> GetAllUsuarios()
        {
            try
            {
                return _context.Usuarios.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString);
                return null;
            }
        }
    }
}
