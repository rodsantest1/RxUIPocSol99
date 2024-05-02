using ReactiveUI;
using System.Reactive;

namespace WpfApp1
{
    public class UserControl2ViewModel : ReactiveObject, IRoutableViewModel
    {
        IScreen _hostScreen;
        public UserControl2ViewModel(IScreen hostScreen)
        {
            _hostScreen = hostScreen;
        }
        public string? UrlPathSegment => "test";

        public IScreen HostScreen => _hostScreen;

        public ReactiveCommand<Unit, IRoutableViewModel> BackCommand => _hostScreen.Router.NavigateBack;

    }
}
