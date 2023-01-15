using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ModuleInitializerExtensions
    {
        //public static IServiceCollection AddCustomizedDbContexts(this IServiceCollection serviceCollection)
        //{
        //    var configurationBuilder = new ConfigurationBuilder();
        //    //FIXME: 此处没有考虑加载多种配置appsettings.Development.json
        //    configurationBuilder.AddJsonFile("appsettings.json");
        //    var configuration = configurationBuilder.Build();
        //    string failSafeConnectionString = "";
        //    string connectionString = configuration.GetConnectionString("DefaultConnection") ?? failSafeConnectionString;
        //    var ver = ServerVersion.Parse("5.6.20-mysql");
        //    var queryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        //    serviceCollection.AddDbContext<WeatherForcastDemo.DbContexts.BookShopDbContext>(options => {
        //        options.UseQueryTrackingBehavior(queryTrackingBehavior);
        //        options.UseMySql(connectionString, ver);
        //    });
        //    return serviceCollection;
        //}
    }
}
