﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_Switch_MVVM.ViewModels;

namespace WPF_Switch_MVVM.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if(parameter.ToString()=="Home")
            {
                viewModel.SelectedViewModel = new HomeViewModel();
            }
            else
            {
                viewModel.SelectedViewModel = new AccountViewModel();
            }
        }
    }
}
