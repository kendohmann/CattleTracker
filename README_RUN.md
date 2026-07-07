
## Set up

- Install Node.js
- Install Angular
- [Install Dot.Net](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-7.0.20-windows-x64-installer?cid=getdotnetcore)
- [Install Asp.Net](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-aspnetcore-7.0.20-windows-x64-installer?cid=getdotnetcore)
- Follow [these](https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/install) instructions

    - Click on `Download and Install`
    - Skip the first step and follow the section `Download and run the configuration file
`

## Run the workspace locally with docker-compose (Postgres + API):

```bash
# from repo root
cd workspace/infra
docker-compose up -d

# run backend locally
cd ../backend/Api
# set connection string in appsettings.Development.json to Host=localhost if needed
dotnet restore
dotnet ef database update
dotnet run

# run frontend
cd ../../frontend
npm install
npm start
```

Notes:
- Use `dotnet ef migrations add InitialCreate` to create migrations before `database update` if none exist.
- The API listens on port 5000 (mapped to container port 80). The frontend fetches `/api/dresses` relative to same host; with Compose the network makes `api` available.
