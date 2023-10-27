using Microsoft.EntityFrameworkCore;
using GerenciadorDeFilmes.Interfaces;
using GerenciadorDeFilmes.Model;

namespace GerenciadorDeFilmes.Data
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
