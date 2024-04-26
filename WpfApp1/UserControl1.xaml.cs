using ReactiveUI;
using Splat;

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
                        
                    });
        }

        private void Button1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            
        }
    }
}
