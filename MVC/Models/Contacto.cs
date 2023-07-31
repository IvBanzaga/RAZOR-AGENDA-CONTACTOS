using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Actividad_2_ASP.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Apellido1 { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Apellido2 { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Email { get; set; }

    
        public DateTime FechaCreacion { get; set; }

    }
}
