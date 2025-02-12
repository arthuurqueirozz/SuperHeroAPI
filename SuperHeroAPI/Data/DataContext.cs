using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Entities;

namespace SuperHeroAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 

        }
        
        public DbSet<SuperHero> SuperHeroes { get; set; }
        public DbSet<Suit> Suits => Set<Suit>();
        public DbSet<Place> Places => Set<Place>(); 
    }
}
