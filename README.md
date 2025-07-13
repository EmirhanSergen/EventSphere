# EventSphere

EventSphere is a web application built with ASP.NET Core. It allows users to create, manage and discover events. The project was originally developed as a school assignment and demonstrates basic usage of the ASP.NET MVC framework, Entity Framework Core and Identity for authentication.

## Features

- User registration and login
- Event creation and browsing
- Participation in events
- Basic CRUD operations for users

## Requirements

- [.NET SDK 8.0](https://dotnet.microsoft.com/download)
- SQL Server LocalDB or any SQL Server instance

## Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/eventsphere.git
   cd eventsphere
   ```
2. Restore dependencies:
   ```bash
   dotnet restore
   ```
3. Update the database using Entity Framework migrations:
   ```bash
   dotnet ef database update
   ```
   This creates the database defined in `appsettings.json`. You can override the connection string by setting the environment variable `ConnectionStrings__EventSphereContext` or editing `appsettings.json`.
4. Run the application:
   ```bash
   dotnet run --project EventSphere
   ```
   The site will be available at `https://localhost:5001/` by default.

## Configuration

Copy the provided `.env.example` file to `.env` and adjust any values if you prefer to keep configuration outside `appsettings.json`:

```bash
cp .env.example .env
```

Values in `.env` will override configuration settings via environment variables when running the application.

## Notes

EventSphere is intended for educational purposes and may not include all security or production-ready features. Pull requests and suggestions are welcome.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

