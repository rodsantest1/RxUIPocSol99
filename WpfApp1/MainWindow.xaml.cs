using ReactiveUI;
using Splat;
using System.Reactive.Disposables;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {


            InitializeComponent();

            // Retrieve application state
            var myAppState = Locator.Current.GetService<MyAppState>();

            MyMessage.Text += $" from Main Window {myAppState.MyProperty}";


            ViewModel = new AppViewModel();

            this
                .WhenActivated(
                    disposables =>
                    {
                        this
                            .OneWayBind(this.ViewModel, x => x.UC2ViewModel, x => x.host.ViewModel)
                            .DisposeWith(disposables);
                    });
        }
    }
}