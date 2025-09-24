#!/usr/bin/env bash
set -euo pipefail
export ASPNETCORE_URLS="${ASPNETCORE_URLS:-http://0.0.0.0:5000}"
dotnet restore
dotnet run --project dotnet_frontend.csproj
