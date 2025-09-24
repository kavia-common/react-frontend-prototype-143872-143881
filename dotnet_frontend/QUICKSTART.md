# Quick Start (Default Preview Target)

This ASP.NET Core MVC app is the default preview for this workspace. It binds to `0.0.0.0:5000` by default.

Start (recommended):
1) From this directory:
   chmod +x ./start.sh
   ./start.sh

2) Open http://localhost:5000

Health:
- GET http://localhost:5000/health → 200 OK

Alternative start commands:
- With explicit environment:
  ASPNETCORE_URLS=http://0.0.0.0:5000 dotnet run --project dotnet_frontend.csproj
- If your environment provides PORT:
  ASPNETCORE_URLS="http://0.0.0.0:${PORT}" dotnet run --project dotnet_frontend.csproj
- Using command-line `--urls` (equivalent):
  dotnet run --project dotnet_frontend.csproj --urls http://0.0.0.0:5000

Docker (optional):
- Build:  docker build -t dotnet_frontend:dev .
- Run:    docker run --rm -p 5000:5000 dotnet_frontend:dev
- Open:   http://localhost:5000

Notes:
- Ensure .NET SDK 8+ is available: `dotnet --info`
- Do not rely on `launchSettings.json` for preview ports; use `ASPNETCORE_URLS` instead.
- This project exposes a health endpoint at `/health` for preview readiness checks.
