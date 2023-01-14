using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList.Kontrolki
{
    public partial class LoginControl : UserControl
    {
        private MainForm _mainForm;

        public LoginControl(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;

            Dock = DockStyle.Fill;
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            //_mainForm.ShowTasksControl();
        }

        private void btnZalozKonto_Click(object sender, EventArgs e)
        {
            _mainForm.ShowRegisterControl();
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {

        }
    }
}
