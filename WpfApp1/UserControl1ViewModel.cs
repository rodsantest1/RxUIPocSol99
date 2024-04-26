using ReactiveUI;

namespace WpfApp1
{

    public class UserControl1ViewModel : ReactiveObject, IScreen
    {
        public RoutingState Router { get; }

        public UserControl1ViewModel()
        {
            //Router = new RoutingState();
            //Router.Navigate.Execute(new UserControl2ViewModel());
        }
    }
}
