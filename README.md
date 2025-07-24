# Great Walks ASP.NET Core Web API 

## Project Description
Using the ASP .NET Core Web API, I created a very interesting REST API 

## Achievements
-  REST APIs by creating a Web API using ASP.NET Core and .NET 8

- Dependency Injection and Benefits

- Entity Framework Core (EF Core) In ASP.NET Core Web API Project

- Entity Framework Core Migrations

- Understand the difference between Domain models and DTOs

- Domain Models and Repository Pattern

- Using Swagger To Test ASP .NET Core WEB API project

- Mapping DTOs and Models To One Another Using Automapper

- Asynchronous Programming (Async Await)

- Securing the API endpoints using Microsoft Identity by adding Authentication and Role-Based Authorization.

- Adding JWT Authentication to ASP.NET Core Web API by creating JWT Tokens to API Clients.

- Incorporating ASP.NET JWT Authentication Into SwaggerUI

- Logging Important Information Using Serilog

- Adding advanced functionality like Filtering, Sorting, and Pagination to your ASP.NET Core Web API.


## Technologies and Tools
 
- C#
- .NET 8.0
- ASP .NET Core Web API
- Entity Framework Core
- SQL Server
- Automapper 
- Json Web Token (JWT)
- Serilog
- Postman
- Swagger UI

## How to Run
These steps are designed to help someone who has cloned the project to get it running on their local machine.

### Prerequisites
- .NET 8.0 SDK
- SQL Server

### Steps
#### 1. Clone the Repository
Open Terminal or Command Prompt and clone the repository to your local machine:

```
git clone <https://github.com/userahmedosman/great_walks_API.git>
```
#### 2. Install Dependencies
Navigate to the project's root directory in Terminal or Command Prompt:

```
cd great_walks_API
```

Install dependencies using the following command:
```
dotnet restore
```
#### 3. Set Up the Database Connection
Update the SQL Server connection string in the appsettings.json file:

```
"ConnectionStrings": {
  "GWConnection": "Server=server_name;Database=GreatWalksDB;Trusted_Connection=True;MultipleActiveResultSets=true",

  "GWAuthConnection": "Server=server_name;Database=GreatWalksAuthDB;Trusted_Connection=True;TrustServerCertificate=True"
}

```
Replace <server_name> with your SQL Server information.

#### 4. Create the Database

Navigate to the project directory in Terminal or Command Prompt and run the following command:

```
dotnet ef database update
```

#### 5. Run the Project

Navigate to the project directory in Terminal or Command Prompt and start the application:

```
dotnet run
```

![image](https://github.com/userahmedosman/great_walks_API/asset/69698425/swagger_ui)
