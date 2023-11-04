using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_Switch_MVVM.Commands;

namespace WPF_Switch_MVVM.ViewModels
{
    public class MainViewModel: BaseViewModel
    {
        public BaseViewModel SelectedViewModel { get; set; }

        public ICommand UpdateViewCommand { get; set; }

        public MainViewModel()
        {
            SelectedViewModel = new HomeViewModel();
            UpdateViewCommand = new UpdateViewCommand(this);

        }


    }
}
