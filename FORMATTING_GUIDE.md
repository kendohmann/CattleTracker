# Code Formatting Guide

This project uses **Prettier** for consistent code formatting across the full stack.

## Format Everything at Once

### Windows (PowerShell)
```bash
.\format-all.ps1
```

### macOS/Linux (Bash)
```bash
./format-all.sh
```

**Note:** Run these commands from the project root directory.

---

## Frontend (TypeScript/JavaScript)

### Format Code
```bash
cd frontend
npm run format
```

### Check Formatting
```bash
cd frontend
npm run format:check
```

### Available Scripts
- `npm run format` - Format all TypeScript, JavaScript, HTML, CSS, and JSON files
- `npm run format:check` - Check if files are properly formatted
- `npm run lint:format` - Format all files in the frontend directory

## Backend (.NET/C#)

### Format Code
```bash
cd backend/Api
dotnet format
```

### Format Specific File
```bash
dotnet format --include path/to/file.cs
```

### Check Formatting
```bash
dotnet format --verify-no-changes
```

## Configuration

### Prettier Config (Frontend)
- **Root:** `.prettierrc` and `.prettierignore`
- **Frontend:** `frontend/.prettierrc` and `frontend/.prettierignore`

### EditorConfig
- **Root:** `.editorconfig` - Ensures consistent formatting across all editors

### .NET Formatting
- Uses `dotnet format` (based on `.editorconfig` settings for C#)

## Settings

### Prettier Defaults
- Print Width: 100 characters
- Tab Width: 2 spaces
- Trailing Commas: ES5 (objects, arrays, function parameters)
- Single Quotes: Yes
- Semi-colons: Yes
- Arrow Function Parentheses: Always
- Line Endings: LF (Unix)

### C# Formatting
- Indent Size: 4 spaces
- Indent Style: Space

## VS Code Integration

### Install Extensions
1. **Prettier - Code formatter** (`esbenp.prettier-vscode`)
2. **EditorConfig for VS Code** (`EditorConfig.EditorConfig`)

### VS Code Settings
Add to `.vscode/settings.json`:
```json
{
  "[javascript]": {
    "editor.defaultFormatter": "esbenp.prettier-vscode",
    "editor.formatOnSave": true
  },
  "[typescript]": {
    "editor.defaultFormatter": "esbenp.prettier-vscode",
    "editor.formatOnSave": true
  },
  "[html]": {
    "editor.defaultFormatter": "esbenp.prettier-vscode",
    "editor.formatOnSave": true
  },
  "[json]": {
    "editor.defaultFormatter": "esbenp.prettier-vscode",
    "editor.formatOnSave": true
  },
  "[css]": {
    "editor.defaultFormatter": "esbenp.prettier-vscode",
    "editor.formatOnSave": true
  }
}
```

## Pre-commit Hook (Optional)

To automatically format files before committing, consider using:
- **husky** + **lint-staged** (requires setup)

Example:
```bash
npm install --save-dev husky lint-staged
npx husky install
```

Then add to `package.json`:
```json
{
  "lint-staged": {
    "src/**/*.{ts,js,html,css,json}": "prettier --write"
  }
}
```

## Troubleshooting

### Prettier not found in VS Code
- Ensure Prettier extension is installed
- Reload VS Code window

### dotnet format command not found
- Run: `dotnet tool install -g dotnet-format`
- Ensure global tools directory is in PATH

### Conflicts between EditorConfig and Prettier
- EditorConfig takes precedence in most editors
- Ensure both files have compatible settings
