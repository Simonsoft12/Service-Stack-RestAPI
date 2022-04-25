using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceStack;
using ServiceStack.Data;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;

[assembly: HostingStartup(typeof(ToDoApp.ConfigureDb))]

namespace ToDoApp
{
    public class ConfigureDb : IHostingStartup
    {
        // Configure Db Connection
        public void Configure(IWebHostBuilder builder) => builder
            .ConfigureServices((context, services) => {
                services.AddSingleton<IDbConnectionFactory>(new OrmLiteConnectionFactory(
                    context.Configuration.GetConnectionString("DefaultConnection")
                    ?? "Server=localhost;User Id=root;Password=admin;Database=dbtodos;Pooling=true;MinPoolSize=0;MaxPoolSize=200",
                    MySqlDialect.Provider));
            });
    }
}
