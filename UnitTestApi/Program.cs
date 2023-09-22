using Microsoft.EntityFrameworkCore;
using UnitTestApi.Data;
using UnitTestApi.Service;
using UnitTestMoqFinal.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connnectionString = builder.Configuration.GetConnectionString("DefaultConnections");
builder.Services.AddDbContext<ProductDbContext>(options => options.UseSqlServer(connnectionString));
builder.Services.AddControllers().AddNewtonsoftJson(options =>
  options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddScoped<IProductService,ProductService>();
builder.Services.AddScoped<ProductRepository>();


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
