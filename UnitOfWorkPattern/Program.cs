using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text.Json.Serialization;
using UnitOfWorkPattern.Context;
using UnitOfWorkPattern.Contracts.Common;
using UnitOfWorkPattern.Repositories.Common;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
    });

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

#region DbContext_Config
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//{
//    options
//        .UseSqlServer(configuration.GetConnectionString("DbConnectionString"));
//});


builder.Services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer("Name=DbConnectionString"));

#endregion

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
