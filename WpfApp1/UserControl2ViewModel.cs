using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using System.Reactive;

namespace WpfApp1
{
    public class UserControl2ViewModel : ReactiveObject, IRoutableViewModel
    {
        MyAppState myService = Locator.Current.GetService<MyAppState>();

        IScreen _hostScreen;
        public UserControl2ViewModel(IScreen hostScreen)
        {
            _hostScreen = hostScreen;
            MyUC2Message = myService.MyProperty;
        }
        public string? UrlPathSegment => "test";

        public IScreen HostScreen => _hostScreen;

        public ReactiveCommand<Unit, IRoutableViewModel> BackCommand => _hostScreen.Router.NavigateBack;

        [Reactive] public string MyUC2Message { get; set; }


    }
}
