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
		public async Task <ActionResult<PaginationModel>> Get(string catName, int catAge, string catGender, string catBreed, int page, int perPage)
		{
			var query = _db.Cats.AsQueryable();

			if (catName != null)
			{
				query = query.Where(c => c.CatName == catName);
			}

			if (catAge != 0)
			{
				query = query.Where(c => c.CatAge == catAge);
			}

			if (catGender != null)
			{
				query =query.Where(c => c.CatGender == catGender);
			}

			if (catBreed != null)
			{
				query = query.Where(c => c.CatBreed == catBreed);
			}

			List<Cat> cats = await query.ToListAsync();

			if (perPage == 0) perPage = 3;

			int total = cats.Count;
			List<Cat> catPage = new List<Cat>();

			if(page < (total / perPage))
			{
				catPage = cats.GetRange(page * perPage, perPage);
			}

			if (page == (total / perPage))
			{
				catPage = cats.GetRange(page * perPage, total - ( page * perPage));
			}
			return new PaginationModel()
			{
				CatData = catPage,
				Total = total,
				PerPage = perPage,
				Page = page,
				PreviousPage = page == 0 ? "No previous page" : $"/api/cats?page={page - 1}%perPage={perPage}",
				NextPage = page == total/perPage ? "No next page" : $"api/cats?page={page + 1}&perPage={perPage}"
			};
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