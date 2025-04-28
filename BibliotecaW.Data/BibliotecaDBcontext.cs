using BibliotecaW.Data;
using Biblioteca.Data.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace BibliotecaW.Data
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

        public DbSet<LibroAutor> LibroAutor { get; set; }


        // Configuración de modelo
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                return;
            }
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Autor>().ToTable("Autor").HasKey(x => x.Id);
            
              modelBuilder.Entity<LibroAutor>()
        .HasKey(la => new { la.LibroId, la.AutorId });

    modelBuilder.Entity<LibroAutor>()
        .HasOne(la => la.Libro)
        .WithMany(l => l.LibroAutors)  
        .HasForeignKey(la => la.LibroId);

    modelBuilder.Entity<LibroAutor>()
        .HasOne(la => la.Autor)
        .WithMany(a => a.LibroAutors) 
        .HasForeignKey(la => la.AutorId);
        }
    }
}

