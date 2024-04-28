using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Reactive;

namespace WpfApp1
{

    public class UserControl1ViewModel : ReactiveObject, IScreen
    {
        private readonly ReactiveCommand<Unit, Unit> addDinosaurCommand;


        public RoutingState Router { get; }

        public UserControl1ViewModel()
        {
            //Router = new RoutingState();
            //Router.Navigate.Execute(new UserControl2ViewModel());

            this.addDinosaurCommand = ReactiveCommand.Create(
                () => {
                    this.MyPropertyOnVM1 += " Reactive Command ";
                });
        }

        public ReactiveCommand<Unit, Unit> AddDinosaurCommand => this.addDinosaurCommand;

        [Reactive]public string MyPropertyOnVM1 { get; set; }
    }
}
