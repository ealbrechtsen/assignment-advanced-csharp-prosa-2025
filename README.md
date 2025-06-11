# Customer - Assignment

This repository contains the approved solution for the **"ProsaOpg"** assignment submitted as part of the **"C# Advanced"** course offered by PROSA in Spring 2025. The project demonstrates layered architecture, test-driven development, and REST API fundamentals, developed as part of a six-hour course led by Michell Cronberg.

## Course Overview  
The course focused on modern software architecture and development practices in C#, including:  
- Layered architecture: separation into Presentation, Domain, and Data layers.  
- SOLID principles and Dependency Injection.  
- Common design patterns such as Singleton, Factory, and Observer.  
- Working with Entity Framework Core (DbContext, Migrations, LINQ).  
- Creating and consuming RESTful APIs with correct use of HTTP verbs and status codes.  
- Unit testing with xUnit, including mocking and integration tests.

## Development Environment  
- **IDE**: Visual Studio Code / Visual Studio / JetBrains Rider  
- **Framework**: .NET 9  
- **Language**: C#  
- **Database**: SQLite  
- **Testing**: xUnit  

For more details on the course, visit the official materials:  
[https://mcronberg.github.io/bogenomcsharp/diverse/prosacsudv2025/](https://mcronberg.github.io/bogenomcsharp/diverse/prosacsudv2025/)

## How to Run  
1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) if not already installed.  
2. Clone or download this repository.  
3. Navigate to the project root folder in a terminal:  
   ```bash
   cd path/to/ProsaOpg
   ```
4. Restore and build the solution:  
   ```bash
   dotnet restore  
   dotnet build  
   ```
5. Run the application in Debug mode (mock data):  
   ```bash
   cd ProsaOpg/ConsoleUI  
   dotnet run
   ```
6. Run in Release mode (real SQLite data):  
   ```bash
   dotnet run -c Release
   ```

## How to Test  
Run all unit tests from the root using:  
```bash
cd ProsaOpg/ProsaOpg.Test  
dotnet test  
```

To get detailed output:  
```bash
dotnet test -l "console;verbosity=detailed"
```

## Project Structure  
```
ProsaOpg/
├── ConsoleUI/            # Console interface
│   └── Program.cs
│   └── Customers.db      # SQLite test database
├── Data/                 # Data access layer
│   └── EfDataAccessService.cs
│   └── MockDataAccessService.cs
│   └── IDataAccess.cs
│   └── DataAccessFactory.cs
├── Types/                # Domain models
│   └── Customer.cs
├── Test/                 # xUnit tests
│   └── AllTests.cs
└── ProsaOpg.sln          # Solution file
```

## Author  
**Emil Malik Albrechtsen**
