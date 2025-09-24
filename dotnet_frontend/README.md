# DotNet Frontend (ASP.NET Core MVC)

This folder contains a new ASP.NET Core MVC web app that ports the core functionality and layout from the original `demo_proj`. It applies the "Ocean Professional" theme with:
- Header with navigation
- Central content area
- Footer
- Theme toggle (Light/Dark) persisted via `localStorage`

## How to Run

1. Ensure you have .NET 8 SDK installed.
2. From this folder's parent (project root) or this folder, run:

```bash
dotnet run --project dotnet_frontend
```

Then browse to:
- http://localhost:5000 (HTTP)
- https://localhost:7000 (HTTPS)

Health endpoint:
- `GET /health` returns basic JSON

## Structure

- Program.cs: ASP.NET Core setup and routing
- Controllers/HomeController.cs: Home and Error routes
- Views/Shared/_Layout.cshtml: Shared layout for header/content/footer and theme toggle
- Views/Home/Index.cshtml: Landing page with Ocean Professional cards
- wwwroot/css/site.css: Theme and layout styling

## Notes

- Public interfaces are documented in controllers per project guidelines.
- Theme colors: primary (blue) and secondary (amber) accents as requested.
