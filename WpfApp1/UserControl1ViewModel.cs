using ReactiveUI;
using System.Reactive;
using System.Reactive.Linq;

namespace WpfApp1
{
    public class UserControl1ViewModel : ReactiveObject, IRoutableViewModel
    {
        IScreen _hostScreen;
        private readonly ReactiveCommand<Unit, Unit> loadCommand;


        public UserControl1ViewModel(IScreen hostScreen)
        {
            _hostScreen = hostScreen;

            this.loadCommand = ReactiveCommand.Create(() => {
                this._hostScreen.Router.Navigate.Execute(new UserControl2ViewModel(_hostScreen)).Select(_=>Unit.Default);
            });

        }

        public string? UrlPathSegment => "blurb";

        public IScreen HostScreen => _hostScreen;

        public ReactiveCommand<Unit, Unit> LoadCommand => this.loadCommand;

    }
}
