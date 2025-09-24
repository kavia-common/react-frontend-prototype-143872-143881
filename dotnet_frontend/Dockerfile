# Simple Dockerfile for ASP.NET Core MVC (net8.0)
# Exposes port 5000 and binds to 0.0.0.0 for preview systems.

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY dotnet_frontend.csproj ./
RUN dotnet restore ./dotnet_frontend.csproj
COPY . .
RUN dotnet publish ./dotnet_frontend.csproj -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
ENV ASPNETCORE_URLS=http://0.0.0.0:5000
ENV ASPNETCORE_ENVIRONMENT=Production
EXPOSE 5000
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "dotnet_frontend.dll"]
