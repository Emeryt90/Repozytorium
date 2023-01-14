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

namespace ToDoList.Forms
{
    public partial class ToDoTaskForm : Form
    {
        public ToDoTask ToDoTask;

        public bool IfSaved;

        public ToDoTaskForm(ToDoTask task)
        {
            InitializeComponent();

            ToDoTask = task;
            lblNumber.Text = task.Id.ToString();
            tbName.Text = task.Title;
            tbDescription.Text = task.Description;
            cbReady.Checked = task.IsFinished;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ToDoTask.Title = tbName.Text;
            ToDoTask.Description = tbDescription.Text;
            ToDoTask.IsFinished = cbReady.Checked;
            IfSaved = true;
            Close();
        }
    }
}
