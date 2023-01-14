using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hasło
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string haslo = tbhaslo.Text;
            //1. Hasło jest puste
            //2. hasło jest zbyt krótkie
            //3. hasło zawiera nie dopuszczalne znaki
            //4.hasło jest poprawne
            if (string.IsNullOrWhiteSpace(haslo))
            {
                MessageBox.Show("Hasło jest puste");
            }
            else if (haslo.Length<5 || haslo.Length>15)
            {
                MessageBox.Show("Hasło zawiera niedopuszczalne znaki");
            }
            else if (haslo.Contains("?") || haslo.Contains("!") ||haslo.Contains("-"))
            {
                MessageBox.Show("Hasło jest zbyt krótkie ");
            }
            else
            {
                MessageBox.Show("hasło jest zgodne");
            }
            
        }
    }
}
