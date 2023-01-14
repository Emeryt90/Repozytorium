using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Class;
using ToDoList.Forms;

namespace ToDoList.Kontrolki
{
    public partial class TasksControl : UserControl
    {
        private MainForm _mainForm;
        private User _user;
        private ToDoTaskManager _toDoTaskManager;

        public TasksControl(MainForm mainForm, User user)
        {
            InitializeComponent();

            _mainForm = mainForm;
            _user = user;

            _toDoTaskManager = new ToDoTaskManager();

            lblZalogowanyWartosc.Text = user.Name;

            Dock = DockStyle.Fill;        }

        private void AddTaskToListView(ToDoTask task)
        {
            ListViewItem item = new ListViewItem(task.Id.ToString());
            item.SubItems.Add(task.Title);

            string ready = task.IsFinished ? "✓" : "✕";
            //string ready = string.Empty;
            //if (task.IsFinished)
            //{
            //    ready = "✓";
            //}
            //else
            //{
            //    ready = "✕";
            //}
            item.SubItems.Add(ready);

            lvZadania.Items.Add(item);
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            _mainForm.ShowLoginControl();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = _toDoTaskManager.CalculateNextId();
            ToDoTask newTask = new ToDoTask(id, _user.Id, "", "");

            ToDoTaskForm taskForm = new ToDoTaskForm(newTask);
            taskForm.ShowDialog();

            if (taskForm.IfSaved)
            {
                _toDoTaskManager.AddToDoTask(newTask);
                AddTaskToListView(newTask);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(lvZadania.SelectedItems.Count == 0)
            {
                MessageBox.Show("Najpierw zaznacz zadanie!");
            }
            else
            {
                string taskId = lvZadania.SelectedItems[0].SubItems[0].Text;
                ToDoTask task = _toDoTaskManager.FindToDoTask(int.Parse(taskId));
                ToDoTaskForm taskForm = new ToDoTaskForm(task);
                taskForm.ShowDialog();

                if (taskForm.IfSaved)
                {
                    lvZadania.SelectedItems[0].SubItems[1].Text = task.Title;
                    lvZadania.SelectedItems[0].SubItems[2].Text = task.IsFinished ? "✓" : "✕";

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lvZadania.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano zadania do skasowania!");
            }
            else
            {
                string taskId = lvZadania.SelectedItems[0].SubItems[0].Text;
                _toDoTaskManager.RemoveToDoTask(int.Parse(taskId));
                lvZadania.Items.Remove(lvZadania.SelectedItems[0]);
            }
        }
    }
}
