using Microsoft.EntityFrameworkCore;

namespace adrianorecode.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options):base(options) 
        {

        }

       
        public DbSet<Clientes> clientes { get; set; }
    }
}
