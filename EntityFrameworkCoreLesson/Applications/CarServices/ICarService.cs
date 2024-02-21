using EntityFrameworkCoreLesson.Models;

namespace EntityFrameworkCoreLesson.Applications.CarServices
{
    public interface ICarService
    {
        public Task<string> CreateCarAsync(Car model);
    }
}
