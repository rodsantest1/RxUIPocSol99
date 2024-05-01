using ReactiveUI;

namespace WpfApp1
{
    public sealed class MainWindowViewModel : ReactiveObject, IScreen
    {
        private readonly RoutingState routingState;

        public MainWindowViewModel()
        {
            this.routingState = new RoutingState();

            this.routingState.Navigate.Execute(new UserControl1ViewModel(this));
        }

        public RoutingState Router => this.routingState;
    }
}
