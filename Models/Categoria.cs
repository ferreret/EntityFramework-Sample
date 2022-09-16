using System.ComponentModel.DataAnnotations;

namespace projectef.Models
{
    public class Categoria
    {
        // No utilizo atributos, utilizo Fluent API

        // [Key]
        public Guid CategoriaId { get; set; }

        // [Required]
        // [MaxLength(150)]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        public virtual ICollection<Tarea> Tareas { get; set; }
    }
}