using Microsoft.EntityFrameworkCore;

namespace front_back.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Alimento> Alimentos { get; set; }

    }
}
