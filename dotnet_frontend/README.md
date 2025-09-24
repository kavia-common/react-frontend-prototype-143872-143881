# DotNet Frontend (ASP.NET Core MVC)

This folder contains an ASP.NET Core MVC web app styled with the "Ocean Professional" theme.

Key preview features:
- Binds to 0.0.0.0 on port 5000 by default (via ASPNETCORE_URLS)
- Health endpoint at `/health` returns 200 OK with JSON
- Startup script `start.sh` runs `dotnet restore` and `dotnet run`
- Sample Dockerfile exposing port 5000
- No reliance on launchSettings.json for port configuration

## Quick Start (recommended)

From this directory:

```bash
# Option A: Use the start script (binds to 0.0.0.0:5000)
chmod +x ./start.sh
./start.sh
```

Open:
- http://localhost:5000

Health check:
- GET http://localhost:5000/health

## Alternative Start Commands

- With explicit environment:
```bash
ASPNETCORE_URLS=http://0.0.0.0:5000 dotnet run --project dotnet_frontend.csproj
```

- If your preview system injects a PORT environment variable:
```bash
ASPNETCORE_URLS="http://0.0.0.0:${PORT}" dotnet run --project dotnet_frontend.csproj
```

- Using command-line `--urls` (equivalent):
```bash
dotnet run --project dotnet_frontend.csproj --urls http://0.0.0.0:5000
```

## Docker

Build and run:
```bash
docker build -t dotnet_frontend:dev .
docker run --rm -p 5000:5000 dotnet_frontend:dev
```

Then open http://localhost:5000

## Health Endpoint

- `GET /health` → `200 OK`
  Example response:
  ```json
  { "status": "ok", "service": "dotnet_frontend" }
  ```

## Ports

- Primary HTTP port: 5000
- Binding is handled by `ASPNETCORE_URLS` (default: `http://0.0.0.0:5000`)
- Do not rely on `Properties/launchSettings.json` for port configuration in preview systems

## Structure

- Program.cs: ASP.NET Core setup and routing
- Controllers/HomeController.cs: Home and Error routes
- Controllers/HealthController.cs: `/health` endpoint
- Views/Shared/_Layout.cshtml: Shared layout for header/content/footer and theme toggle
- Views/Home/Index.cshtml: Landing page with Ocean Professional cards
- wwwroot/css/site.css: Theme and layout styling

## Troubleshooting

- Port already in use:
  - Change port by setting: `ASPNETCORE_URLS=http://0.0.0.0:5050 ./start.sh`
  - Or map a different host port when using Docker: `-p 8080:5000`
- App not reachable from preview:
  - Ensure binding is `0.0.0.0` (not `localhost`)
  - Verify the preview system exposes port 5000
  - Use the `/health` endpoint to verify service status
- SSL/HTTPS:
  - Many previews terminate HTTP only inside the container. This app supports HTTP by default.
- Restore/build errors:
  - Run `dotnet --info` to ensure .NET 8 SDK is installed
  - Run `dotnet restore` manually to inspect errors

## Notes

- Public interfaces are documented in controllers per project guidelines.
- Theme colors: primary (blue) and secondary (amber) accents.
