# Quickstart for Preview Systems

Most automated preview systems expect a single start command.

Recommended:
- Command: `./dotnet_frontend/start.sh`
- Exposed Port: `5000`
- Health Check: `GET /health`

Environment variables:
- `ASPNETCORE_URLS` (optional): defaults to `http://0.0.0.0:5000`
- `PORT` (optional): if your platform sets this, you can use `ASPNETCORE_URLS="http://0.0.0.0:${PORT}"`

Docker:
- Build: `docker build -t dotnet_frontend:dev ./dotnet_frontend`
- Run: `docker run --rm -p 5000:5000 dotnet_frontend:dev`
