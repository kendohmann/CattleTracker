using Microsoft.EntityFrameworkCore;
using Api.Data;

var builder = WebApplication.CreateBuilder(args);

// Configure Postgres connection
var conn = builder.Configuration.GetConnectionString("DefaultConnection") ?? "Host=postgres;Database=weddb;Username=postgres;Password=postgres";
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(conn));

builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();

app.Run();
