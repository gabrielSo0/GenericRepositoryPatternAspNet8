using Microsoft.EntityFrameworkCore;
using RepositoryPatternExample.Data;
using RepositoryPatternExample.Repository.Generic;
using RepositoryPatternExample.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Database configuration
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<DatabaseContext>(options => 
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(EfCoreRepository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
