using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Class
{
    public class ToDoTaskManager
    {
        private List<ToDoTask> _allTasks;

        public ToDoTaskManager()
        {
            _allTasks = new List<ToDoTask>();
        }

        public void AddToDoTask(ToDoTask task)
        {
            _allTasks.Add(task);
        }

        public void RemoveToDoTask(int taskId)
        {
            ToDoTask task = FindToDoTask(taskId);
            _allTasks.Remove(task);
        }

        public ToDoTask FindToDoTask(int id)
        {
            foreach (ToDoTask task in _allTasks)
            {
                if(task.Id == id)
                {
                    return task;
                }
            }

            return null;
        }

        public List<ToDoTask> GetUserTasks(Guid userId)
        {
            List<ToDoTask> tempTasksList = new List<ToDoTask>();
            foreach (ToDoTask task in _allTasks)
            {
                if(task.UserId == userId)
                {
                    tempTasksList.Add(task);
                }
            }

            return tempTasksList;
        }

        public int CalculateNextId()
        {
            int max = 0;

            foreach (ToDoTask task in _allTasks)
            {
                if (task.Id > max)
                {
                    max = task.Id;
                }
            }

            return max + 1;
        }
    }
}
