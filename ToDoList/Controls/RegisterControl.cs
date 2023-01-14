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
    public partial class RegisterControl : UserControl
    {
        private MainForm _mainForm;

        public RegisterControl(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;

            Dock = DockStyle.Fill;
        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            _mainForm.ShowLoginControl();
        }

        private void btnZarejestruj_Click(object sender, EventArgs e)
        {
            if (_mainForm.UserManager.IfLoginAvailable(tbLogin.Text))
            {
                User newUser = new User(Guid.NewGuid(), tbImie.Text, tbLogin.Text, tbHaslo.Text);
                _mainForm.UserManager.AddUser(newUser);

                _mainForm.ShowLoginControl();
            }
        }
    }
}
