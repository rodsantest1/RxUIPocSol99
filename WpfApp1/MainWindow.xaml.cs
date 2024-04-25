using Microsoft.Extensions.Configuration;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly IConfiguration _config;

        public MainWindow(IConfiguration config)
        {
            InitializeComponent();
            ViewModel = new AppViewModel();

            _config = config;

            MyMessage.Text = $"Hello {_config.GetValue<string>("hello")}";
        }
    }
}