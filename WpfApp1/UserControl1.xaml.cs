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


            // Retrieve services
            var myAppState = Locator.Current.GetService<MyAppState>();

            MyUc1Message.Text = myAppState.MyProperty;
        }
    }
}
