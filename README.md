# _Dr. Sillystringz's Factory_

#### _Independent coding assignment to get experience using ASP.NET Core MVC and Databases with many-to-many relationships, to help a factory track machines and engineers._

#### By _**Louie Schoenknecht**_

## Technologies Used

* _C#_
* _.NET 5_
* _ASP.NET Core MVC_
* _dotnet script, REPL_
* _Razor View Engine_
* _MySQL and MySQL Workbench_
* _Git_
* _Microsoft Entity Framework Core_


## Setup/Installation Requirements

### Application Setup
* _Install .NET 5.0 [here](https://dotnet.microsoft.com/download/dotnet/5.0)_

* _Clone repository from GitHub to desired location using_
  > git clone https://github.com/louiesch/Factory.Solution
* _In the terminal navigate to and open project directory_
  > cd Factory.Solution
* _Navigate to production folder_
  > cd Factory
* _Create a file in production folder called appsettings.json_
  > touch appsettings.json
* _Add the following code to your .json file_
```
{
"ConnectionStrings": {
"DefaultConnection": "Server=localhost;Port=3306;database=[YOUR DATABASE];uid=root;pwd=[YOUR PASSWORD];"
}
}
```
* _Make sure that [YOUR DATABASE] and [YOUR PASSWORD] match the database name and password of your local MySql server._

### Database Setup

* _Download MySQL and MySQL Workbench to set up a local database_

* _Once installed, open MySql Workbench and open a local server. If prompted, enter password_

* _In the Navigator, select the Administration tab and then select Data Import/Restore_

* _Under Import Options, select Import From Self-Contained File, and then select the "louie_schoenknecht.sql" file which can be found in Factory.Solution_

* _In the Default Schema to be Imported To option, select 'New'_

* _Enter a name for your database and select OK_

* _Click Start Import to begin database import_

### To Run Application

* _Navigate to Factory production folder in terminal_
  > cd Factory

* _To download obj and bin files needed for the program to run, while still in Factory folder type into the terminal:_
  >dotnet restore

* _To run the program, while still in production folder Factory type into the terminal:_
  >dotnet run


#### Note: The server will not open automatically. The user will need to click on the live share link in terminal, or enter 'localhost:5000' URL into browser.


## Known Bugs

* _No known bugs_

## License

_[MIT](https://choosealicense.com/licenses/mit/) Copyright (c) 2021 Louie Schoenknecht_


## Contact Information

_Want to get in touch? Send an email to luisesch97@gmail.com_