using EventCommands.Models;
using EventCommands.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EventCommands.Commands
{
    public class LoadTodoItemsCommand : ICommand
    {
        private readonly TodoListViewModel todoListViewModel;

        public LoadTodoItemsCommand(TodoListViewModel todoListViewModel)
        {
            this.todoListViewModel = todoListViewModel;
        }



        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public async void Execute(object? parameter)
        {
            //--- Get todo list items from API
            IEnumerable<TodoItems> todoItems = await GetTodoItemsAsync();

            //--- Set the todo list items on the view model.
            todoListViewModel.TodoItems = new ObservableCollection<TodoItems>(todoItems);
        }

        private async Task<IEnumerable<TodoItems>> GetTodoItemsAsync()
        {

        }
    }
}
