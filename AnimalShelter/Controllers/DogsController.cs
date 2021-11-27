using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DogsController : ControllerBase
	{
		private readonly AnimalShelterContext _db;

		public DogsController(AnimalShelterContext db)
		{
			_db =db;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Dog>>> Get()
		{
			return await _db.Dogs.ToListAsync();
		}

		[HttpPost]
		public async Task<ActionResult<Dog>> Post(Dog dog)
		{
			_db.Dogs.Add(dog);
			await _db.SaveChangesAsync();

			return CreatedAtAction("Post", new { id = dog.DogId }, dog);
		}
	}
}