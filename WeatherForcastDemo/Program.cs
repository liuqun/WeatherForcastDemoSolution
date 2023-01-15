using Microsoft.EntityFrameworkCore;
using WeatherForcastDemo.DbContexts;

var builder = WebApplication.CreateBuilder(args);

#region MySQL database config 
{
    const string FailSafeConnectionString = "";
    string connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? FailSafeConnectionString;
    var ver = ServerVersion.Parse("5.6.20-mysql");
    var queryTrackingBehavior = QueryTrackingBehavior.NoTracking;

    void myDbContextOptionsAction(DbContextOptionsBuilder options)
    {
        options.UseQueryTrackingBehavior(queryTrackingBehavior);
        options.UseMySql(connectionString, ver);
    }
    builder.Services.AddDbContext<BookShopDbContext>(optionsAction: myDbContextOptionsAction);
    builder.Services.AddEntityFrameworkMySql();
}
#endregion

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

app.UseAuthorization();

app.MapControllers();

app.Run();
