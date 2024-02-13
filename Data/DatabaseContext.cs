using Microsoft.EntityFrameworkCore;
using RepositoryPatternExample.Models;

namespace RepositoryPatternExample.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {}

        public DbSet<Book> Books { get; set; }
    }
}
