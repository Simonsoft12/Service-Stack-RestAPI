using ServiceStack;
using ServiceStack.Validation;

[assembly: HostingStartup(typeof(ToDoApp.ConfigureValidation))]

namespace ToDoApp
{
    public class ConfigureValidation : IHostingStartup
    {
        // Validation
        public void Configure(IWebHostBuilder builder) => builder
            .ConfigureAppHost(appHost => {
                appHost.Plugins.Add(new ValidationFeature
                {
                    EnableDeclarativeValidation = true
                });
            });
    }
}