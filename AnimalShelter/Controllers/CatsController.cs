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

		[HttpGet("{id}")]
		public async Task<ActionResult<Cat>> GetCat(int id)
		{
			var cat = await _db.Cats.FindAsync(id);

			if (cat == null)
			{
				return NotFound();
			}

			return cat;
		}

		[HttpPost]
		public async Task<ActionResult<Cat>> Post(Cat cat)
		{
			_db.Cats.Add(cat);
			await _db.SaveChangesAsync();

			return CreatedAtAction(nameof(GetCat), new { id = cat.CatId }, cat);
		}
	}
}