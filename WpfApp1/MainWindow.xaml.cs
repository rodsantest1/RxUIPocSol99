using ReactiveUI;
using System.Reactive.Disposables;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();

            ViewModel = new MainWindowViewModel();

            this
                .WhenActivated(
                    disposables =>
                    {
                        this
                            .OneWayBind(this.ViewModel, x => x.Router, x => x.routedViewHost.Router)
                            .DisposeWith(disposables);
                    });
        }
    }
}