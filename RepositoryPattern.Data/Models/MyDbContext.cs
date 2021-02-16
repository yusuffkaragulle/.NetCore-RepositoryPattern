using Microsoft.EntityFrameworkCore;

namespace RepositoryPattern.Data.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
