Backend API (ASP.NET Core)

Requirements: .NET 7 SDK, dotnet-ef tool

Run locally (pointing to local Postgres):

```bash
cd workspace/backend/Api
dotnet restore
dotnet ef migrations add InitialCreate --project .
dotnet ef database update --project .
dotnet run
```

When running via Docker Compose the `postgres` service will be available as `postgres` host as configured in infra/docker-compose.yml.