using EntityFrameworkCoreLesson.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreLesson.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Car> Cars { get; set; }
    }
}
