using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CatsController : ControllerBase
	{
		private readonly AnimalShelterContext _db;

		public CatsController(AnimalShelterContext db)
		{
			_db = db;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Cat>>> Get()
		{
			return await _db.Cats.ToListAsync();
		}

		[HttpPost]
		public async Task<ActionResult<Cat>> Post(Cat cat)
		{
			_db.Cats.Add(cat);
			await _db.SaveChangesAsync();

			return CreatedAtAction("Post", new { id = cat.CatId }, cat);
		}
	}
}