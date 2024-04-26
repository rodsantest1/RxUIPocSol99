using ReactiveUI;
using Splat;
using System.Reflection;

namespace WpfApp1
{
    public partial class App
    {
        public App()
        {
            // A helper method that will register all classes that derive off IViewFor 
            // into our dependency injection container. ReactiveUI uses Splat for it's 
            // dependency injection by default, but you can override this if you like.
            Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetCallingAssembly());

            // Register services
            Locator.CurrentMutable.RegisterConstant(new MyAppState(), typeof(IMyAppState));

            // Retrieve services
            var myService = Locator.Current.GetService<IMyAppState>();

            var x = myService.MyProperty;
        }
    }

    internal class MyAppState : IMyAppState
    {
        string _savingTime;
        public MyAppState()
        {
            _savingTime = DateTime.Now.ToString();
        }

        public string? MyProperty { get => $"Hello Locator {_savingTime}"; }
    }

    internal interface IMyAppState
    {
        public string MyProperty { get; }
    }
}
