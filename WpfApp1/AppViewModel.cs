    using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class AppViewModel : ReactiveObject
    {
        public UserControl1ViewModel UC1ViewModel { get; set; } = new UserControl1ViewModel();
        public UserControl2ViewModel UC2ViewModel { get; set; } = new UserControl2ViewModel();
    }
}
