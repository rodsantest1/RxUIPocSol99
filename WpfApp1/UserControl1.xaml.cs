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
            var myService = Locator.Current.GetService<MyAppState>();

            MyUc1Message.Text = myService.MyProperty;
        }
    }
}
