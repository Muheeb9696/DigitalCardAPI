using DigitalCard.DBContext;
using DigitalCard.Interfaces;
using DigitalCard.IReporsitory;
using DigitalCard.Repository;
using ServiceTier.Application;
using ServiceTier.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Add services to the container.
//builder.Services.AddSingleton<DapperDBContext>();


//builder.Services.AddTransient<IDapperDbConnection, DapperDBContext>();
//builder.Services.AddTransient<INevigation, NevigationRepository>();

builder.Services.AddApplication();
builder.Services.AddInfrastructure();
builder.Services.AddControllers();
builder.Services.AddCors();
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
app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

app.Run();
