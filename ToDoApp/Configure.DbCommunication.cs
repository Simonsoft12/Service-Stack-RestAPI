using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceStack;
using ServiceStack.Data;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;
using ToDoApp.ServiceModel.Types;

[assembly: HostingStartup(typeof(ToDoApp.ConfigureDbCommunication))]

namespace ToDoApp
{
    public class ConfigureDbCommunication : IHostingStartup
    {
        // Create Db Table and Insert a record
        public void Configure(IWebHostBuilder builder) => builder
            .ConfigureAppHost(appHost =>
            {
                using var db = appHost.Resolve<IDbConnectionFactory>().Open();
                if (db.CreateTableIfNotExists<Todo>())
                {
                    db.Insert(new Todo {
                        Id = 1,
                        Title = "Go Shopping",
                        Description = "Auto Generated Todo",
                        Percentage = 0,
                        DateTo = DateTime.Now.AddDays(7),
                        Done = false
                    });
                }
            });
    }
}



