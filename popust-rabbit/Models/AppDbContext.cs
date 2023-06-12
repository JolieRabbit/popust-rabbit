using Microsoft.EntityFrameworkCore;

namespace popust_rabbit.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public object Usuarios { get; internal set; }
    }
}
