using ServiceStack;

[assembly: HostingStartup(typeof(ToDoApp.ConfigureAutoQuery))]

namespace ToDoApp
{
    public class ConfigureAutoQuery : IHostingStartup
    {
        // Configure AutoQuery
        public void Configure(IWebHostBuilder builder) => builder
            .ConfigureAppHost(appHost => {
                appHost.Plugins.Add(new AutoQueryFeature
                {
                    MaxLimit = 1000,
                    IncludeTotal = true
                });
            });
    }
}