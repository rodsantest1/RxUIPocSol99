using ReactiveUI;

namespace WpfApp1
{

    public class UserControl1ViewModel : ReactiveObject, IScreen
    {
        public string MyPropertyOnVM1 { get; set; }


        public RoutingState Router { get; }

        public UserControl1ViewModel()
        {
            //Router = new RoutingState();
            //Router.Navigate.Execute(new UserControl2ViewModel());
        }
    }
}
