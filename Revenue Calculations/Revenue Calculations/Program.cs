using Microsoft.EntityFrameworkCore;
using Revenue_Calculations.IRepository;
using Revenue_Calculations.IServices;
using Revenue_Calculations.Model;
using Revenue_Calculations.Repository;
using Revenue_Calculations.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRevenueService, RevenueService>();
builder.Services.AddScoped<IRevenueRepository, RevenueRepository>();
builder.Services.AddDbContext<RevenueDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
