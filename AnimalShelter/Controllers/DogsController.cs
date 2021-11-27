using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
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
		public ActionResult<IEnumerable<Dog>> Get(string dogName, int dogAge, string dogGender, string dogBreed)
		{
			var query = _db.Dogs.AsQueryable();

			if (dogName != null)
			{
				query = query.Where(d => d.DogName == dogName);
			}

			if (dogAge != 0)
			{
				query = query.Where(d => d.DogAge == dogAge);
			}

			if (dogGender != null)
			{
				query =query.Where(d => d.DogGender == dogGender);
			}

			if (dogBreed != null)
			{
				query = query.Where(d => d.DogBreed == dogBreed);
			}
			return query.ToList();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Dog>> GetDog(int id)
		{
			var dog = await _db.Dogs.FindAsync(id);

			if (dog == null)
			{
				return NotFound();
			}

			return dog;
		}

		[HttpPost]
		public async Task<ActionResult<Dog>> Post(Dog dog)
		{
			_db.Dogs.Add(dog);
			await _db.SaveChangesAsync();

			return CreatedAtAction(nameof(GetDog), new { id = dog.DogId }, dog);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> Put(int id, Dog dog)
		{
			if (id != dog.DogId)
			{
				return BadRequest();
			}

			_db.Entry(dog).State = EntityState.Modified;

			try
			{
				await _db.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!DogExists(id))
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
		public async Task<IActionResult> DeleteDog(int id)
		{
			var dog = await _db.Dogs.FindAsync(id);
			if (dog == null)
			{
				return NotFound();
			}

			_db.Dogs.Remove(dog);
			await _db.SaveChangesAsync();

			return NoContent();
		}

		private bool DogExists(int id)
		{
			return _db.Dogs.Any(d => d.DogId == id);
		}
	}
}