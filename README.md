# WeddingDressDecisionAid Workspace

This workspace contains:
- `frontend/` — Angular frontend scaffold
- `backend/Api/` — .NET Web API using Entity Framework Core (Postgres)
- `infra/` — Docker Compose with Postgres

Quick start (development):

1. Start Postgres via Docker Compose:

```bash
cd workspace/infra
docker-compose up -d
```

2. Run the backend (requires .NET 7+):

```bash
cd workspace/backend/Api
dotnet restore
dotnet ef database update --project . --startup-project .
dotnet run
```

3. Run the frontend (requires Node.js):

```bash
cd workspace/frontend
npm install
npm start
```

See individual folders for details and further instructions.