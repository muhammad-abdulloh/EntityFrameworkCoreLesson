
using EntityFrameworkCoreLesson.Infrastructure;
using EntityFrameworkCoreLesson.Models;

namespace EntityFrameworkCoreLesson.Applications.CarServices
{
    public class CarService : ICarService
    {
        private readonly ApplicationDbContext _context;
        public CarService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<string> CreateCarAsync(Car model)
        {
            await _context.Cars.AddAsync(model);
            await _context.SaveChangesAsync();

            return "Malumot Yaratildi";
        }
    }
}
