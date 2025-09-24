# QUICKSTART

Default Preview: dotnet_frontend (ASP.NET Core MVC) on port 5000

Run the .NET app:
1) cd dotnet_frontend
2) chmod +x ./start.sh
3) ./start.sh

Open:
- http://localhost:5000

Health check:
- GET http://localhost:5000/health

Alternate start:
- ASPNETCORE_URLS=http://0.0.0.0:5000 dotnet run --project dotnet_frontend.csproj

React app (deprioritized):
- Not the default preview target. To run locally if needed:
  cd react_frontend
  npm install
  npm start
  Open http://localhost:3000
