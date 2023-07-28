using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using ShopOnline.Api.Data;
using ShopOnline.Api.Repositories;
using ShopOnline.Api.Repositories.Contracts;

var builder = WebApplication.CreateBuilder(args);

//定义数据库连接字符串是appsettings.json中的DefaultConnection
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//添加数据库上下文服务
builder.Services.AddDbContext<ShopOnlineDbContext>(options => options.UseSqlServer(connectionString));


builder.Services.AddScoped<IProductRespository, ProductRespository>();

builder.Services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();

// Add services to the container.

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

app.UseCors(policy =>

    policy.WithOrigins("https://localhost:7011", "https://localhost:7011")
    .AllowAnyMethod().WithHeaders(HeaderNames.ContentType)
);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
