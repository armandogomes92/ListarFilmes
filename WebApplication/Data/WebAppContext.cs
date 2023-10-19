using Microsoft.EntityFrameworkCore;
using WebApplication.Interfaces;
using WebApplication.Model;

namespace WebApplication.Data
{
    public class WebAppContext : DbContext
    {
        public WebAppContext(DbContextOptions<WebAppContext> opt) : base(opt)
        {
            
        }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Genero>()
                .HasMany(genero => genero.Filme)
                .WithOne(filme => filme.Genero)
                .HasForeignKey(filme => filme.GeneroId);
        }

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Genero> Generos { get; set; }
    }
}
