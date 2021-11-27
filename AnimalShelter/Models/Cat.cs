using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
	public class Cat
	{
		public int CatId { get; set; }
		[Required]
		public string CatName { get; set; }
		[Required]
		[Range(0, 100, ErrorMessage = "Age must be between 0 and 100.")]
		public int CatAge { get; set; }
		[Required]
		public string CatGender { get; set; }
		public string CatBreed { get; set; }
	}

}