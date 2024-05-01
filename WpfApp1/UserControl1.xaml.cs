using ReactiveUI;
using System.Reactive;
using System.Reactive.Disposables;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : ReactiveUserControl<UserControl1ViewModel>
    {
        public UserControl1()
        {
            InitializeComponent();

            this
                .WhenActivated(
                    disposables =>
                    {
                        this
                           .BindCommand(this.ViewModel, x => x.LoadCommand, x => x.LoadButton)
                           .DisposeWith(disposables);

                    });
        }
    }
}
