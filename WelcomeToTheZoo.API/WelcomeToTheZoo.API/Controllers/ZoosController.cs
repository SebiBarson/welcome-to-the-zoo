using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WelcomeToTheZoo.API.Contracts;
using WelcomeToTheZoo.API.Contracts.Requests;
using WelcomeToTheZoo.API.Contracts.Responses;
using WelcomeToTheZoo.API.Data;
using WelcomeToTheZoo.API.Domain;

namespace WelcomeToTheZoo.API.Controllers
{
    [ApiController]
    public class ZoosController : ControllerBase
    {
        private readonly DataContext _db;

        public ZoosController(DataContext dbContext)
        {
            _db = dbContext;
        }

        [HttpPost(ApiRoutes.Zoos.Create)]
        public async Task<IActionResult> Create([FromBody] ZooRequest zooRequest)
        {
            Zoo zoo = new Zoo
            {
                Name = zooRequest.Name,
                Address = zooRequest.Address,
                Acres = zooRequest.Acres
            };

            await _db.AddAsync(zoo);
            int created = await _db.SaveChangesAsync();

            return created > 0
                ? Ok(zoo)
                : BadRequest("Unable to add zoo");

        }

        [HttpGet(ApiRoutes.Zoos.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            List<Zoo> zoos = await _db.Zoos.AsQueryable().ToListAsync<Zoo>();
            List<ZooResponse> response = new List<ZooResponse>();
            foreach (Zoo zoo in zoos)
            {
                response.Add(new ZooResponse
                {
                    Id = zoo.Id,
                    Name = zoo.Name,
                    Address = zoo.Address,
                    Acres = zoo.Acres
                });
            }
            return Ok(response);

        }
    }
}
