using EntityFrameworkCoreLesson.Applications.CarServices;
using EntityFrameworkCoreLesson.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkCoreLesson.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EntityController : ControllerBase
    {
        private readonly ICarService _carService;

        public EntityController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpPost]
        public async Task<string> CreateCar(Car model)
        {
            var result = await _carService.CreateCarAsync(model);

            return result;
        }

        [HttpGet]
        public async Task<List<Car>> GetAllCars()
        {
            var result = await _carService.GetAllCarAsync();

            return result;
        }

        [HttpGet]
        public async Task<Car> GetAllCarsById(int id)
        {
            var result = await _carService.GetCarByIdAsync(id);

            return result;
        }


        [HttpPut]
        public async Task<Car> UpdateCarsById(int id, Car model)
        {
            var result = await _carService.UpdateCarAsync(id, model);

            return result;
        }

        [HttpDelete]
        public async Task<bool> DeleteCarsById(int id)
        {
            var result = await _carService.DeleteCarAsync(id);

            return result;
        }

    }
}
