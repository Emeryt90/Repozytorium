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

namespace ToDoList.Kontrolki
{
    public partial class TasksControl : UserControl
    {
        private MainForm _mainForm;
        private User _user;

        public TasksControl(MainForm mainForm, User user)
        {
            InitializeComponent();

            _mainForm = mainForm;
            _user = user;

            lblZalogowanyWartosc.Text = user.Name;

            Dock = DockStyle.Fill;        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            _mainForm.ShowLoginControl();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
