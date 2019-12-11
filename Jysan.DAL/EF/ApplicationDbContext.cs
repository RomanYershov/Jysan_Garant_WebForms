
using System.Data.Entity;
using Jysan.DAL.Entities;

namespace Jysan.DAL.EF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {

        }

        //static ApplicationDbContext()
        //{
        //    System.Data.Entity.Database.SetInitializer(new DbInitializer());
        //}
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<LegalEntity> LegalEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Individual>().HasIndex(x => x.Iin).IsUnique();
            //modelBuilder.Entity<LegalEntity>().HasIndex(x => x.Iin).IsUnique();
            modelBuilder.Entity<LegalEntity>().HasMany(x => x.Individuals);
        }
        
    }
}
