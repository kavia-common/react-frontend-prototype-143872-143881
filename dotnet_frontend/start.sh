#!/usr/bin/env bash
# Simple startup script for preview systems. Non-interactive.
# - Restores dependencies
# - Runs the app bound to 0.0.0.0:5000
set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"

export ASPNETCORE_URLS="${ASPNETCORE_URLS:-http://0.0.0.0:5000}"
export ASPNETCORE_ENVIRONMENT="${ASPNETCORE_ENVIRONMENT:-Development}"

echo "Restoring .NET packages..."
dotnet restore "$SCRIPT_DIR/dotnet_frontend.csproj"

echo "Starting app on ${ASPNETCORE_URLS} ..."
exec dotnet run --no-restore --project "$SCRIPT_DIR/dotnet_frontend.csproj"
