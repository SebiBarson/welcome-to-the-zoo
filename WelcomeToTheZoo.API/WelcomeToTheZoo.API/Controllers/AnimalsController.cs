using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WelcomeToTheZoo.API.Contracts;
using WelcomeToTheZoo.API.Contracts.Requests;
using WelcomeToTheZoo.API.Data;
using WelcomeToTheZoo.API.Domain;

namespace WelcomeToTheZoo.API.Controllers
{
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly DataContext _db;

        public AnimalsController(DataContext dbContext)
        {
            _db = dbContext;
        }

        [HttpPost(ApiRoutes.Animals.Create)]
        public async Task<IActionResult> Create([FromBody] AnimalRequest animalRequest)
        {
            Animal animal = new Animal
            {
                Name = animalRequest.Name,
                Species = animalRequest.Species,
                EatingHabit = animalRequest.EatingHabit,
                Legs = animalRequest.Legs,
                ZooId = animalRequest.ZooId,
            };

            await _db.AddAsync(animal);
            int created = await _db.SaveChangesAsync();

            return created > 0
                ? Ok(animal)
                : BadRequest("Unable to add animal to zoo");

        }

        [HttpGet(ApiRoutes.Animals.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            var animals = await _db.Animals.AsQueryable().ToListAsync<Animal>();
            return Ok(animals);

        }
    }
}
