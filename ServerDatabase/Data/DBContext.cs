using Microsoft.EntityFrameworkCore;

namespace RestServer.Data
{
    public class DBContext : DbContext
    {
        public DbSet<Adult> Adults { get; set; }
        public DbSet<User> User { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // name of database
            optionsBuilder.UseSqlite(@"Data Source = Database.db");
        }
        
    }
}