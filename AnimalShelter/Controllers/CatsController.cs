using System.Collections.Generic;
using System.Linq;
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

		[HttpPut("{id}")]
		public async Task<IActionResult> Put(int id, Cat cat)
		{
			if (id != cat.CatId)
			{
				return BadRequest();
			}

			_db.Entry(cat).State = EntityState.Modified;

			try
			{
				await _db.SaveChangesAsync();
			}

			catch (DbUpdateConcurrencyException)
			{
				if (!CatExists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return NoContent();
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteCat(int id)
		{
			var cat = await _db.Cats.FindAsync(id);
			if (cat == null)
			{
				return NotFound();
			}
			
			_db.Cats.Remove(cat);
			await _db.SaveChangesAsync();

			return NoContent();
		}

		private bool CatExists(int id)
		{
			return _db.Cats.Any(c => c.CatId == id);
		}
	}
}