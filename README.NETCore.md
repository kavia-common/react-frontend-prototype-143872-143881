# ASP.NET Core 7 MVC - Ocean Professional Demo

This project migrates the minimal React demo to an ASP.NET Core 7 MVC application while preserving the key UX:
- Modern layout (Header with navigation, central content area, and footer)
- Light/Dark theme toggle using CSS variables
- "Ocean Professional" color palette and styling

## Requirements
- .NET 7 SDK or later installed (https://dotnet.microsoft.com/download)

## Getting Started
1. Navigate to the .NET app folder:
   cd react-frontend-prototype-143872-143881/dotnet_frontend

2. Restore and run:
   dotnet restore
   dotnet run

3. Open the app in your browser:
   http://localhost:5080  (the console will show the exact port; we configure Kestrel to listen on 5080 for convenience)

## Project Structure
- Program.cs: Minimal hosting setup
- Controllers/HomeController.cs: Returns the Home view
- Views/Shared/_Layout.cshtml: Global layout with header/nav/footer and theme toggle
- Views/Home/Index.cshtml: Home page content
- wwwroot/css/site.css: Ocean Professional theme with CSS variables for light and dark modes
- wwwroot/js/site.js: Theme toggle logic (persists preference to localStorage)
- appsettings.json: Basic configuration

## Ocean Professional Theme
Color palette (from project style guide):
- Primary:   #2563EB
- Secondary: #F59E0B
- Success:   #F59E0B
- Error:     #EF4444
- Background:#f9fafb
- Surface:   #ffffff
- Text:      #111827

The theme is implemented with CSS variables under :root (light) and [data-theme="dark"] (dark). The toggle button applies/removes the data-theme attribute on <html>.

## Notes
- No backend business logic or database is included.
- This app intentionally avoids SPA frameworks and leverages MVC + unobtrusive JS for a native feel.

