using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCoreLesson.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Brand { get; set; }
    }
}
