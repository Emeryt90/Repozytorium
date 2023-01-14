using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kułko_i_krzyrzyk
{
    public partial class Form1 : Form
    {
        private bool czyj_ruch = true;

        public Form1()
        
        {
            InitializeComponent();
            ResetujPlansze();
        }
        public void WstawZnak(object przycisk)
        {
            Button wcisnietyPrzycisk = (Button)przycisk;
            if (czyj_ruch)
            {
                wcisnietyPrzycisk.Text = "O";
            }
            else
            {
                wcisnietyPrzycisk.Text = "X";
            }

            wcisnietyPrzycisk.Enabled = false;

            bool wynik = SprawdzCzyKtosWygral();

            if(wynik == true)
            {
                string tekstWygranej;
                if (czyj_ruch)
                {
                    tekstWygranej = "wygrał gracz O! Czy rozpoczać kolejną partię?";
                }
                else
                {
                    tekstWygranej = "wygrał gracz X! Czy rozpoczać kolejną partię?";
                }
                DialogResult odp = MessageBox.Show(tekstWygranej, "Koniec gry!", MessageBoxButtons.YesNo);
                if(odp == DialogResult.Yes)
                {
                    ResetujPlansze(); 
                }
                else
                {
                    WylaczWszystkiePrzyciski();
                }
            }
            czyj_ruch = !czyj_ruch;
            if(czyj_ruch)
            {
                lblCzyjRuch.Text = "O";
            }
            else
            {
                lblCzyjRuch.Text = "X";
            }


        }

        private void ResetujPlansze()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void WylaczWszystkiePrzyciski()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private bool SprawdzCzyKtosWygral()
        {
            
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                return true;
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                return true;
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                return true;
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                return true;
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                return true;
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                return true;
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                return true;
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }
    }
}
