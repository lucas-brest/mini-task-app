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

        public List<Tarea> GetTareasByGrupoId(int grupoId)
        {
            try
            {
                return _context.Grupo.Find(grupoId).Tareas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString);
                return null;
            }
        }

        public List<Grupo> GetGruposByUsuario(Usuario usuario)
        {
            try
            {
                string username = usuario.Username;
                var grupos = _context.UsuarioDeGrupo
                    .Where(udg => udg.Usuario.Username == username)
                    .Select(udg => _context.Grupo.Find(udg.GrupoId));

                return grupos.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString);
                return null;
            }
        }

        public Usuario GetUsuarioByUsername(string username)
        {
            try
            {
                return _context.Usuario.Find(username);
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
                return _context.Usuario.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString);
                return null;
            }
        }
    }
}
