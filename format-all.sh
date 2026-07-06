#!/bin/bash
# Format All - Prettier + dotnet-format
# Runs code formatting for both frontend (TypeScript/JavaScript) and backend (.NET/C#)
# Usage: ./format-all.sh

echo "Running Full-Stack Code Formatter"
echo ""

# Frontend formatting with Prettier
echo "1. Formatting Frontend"
cd frontend
npm run format
FRONTEND_STATUS=$?
cd ..

if [ $FRONTEND_STATUS -eq 0 ]; then
    echo "Frontend formatted successfully"
else
    echo "Frontend formatting failed (exit code: $FRONTEND_STATUS)"
fi

echo ""

# Backend formatting with dotnet-format
echo "2. Formatting Backend"
cd backend/Api
dotnet format
BACKEND_STATUS=$?
cd ../..

if [ $BACKEND_STATUS -eq 0 ]; then
    echo "Backend formatted successfully"
else
    echo "Backend formatting failed (exit code: $BACKEND_STATUS)"
fi

echo ""
echo "Formatting Complete"

# Exit with error if any formatter failed
if [ $FRONTEND_STATUS -ne 0 ] || [ $BACKEND_STATUS -ne 0 ]; then
    exit 1
else
    exit 0
fi
