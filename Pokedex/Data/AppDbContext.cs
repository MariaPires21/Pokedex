using Microsoft.EntityFrameworkCore;
using Pokedex.Models;

namespace Pokedex.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Genero> Generos { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonTipo> PokemonTipos { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Regiao> Regioes { get; set; }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PokemonTipo>()
                .HasKey(pt => new { pt.PokemonNumero, pt.TipoId });
        }
    }


}