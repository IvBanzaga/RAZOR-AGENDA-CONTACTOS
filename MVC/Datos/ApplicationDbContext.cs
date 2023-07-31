using Actividad_2_ASP.Models;
using Microsoft.EntityFrameworkCore;

namespace Actividad_2_ASP.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        
        }

        // Agregamos los Metodos

        public DbSet<Contacto> Contacto { get; set; }
    }
}