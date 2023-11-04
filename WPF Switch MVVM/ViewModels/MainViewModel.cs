using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Switch_MVVM.ViewModels
{
    public class MainViewModel: BaseViewModel
    {
        public BaseViewModel SelectedViewModel { get; set; }

        public MainViewModel()
        {
            SelectedViewModel = new HomeViewModel();
        }

    }
}
