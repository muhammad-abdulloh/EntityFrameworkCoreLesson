using EntityFrameworkCoreLesson.Applications.CarServices;
using EntityFrameworkCoreLesson.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreLesson.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Probems> Probems { get; set; }
        public DbSet<Probems2> Probems2 { get; set; }
    }
}
