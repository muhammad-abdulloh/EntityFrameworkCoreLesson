using EntityFrameworkCoreLesson.Applications.CarServices;
using EntityFrameworkCoreLesson.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkCoreLesson.Controllers
{
    [Route("api/[controller]")]
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
    }
}
