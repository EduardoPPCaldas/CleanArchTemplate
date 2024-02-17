using CleanApi.Application;
using CleanApi.Domain;
using CleanApi.Infrastructure;
using CleanApi.WebApi;
using CleanApi.WebApi.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddWebApiServices()
    .AddInfrastructureServices()
    .AddApplicationServices()
    .AddDomainServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.AddWeatherForecastEndpoints();

app.UseHttpsRedirection();

app.Run();
