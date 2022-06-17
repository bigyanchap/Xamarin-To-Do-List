using System;
namespace WakeMe.Models
{
    public class ToDoItem
    {
        public string ToDoText { get; set; }
        public bool Complete { get; set; }
        public ToDoItem(string toDoText, bool complete)
        {
            this.ToDoText = toDoText;
            this.Complete = complete;
        }
    }
}
