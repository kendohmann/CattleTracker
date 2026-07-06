# Format All - Prettier + dotnet-format
# Runs code formatting for both frontend (TypeScript/JavaScript) and backend (.NET/C#)
# Usage: .\format-all.ps1

Write-Host "Running Full-Stack Code Formatter"
Write-Host ""

# Frontend formatting with Prettier
Write-Host "1. Formatting Frontend"
Push-Location frontend
npm run format
$frontendStatus = $LASTEXITCODE
Pop-Location

if ($frontendStatus -eq 0) {
    Write-Host "Frontend formatted successfully"
} else {
    Write-Host "Frontend formatting failed (exit code: $frontendStatus)" -ForegroundColor Red
}

Write-Host ""

# Backend formatting with dotnet-format
Write-Host "2. Formatting Backend"
Push-Location backend/Api
dotnet format Api.csproj
$backendStatus = $LASTEXITCODE
Pop-Location

if ($backendStatus -eq 0) {
    Write-Host "Backend formatted successfully"
} else {
    Write-Host "Backend formatting failed (exit code: $backendStatus)" -ForegroundColor Red
}

Write-Host ""
Write-Host "Formatting Complete"

# Exit with error if any formatter failed
if ($frontendStatus -ne 0 -or $backendStatus -ne 0) {
    exit 1
} else {
    exit 0
}
