# Epicodus Class Project - March 30-April 1, 2020

### Created by: Brandan Sayarath, Patrick K, Hristo D, Dom Y.

## Description

This is the Epicodus in class assignment for the week of March 30, 2020.  The purpose of this project is to build an API for entering and rating vacation destinations. 

## Behavior Driven Development Specifications

| Specification             | Input 	|     Output      |
|-------------------------	|-------	|----------------	|
|user enters a destination | "string"   |   "DestinationId, Country, City, Rating, Reviews" |
|user updates a destination | new "string" | new "DestinationId, Country, City, Rating, Reviews" |
|user deletes a destination | deletes "id" | No destinations available |
|user queries entered destinations | "string" | "DestinationId, Country, City, Rating, Reviews" | 




## Setup/Installation Requirements

Clone this repository via Terminal using the following commands:
* ```$ cd desktop```
* ```$ git clone https://github.com/brandanpdx/Travel-Api-1```
* ```$ cd Travel-Api-1```

To run the program, first navigate to the Travel-Api production folder by typing the following into the terminal: 

* ```$ cd travel-api```

Then restore dependencies by typing:
* ```$ dotnet restore```

Then update your MySQL database by typing: 
* ```$ dotnef ef database update```

You can now run the program by typing:
* ```$ dotnet run```

## API Documentation

This project was built using a custom API.  To view the detailed routes of the API, please visit: https://app.swaggerhub.com/apis-docs/brandanpdx/travel/v1


## Support and Contact

Please email Brandan Sayarath: brandan@brandan.tech for any questions.

## Technologies Used

This program was created with:

* C#
* ASP.NET Core MVC 2.2
* Entity Framework
* Identity 
* MySQL
* MySQL Workbench 
* HTML5

## License

This code is licensed under MIT permissive free software license

Copyright (c) 2020 Brandan Sayarath, Patrick K, Hristo D, Dom Y.
