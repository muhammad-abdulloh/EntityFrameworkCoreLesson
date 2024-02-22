
using EntityFrameworkCoreLesson.Infrastructure;
using EntityFrameworkCoreLesson.Models;
using Microsoft.EntityFrameworkCore;

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

        public async Task<bool> DeleteCarAsync(int id)
        {
            var car = _context.Cars.FirstOrDefaultAsync(x => x.Id == id);
            if(car != null)
            {
                _context.Cars.Remove(car.Result);
                await _context.SaveChangesAsync();

                return true;
            }
            return false;
        }

        public Task<List<Car>> GetAllCarAsync()
        {
            var cars = _context.Cars.ToListAsync();

            return cars;
        }

        public Task<Car> GetCarByIdAsync(int id)
        {
            var car = _context.Cars.FirstOrDefaultAsync(x => x.Id == id);
            if (car != null)
            {
                return car;
            }
            return null;
        }

        public async Task<Car> UpdateCarAsync(int id, Car model)
        {
            var car = _context.Cars.FirstOrDefaultAsync(x => x.Id == id);
            if (car != null)
            {
                car.Result.Name = model.Name;
                car.Result.Brand = model.Brand;

                await _context.SaveChangesAsync();
                return model;
            }
            return null;
        }
    }
}
