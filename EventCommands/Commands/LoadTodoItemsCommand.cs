﻿using EventCommands.Models;
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
        public event EventHandler? CanExecuteChanged;


        public LoadTodoItemsCommand(TodoListViewModel todoListViewModel)
        {
            this.todoListViewModel = todoListViewModel;
        }


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
            return await Task.FromResult(new[]
            {
                new TodoItems() {
                    Description = "walk the dog",
                    IsCompleted = false,
                    OwnerName = "John"
                },
                new TodoItems()
                {
                    Description = "Take out the trash.",
                    IsCompleted = false,
                    OwnerName = "Mary"
                },
                new TodoItems()
                {
                    Description = "Upload YouTube video.",
                    IsCompleted = true,
                    OwnerName = "SingletonSean"
                }
            });
        }
    }
}
