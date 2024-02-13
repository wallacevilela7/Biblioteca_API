using Biblioteca_api.Business;
using Biblioteca_api.Business.Implementation;
using Biblioteca_api.Context;
using Biblioteca_api.Repository;
using Biblioteca_api.Repository.Implementation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Conexão banco de dados 
var connection = builder.Configuration["ConnectionStrings:SqlServerConnectionString"];
builder.Services.AddDbContext<SqlServerContext>(options => options.UseSqlServer(connection));

//versionamento
builder.Services.AddApiVersioning();

//adicionar serviços
builder.Services.AddScoped<ILivroBusiness, LivroBusinessImplementation>();
builder.Services.AddScoped<ILivroRepository, LivroRepositoryImplementation>();

builder.Services.AddControllers();
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
