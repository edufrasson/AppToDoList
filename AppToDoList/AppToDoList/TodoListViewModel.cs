using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppToDoList
{
    public class TodoListViewModel
    {
        public ObservableCollection<TodoItem> TodoItems { get; set; }
        public TodoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();
        }
        
        public ICommand AddTodoCommand => new Command(AddTodoItem);
        public string NewTodoInputValue { get; set; }
        void AddTodoItem()
        {
            TodoItems.Add(new TodoItem(NewTodoInputValue, false));            
        }
        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);
        void RemoveTodoItem(object o)
        {
            TodoItem todoItemBeingRemoved = o as TodoItem;
            TodoItems.Remove(todoItemBeingRemoved);
        }
    }
}
