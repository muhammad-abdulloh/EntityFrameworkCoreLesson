
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

        public List<Type> UseMyMethod()
        {
            return FindEntitiesImplementingInterface(_context);
        }

        public List<Type> FindEntitiesImplementingInterface(DbContext context)
        {
            var model = context.Model;

           List<Type>? entityTypes = model.GetEntityTypes()
                                    .Select(e => e.ClrType)
                                    .Where(t => typeof(Probems3).IsAssignableFrom(t) && !t.IsInterface)
                                    .ToList();

            return entityTypes;
        }
    }


    public class Probems : Probems2, Probems3, Probems4, Probems5
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static int[] DivisibleBy(int[] numbers, int divisor)
        {
            var result = new int[1];

            for (int x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] % divisor == 0) result[x] = numbers[x];
            }
            return result;
        }
    }

    public class Probems2 : Probems3
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int[] DivisibleBy1(int[] numbers, int divisor)
        {
            var result = new int[1];

            for (int x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] % divisor == 0) result[x] = numbers[x];
            }
            return result;
        }
    }

    public interface Probems3
    {
        public static int[] DivisibleBy2(int[] numbers, int divisor)
        {
            var result = new int[1];

            for (int x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] % divisor == 0) result[x] = numbers[x];
            }
            return result;
        }
    }

    public interface Probems4
    {
        public static int[] DivisibleBy3(int[] numbers, int divisor)
        {
            var result = new int[1];

            for (int x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] % divisor == 0) result[x] = numbers[x];
            }
            return result;
        }
    }

    public interface Probems5
    {
        public static int[] DivisibleBy4(int[] numbers, int divisor)
        {
            var result = new int[1];

            for (int x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] % divisor == 0) result[x] = numbers[x];
            }
            return result;
        }
    }
}
