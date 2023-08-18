using BotanLike.Application.Services.Commands.Subscription;
using BotanLike.Application.Services.Commands.UserCommands;
using BotanLike.Application.Services.Common.Subscription;
using BotanLike.Application.Services.Common.UserCommon;
using BotanLike.Application.Services.Queries.UserQueries;
using BotanLike.Infrastructure;
using BotanLike.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Добавление конфигурации (нужно ли? проверить в сборке)
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

// Получаем даннные в строку подключения
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Подключаем базу данных
builder.Services.AddDbContext<BotanLikeDbContext>(options =>
                  options.UseNpgsql(connectionString));


// Add services to the container.
builder.Services.AddScoped<IUserRepository, UserRepository>(); // добавление сервиса
builder.Services.AddScoped<IUserQueryService, UserQueryService>(); // добавление сервиса
builder.Services.AddScoped<IUserCommandService, UserCommandService>(); // добавление сервиса

builder.Services.AddScoped<ISubscriptionRepository, SubscriptionRepository>(); // добавление сервиса
builder.Services.AddScoped<ISubscriptionCommandService, SubscriptionCommandService>(); // добавление сервиса

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
