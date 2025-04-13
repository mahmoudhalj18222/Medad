using Microsoft.EntityFrameworkCore;
using Amzon_Domain;
using System.Data;
namespace Amazon_Data
{
    public class AmazonDbContext : DbContext
    {

        public DbSet<Employee> Employees  { get; set; }

    }
}
