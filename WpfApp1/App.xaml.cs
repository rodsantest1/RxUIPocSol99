using Microsoft.Extensions.Configuration;
using ReactiveUI;
using Splat;
using System.Configuration;
using System.IO;
using System.Reflection;

namespace WpfApp1
{
    public partial class App
    {
        public IConfiguration Configuration { get; private set; }
        public App()
        {
            // A helper method that will register all classes that derive off IViewFor 
            // into our dependency injection container. ReactiveUI uses Splat for it's 
            // dependency injection by default, but you can override this if you like.
            Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetCallingAssembly());

            // Register services
            Locator.CurrentMutable.RegisterConstant(new MyAppState());

            // Retrieve services
            var myService = Locator.Current.GetService<MyAppState>();

            //var x = myService.MyProperty;

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();

            // Now you can access settings like this:
            var mySetting = Configuration["hello"];

            myService.MyProperty += $" Hello Locator {mySetting}";
        }
    }

    internal class MyAppState
    {
        string _savingTime;
        public MyAppState()
        {
            _savingTime = DateTime.Now.ToString();
            MyProperty = $"Hello {_savingTime}";
        }

        public string MyProperty { get; set; }

    }

}
