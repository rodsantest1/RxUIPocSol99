using ReactiveUI;
using System.Reactive.Disposables;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : ReactiveUserControl<UserControl2ViewModel>
    {
        public UserControl2()
        {
            InitializeComponent();

            this
                .WhenActivated(
                    disposables =>
                    {
                        this
                           .BindCommand(this.ViewModel, x => x.BackCommand, x => x.BackButton)
                           .DisposeWith(disposables);

                    });
        }
    }
}
