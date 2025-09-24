# Project Preview Configuration

Default Preview Target: dotnet_frontend (ASP.NET Core MVC) on port 5000

This workspace prioritizes the ASP.NET Core application located in `dotnet_frontend` as the default preview target. The application binds to `0.0.0.0:5000` and exposes a health endpoint at `/health`.

Quick Start (Default Preview)
1) Change to the dotnet project directory
   cd dotnet_frontend

2) Run using the provided script (binds to 0.0.0.0:5000)
   chmod +x ./start.sh
   ./start.sh

Open:
- http://localhost:5000

Health check:
- GET http://localhost:5000/health

Notes about Preview Configuration
- The .NET app is configured to bind to port 5000 by default via ASPNETCORE_URLS.
- If your preview system injects a PORT environment variable, the app can run with:
  ASPNETCORE_URLS="http://0.0.0.0:${PORT}" dotnet run --project dotnet_frontend.csproj

React Preview (Deprioritized)
- A minimal React template exists under `react_frontend/`. For this workspace, the React preview is disabled/deprioritized so that only the .NET preview is the default.
- If you need to run the React app locally:
  cd react_frontend
  npm install
  npm start
  Then browse to http://localhost:3000 (local only; not the default preview target for this workspace).

Containerized Run (Optional)
- A sample Dockerfile is included in `dotnet_frontend/` that exposes port 5000:
  cd dotnet_frontend
  docker build -t dotnet_frontend:dev .
  docker run --rm -p 5000:5000 dotnet_frontend:dev

Additional Documentation
- dotnet_frontend/README.md and QUICKSTART.md contain framework-specific details and troubleshooting tips.
