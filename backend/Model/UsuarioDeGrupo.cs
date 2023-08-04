using System.ComponentModel.DataAnnotations;

namespace backend.Model
{
    public class UsuarioDeGrupo
    {
        [Key]
        public int Id { get; set; }
        public string UsuarioUsername { get; set; }
        public int GrupoId { get; set; }

        public Usuario? Usuario { get; set; }
        public Grupo? Grupo { get; set; }
        
    }
}
