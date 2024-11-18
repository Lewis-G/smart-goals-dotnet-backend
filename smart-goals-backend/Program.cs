using smart_goals_backend.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SiteContext>(options =>
{
    options.UseInMemoryDatabase("App");
});

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
