using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
	public class AnimalShelterContext : DbContext
	{
		public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options)
		{

		}
		
		public DbSet<Dog> Dogs { get; set; }
		public DbSet<Cat> Cats { get; set; }
	}
}