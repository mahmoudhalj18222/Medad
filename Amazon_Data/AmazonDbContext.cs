using Microsoft.EntityFrameworkCore;
using Amzon_Domain;
using System.Data;
namespace Amazon_Data
{
    public class AmazonDbContext : DbContext
    {

        public DbSet<Employee> Employees  { get; set; }
        public DbSet <AmazonTask> amazonTasks { get; set; }
        public DbSet<Category> categorie { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = AmazonMainDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AmazonTask>()
                .HasMany(at => at.categories)
                .WithMany(at => at.tasks)
                .UsingEntity<CategoryTesk>()
                .Property(ct => ct.getDateAdd).HasDefaultValueSql("getDate()");
        }
    }
}
