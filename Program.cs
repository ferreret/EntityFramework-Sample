using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using projectef;

var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddDbContext<TareasContext>(p => p.UseInMemoryDatabase("TareasDB"));

var sqlConBuilder = new SqlConnectionStringBuilder();
sqlConBuilder.ConnectionString = builder.Configuration.GetConnectionString("SqlDbConnection");
sqlConBuilder.UserID = builder.Configuration["UserId"];
sqlConBuilder.Password = builder.Configuration["Password"];

// builder.Services.AddSqlServer<TareasContext>("Data Source=server;Initial Catalog=TareasDb;user id=sa; password=Password12!");
builder.Services.AddDbContext<TareasContext>(opt => opt.UseSqlServer(sqlConBuilder.ConnectionString));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");


app.MapGet("/dbconexion", async ([FromServices] TareasContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok($"Base de datos en memoria: {dbContext.Database.IsInMemory().ToString()}");
});

app.Run();
