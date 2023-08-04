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

        public bool AddUpdateGrupo(Grupo grupo)
        {
            try
            {
                if (_context.Grupo.ToList().IndexOf(grupo) == -1)
                {
                    _context.Grupo.Add(grupo);
                }
                else
                {
                    _context.Grupo.Update(grupo);
                }
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString);
                return false;
            }
        }

        public bool AddUpdateUsuario(Usuario usuario)
        {
            try
            {
                if (_context.Usuario.ToList().IndexOf(usuario) == -1)
                {
                    _context.Usuario.Add(usuario);
                }
                else
                {
                    _context.Usuario.Update(usuario);
                }
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString);
                return false;
            }
        }

        public bool AddUpdateTarea(Tarea tarea)
        {
            try
            {
                if(_context.Tarea.ToList().IndexOf(tarea) == -1)
                {
                    _context.Tarea.Add(tarea);
                } 
                else
                {
                    _context.Tarea.Update(tarea);
                }
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString);
                return false;
            }
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
