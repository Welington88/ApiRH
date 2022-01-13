using Microsoft.EntityFrameworkCore;
using apiRH.Models;

namespace apiRH.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Setor> Setor { get; set; }
        public DbSet<Colaborador> Colaborador { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasKey( u => new { u.IdUsuario } );
        }

    }
}
