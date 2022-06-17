using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WakeMe.Models;
using Xamarin.Forms;

namespace WakeMe.ViewModel
{
    public class ToDoListVM
    {
        public ObservableCollection<ToDoItem> ToDoItems { get; set; }
        public string NewToDoInputValue { get; set; } //Holds temporary value
        public ToDoListVM()
        {
            ToDoItems = new ObservableCollection<ToDoItem>();
            ToDoItems.Add(new ToDoItem("todo1", false));
            ToDoItems.Add(new ToDoItem("todo2", true));
            ToDoItems.Add(new ToDoItem("todo3", false));
        }
        public ICommand AddToDoCommand => new Command(AddToDoItem);
        public void AddToDoItem()
        {
            ToDoItems.Add(new ToDoItem(NewToDoInputValue,false));
            NewToDoInputValue = "";
        }
        public ICommand RemoveToDoCommand => new Command(RemoveToDoItem);
        public void RemoveToDoItem(object o )
        {
            ToDoItem item = o as ToDoItem;
            ToDoItems.Remove(item);

        }
    }
}
