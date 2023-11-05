using EventCommands.Commands;
using EventCommands.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EventCommands.ViewModels
{
    public class TodoListViewModel : ObservableObject
    {
        private ObservableCollection<TodoItems> todoItems;

        public ObservableCollection<TodoItems> TodoItems
        { 
            get { return todoItems; } 
            set {  todoItems = value; 
                OnPropertyChanged(nameof(TodoItems));
            } 
        }

        public ICommand LoadTodoItemsCommand { get; set; }

        public TodoListViewModel()
        {
            LoadTodoItemsCommand = new LoadTodoItemsCommand(this);

        }
    }
}
