using ReactiveUI;

namespace WpfApp1
{
    public class UserControl1ViewModel : ReactiveObject, IRoutableViewModel
    {
        IScreen _hostScreen;

        public UserControl1ViewModel(IScreen hostScreen)
        {
            _hostScreen = hostScreen;
        }

        public string? UrlPathSegment => "blurb";

        public IScreen HostScreen => _hostScreen;
    }
}
