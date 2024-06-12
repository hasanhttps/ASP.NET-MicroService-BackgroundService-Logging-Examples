using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using ProductCommandMicroService.DbContexts;
using ProductCommandMicroService.BackgroundServices;
using ProductCommandMicroService.Repositories.Abstracts;
using ProductCommandMicroService.Repositories.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProductDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("default")).UseLazyLoadingProxies();
});

builder.Services.AddHostedService<DateTimeLogWriter>();

builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<Program>());

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