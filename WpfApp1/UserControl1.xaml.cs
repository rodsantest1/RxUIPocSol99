using ReactiveUI;
using Splat;
using System.Reactive.Disposables;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1
    {
        public UserControl1()
        {
            InitializeComponent();


            // Retrieve application state
            var myAppState = Locator.Current.GetService<MyAppState>();

            MyUc1Message.Text += $" from User Control1 {myAppState.MyProperty}";


            this
                .WhenActivated(
                    disposables =>
                    {
                        this
                            .BindCommand(this.ViewModel, x => x.AddDinosaurCommand, x => x.Button1)
                            .DisposeWith(disposables);

                        this
                            .Bind(this.ViewModel, x => x.MyPropertyOnVM1, x => x.MyUc1Message.Text)
                            .DisposeWith(disposables);
                    });
        }

    }
}
