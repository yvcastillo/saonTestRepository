# Job CRUD with MVC
It its and MVC web application with .net core to make crud to entities

## Prerequisites 🔧

* .NET Core 3.1
* Visual Studio 2019
* SQL Server Management Studio



## Usage ⚙️
* You have to compile the entire solution
* You have to change connection strings in appsettings.json files
* You could create a database migration with command **add-migration MigrationName -s Saon.DataAccess -Context TestContextMigration** in the **Package Manager Console** to create your database in your server. Remember you have to set the Saon.DataAccess Project as startup project to execute commands.
* Later, remember to execute the command **update-database -Context TestContextMigration** to commit changes in database
* You have to run the web application and click in the menu option "**Jobs CRUD**" to execute every operation

## Built With

* [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1) - MVC Web framework used
* [Entity Framework Core](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore ) - Entity Framework core



## Author ✒️

* **Yohalmo Castillo** - [Likedin](https://www.linkedin.com/in/yohalmo-castillo-16497ba8/)

## License
[MIT](https://choosealicense.com/licenses/mit/)