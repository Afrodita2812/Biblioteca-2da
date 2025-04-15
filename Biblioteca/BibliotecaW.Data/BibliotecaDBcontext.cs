using Microsoft.EntityFrameworkCore;
using Biblioteca.Data.Models; 

namespace Biblioteca.Data
{
    public class BibliotecaDbContext : DbContext
    {
       
        public BibliotecaDbContext(DbContextOptions<BibliotecaDbContext> options)
            : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        // DbSets
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Libros> Libros { get; set; }

        // Configuración de modelo
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                return;
            }
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<Libros>()
                .HasOne(l => l.Autor)
                .WithMany(a => a.Libros)
                .HasForeignKey(l => l.AutorId);
        }
    }
}
