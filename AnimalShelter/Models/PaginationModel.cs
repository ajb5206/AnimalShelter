using System.Collections.Generic;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
	public class PaginationModel
	{
		public List<Dog> DogData { get; set; }
		public int DogTotal { get; set;}
		public int DogPerPage { get; set;}
		public int DogPage { get; set; }
		public string DogPreviousPage { get; set; }
		public string DogNextPage { get; set; }


		public List<Cat> CatData { get; set; }
		public int CatTotal { get; set; }
		public int CatPerPage { get; set; }
		public int CatPage { get; set; }
		public string CatPreviousPage { get; set; }
		public string CatNextPage { get; set; }
	}
}