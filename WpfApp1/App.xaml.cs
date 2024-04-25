using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReactiveUI;
using Splat;
using System.IO;
using System.Reflection;
using System.Windows;

namespace WpfApp1
{
    public partial class App
    {

        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            ServiceCollection serices = new();
            ConfigureServices(serices);
            _serviceProvider = serices.BuildServiceProvider();
        }

        private IConfiguration AddConfiguration()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

#if DEV
            Console.WriteLine("Hello Dev");
            builder.AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);
#elif PROD
            Console.WriteLine("Hello Prod");
            builder.AddJsonFile("appsettings.Production.json", optional: true, reloadOnChange: true);
#endif

            return builder.Build();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<MainWindow>();

            services.AddSingleton<IConfiguration>(AddConfiguration());
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // A helper method that will register all classes that derive off IViewFor 
            // into our dependency injection container. ReactiveUI uses Splat for it's 
            // dependency injection by default, but you can override this if you like.
            Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetCallingAssembly());

            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow?.Show();
        }
    }

}