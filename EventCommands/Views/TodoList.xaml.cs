﻿using EventCommands.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EventCommands.Views
{
    /// <summary>
    /// Lógica de interacción para TodoList.xaml
    /// </summary>
    public partial class TodoList : UserControl
    {
        
        public ICommand LoadCommand
        { 
            get { return (ICommand)GetValue(LoadCommandProperty); }
            set { SetValue(LoadCommandProperty, value); } 
        }

        public static readonly DependencyProperty LoadCommandProperty =
            DependencyProperty.Register("LoadCommand", typeof(ICommand), typeof(TodoList), new PropertyMetadata(null));

        public TodoList()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, System.Windows.RoutedEvent e)
        {
            if(LoadCommand != null)
            {
                LoadCommand.Execute(null);
            }
        }
    }
}
