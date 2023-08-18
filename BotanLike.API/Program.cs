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

// ���������� ������������ (����� ��? ��������� � ������)
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

// �������� ������� � ������ �����������
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// ���������� ���� ������
builder.Services.AddDbContext<BotanLikeDbContext>(options =>
                  options.UseNpgsql(connectionString));


// Add services to the container.
builder.Services.AddScoped<IUserRepository, UserRepository>(); // ���������� �������
builder.Services.AddScoped<IUserQueryService, UserQueryService>(); // ���������� �������
builder.Services.AddScoped<IUserCommandService, UserCommandService>(); // ���������� �������

builder.Services.AddScoped<ISubscriptionRepository, SubscriptionRepository>(); // ���������� �������
builder.Services.AddScoped<ISubscriptionCommandService, SubscriptionCommandService>(); // ���������� �������

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
