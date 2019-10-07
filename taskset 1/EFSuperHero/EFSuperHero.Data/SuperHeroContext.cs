using Microsoft.EntityFrameworkCore;
using EFSuperHero.Domain;
using System;

namespace EFSuperHero.Data
{
    public class SuperHeroContext : DbContext
    {
        public DbSet<SuperHero> SuperHeroes { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<RealIdentity> RealIdentities { get; set; }
        public DbSet<Battle> battles { get; set; }
        public DbSet<SuperHeroBattle> SuperHeroBattles { get; set; }
        public DbSet<BattleEvent> BattleEvents { get; set; }
        public DbSet<BattleLog> BattleLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SuperHeroBattle>()
                .HasKey(o => new { o.SuperHeroId, o.BattleId });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server = (localdb)\MSSQLLocalDB; " +
                @"Database = EFSuperHero; " +
                @"Trusted_Connection = True");

        }
    }
}
