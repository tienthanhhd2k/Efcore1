using efcore1.Models;
using Microsoft.EntityFrameworkCore;
using efcore1.Services;
using efcore1.Responsitory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StudentDbContext>(
    options => options.UseSqlServer("Server=TIXNTHXNH;Initial Catalog=DBName;Integrated Security=True")
);
builder.Services.AddTransient<IResponsitory, StudentResponsitory>();
builder.Services.AddTransient<IStudent,StudentServices>();

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
