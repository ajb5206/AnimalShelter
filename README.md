## README for Independent Project #11

# Animal Shelter API

#### Welcome to the animal shelter!

#### **By Alex Bertotto**
#### Table of Contents

1. [Technologies Used](#technologies)
2. [Description](#description)
3. [Setup/Installation Requirements](#setup/install)
4. [Known Bugs](#knownbugs)
5. [License](#license)
6. [Contact Information](#contact)

## Technologies Used <a id="technologies"></a>

* ASP.NET Core
* C#
* CRUD
* EntityFrameworkCore
* Html
* Microsoft NET 5.0
* MySql
* Pagination
* Visual Studio Code

## Description <a id="description"></a>

Welcome to the Animal Shelter API. Add dogs and cats to the API, or check out the pre-seeded animals. 
Pagination is implemented by adding two PaginationModel files, one for cats and one for dogs. Each model includes properties about the total number of cats or dogs, amount of cats or dogs per page, pages, and more. Within the animal-specific controllers, pagination is implemented by adding more paramenters to the GET request. Within the GET request, the pagination properties are defined. By using some basic math, along with GetRange, results are paginated. 

## Setup/Installation Requirements <a id="setup/install"></a>

1. Clone the project to your current directory using the following command: git clone https://github.com/ajb5206/AnimalShelter.Solution
2. Navigate to the project folder in the command line
3. Run the command _`dotnet restore`_ to install the packages listed in the _`.csproj`_ file 
	 as well as creating the _`obj`_ file
4. Run _`dotnet build`_ to create internal content including the _`bin`_ file
5. Add an _`appsettings.json`_ file to your root directiory with the following code _`{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DATABASE-NAME];uid=[YOUR-USER-ID];pwd=[YOUR-PASSWORD-HERE];"
  }
}`_
6. From the project folder, AnimalShelter, run _`dotnet ef migrations add Initial`_ and then _`dotnet ef database update`_
7. Run `dotnet run` and navigate to `localhost:5000/api/cats` to see the first 3 of 9 pre-seeded cats
8. Navigate to _`localhost:5000/api/cats?page=[INSERT-PAGE-NUMBER]&perPage=[NUMBER-OF-RESULTS-PERPAGE]`_ for a list of cats ex: _`http://localhost:5000/api/cats?page=0&perPage=5`_
9. Navigate to _`localhost:5000/api/dogs?page=[INSERT-PAGE-NUMBER]&perPage=[NUMBER-OF-RESULTS-PERPAGE]`_ for a list of dogs ex: _`http://localhost:5000/api/dogs?page=1&perPage=2`_
10. Send POST requests to _`localhost:5000/api/cats`_ and _`localhost:5000/api/dogs`_
11. To get individual cats or dogs by id, use _`localhost:5000/api/[CATS-OR-DOGS]/[ID-NUMBER]`_
12. To edit a cat or dog, send a PUT request to _`localhost:5000/api/[CATS-OR-DOGS]/[ID-NUMBER]`_
13. To delete a cat or dog, send DELETE requests to _`localhost:5000/api/[CATS-OR-DOGS]/[ID-NUMBER]`_
14. Querable search parameters for Cats: catName, catGender, catAge, catBreed
		ex: _`localhost:5000/api/cats?catGender=female`_
15. Querable search paramters for Dogs: dogName, dogGender, dogAge, dogBreed
		ex: _`localhost:5000/api/dogs?dogAge>1`_



## Known Bugs <a id="knownbugs"></a>
* Pagination overall could be implemented in a more simple manner

## License
Copyright <2021> <MIT>

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

_If there are any issues or have questions, ideas or concerns, please feel free to contact me or make a contribution to the code._

## Contact Information <a id="contact"></a>
#### Alex Bertotto ajb5206@gmail.com 
#### https://github.com/ajb5206