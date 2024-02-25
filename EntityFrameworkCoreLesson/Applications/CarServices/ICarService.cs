using EntityFrameworkCoreLesson.Models;

namespace EntityFrameworkCoreLesson.Applications.CarServices
{
    public interface ICarService
    {
        public Task<string> CreateCarAsync(Car model);
        public Task<Car> UpdateCarAsync(int id, Car model);
        public Task<bool> DeleteCarAsync(int id);
        public Task<List<Car>> GetAllCarAsync();
        public Task<Car> GetCarByIdAsync(int id);
        List<Type> UseMyMethod();
    }
}
