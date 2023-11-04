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
        private BaseViewModel selectedViewModel;
        
        public BaseViewModel SelectedViewModel 
        { 
            get { return selectedViewModel; } 
            set 
            {
                selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            } 
        }

        public ICommand UpdateViewCommand { get; set; }

        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);

        }


    }
}
