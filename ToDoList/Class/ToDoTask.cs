using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Class
{
    public class ToDoTask
    {
        public int Id;
        public Guid UserId;
        public string Title;
        public bool IsFinished;
        public string Description;

        public ToDoTask(int id, Guid userId, string title, string description)
        {
            Id = id;
            UserId = userId;
            Title = title;
            Description = description;
            IsFinished = false;
        }
    }
}
