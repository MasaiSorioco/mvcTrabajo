using Microsoft.EntityFrameworkCore;
using Trabajo.Models;

namespace Trabajo.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        {
        }
        //Aqui todos los modelos que se creen 
        public DbSet<Producto> Producto { get; set; }

    }
}
