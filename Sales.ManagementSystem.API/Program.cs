using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Sales.ManagementSystem.API.Product.Validators;
using Sales.ManagementSystem.Data;
using Sales.ManagementSystem.Shared.Product.InputModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<SalesContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("SalesDB")));
builder.Services
    .AddControllers();
// Add Validators
builder.Services.AddScoped<IValidator<CreateProductInputModel>, CreateProductInputModelValidator>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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