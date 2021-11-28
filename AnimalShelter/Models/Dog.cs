using System.ComponentModel.DataAnnotations;
namespace AnimalShelter.Models
{
	public class Dog
	{
		public int DogId { get; set; }
		[Required]
		public string DogName { get; set; }
		[Required]
		[Range(0, 100, ErrorMessage = "Age must be between 0 and 100.")]
		public int DogAge { get; set; }
		[Required]
		public string DogGender { get; set; }
		public string DogBreed { get; set; }
	}

}