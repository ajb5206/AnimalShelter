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

		protected override void OnModelCreating(ModelBuilder builder)
			{
  		builder.Entity<Dog>()
      	.HasData(
          new Dog { DogId = 1, DogName = "Clio", DogAge = 15, DogGender = "Female", DogBreed = "Jack Russel" },
          new Dog { DogId = 2, DogName = "Sparky", DogAge = 19, DogGender = "Male", DogBreed = "Shetland Sheepdog" },
					new Dog { DogId = 3, DogName = "Alphonse", DogAge = 11, DogGender = "Male", DogBreed = "Black Lab" },
					new Dog { DogId = 4, DogName = "Bob", DogAge = 11, DogGender = "Male", DogBreed = "Golden Doodle" },
					new Dog { DogId = 5, DogName = "Rob", DogAge = 2, DogGender = "Female", DogBreed = "Golden Retriever" },
					new Dog { DogId = 6, DogName = "Dob", DogAge = 1, DogGender = "Male", DogBreed = "Pomeranian" },
					new Dog { DogId = 7, DogName = "Mob", DogAge = 5, DogGender = "Female", DogBreed = "Cocker Spaniel" },
					new Dog { DogId = 8, DogName = "Lob", DogAge = 7, DogGender = "Female", DogBreed = "Brittany" },
					new Dog { DogId = 9, DogName = "Cloe", DogAge = 19, DogGender = "Female", DogBreed = "Australian" }
      );
			builder.Entity<Cat>()
				.HasData(
					new Cat { CatId = 1, CatName = "Hobbes", CatAge = 2, CatGender = "Male", CatBreed = "Flame Point" },
					new Cat { CatId = 2, CatName = "Rikki", CatAge = 19, CatGender = "Male", CatBreed = "Tabby" },
					new Cat { CatId = 3, CatName = "Ash", CatAge = 5, CatGender = "Female", CatBreed = "Black Cat" },
					new Cat { CatId = 4, CatName = "Rhode", CatAge = 21, CatGender = "Male", CatBreed = "Gray" },
					new Cat { CatId = 5, CatName = "Bobob", CatAge = 5, CatGender = "Male", CatBreed = "Tabby" },
					new Cat { CatId = 6, CatName = "Loblob", CatAge = 9, CatGender = "Female", CatBreed = "Siamese" },
					new Cat { CatId = 7, CatName = "Mombob", CatAge = 18, CatGender = "Male", CatBreed = "Orange" },
					new Cat { CatId = 8, CatName = "Dobby", CatAge = 7, CatGender = "Male", CatBreed = "Russian Gray" },
					new Cat { CatId = 9, CatName = "Calvin", CatAge = 16, CatGender = "Male", CatBreed = "Persian" }
				);
			}
	}
}