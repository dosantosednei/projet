using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static projetoleds.leds;

namespace projetoleds
{
    public partial class Form1 : Form
    {
        private Leds leds;

        const int ENDERECO_PORTA = 888;
        
        public Form1()
        {
            InitializeComponent();
            leds = new Leds();
            atualizaInterface();
        }

        

        private void atualizaInterface()
        {

        try
            {
                Paralela.EnviarSinal(ENDERECO_PORTA, controleLeds.GetEstadoAtual());
            }
            catch
            {
                
            }


            
            txtDadoDec.Text = leds.getDado().ToString();
            txtDadoBin.Text = Convert.ToString(leds.getDado(), 2);
            txtDadoHex.Text = Convert.ToString(leds.getDado(), 16).ToUpper();
            btnLed1.Text = (leds.getLed(1) ? "Off" : "On");
            btnLed2.Text = (leds.getLed(2) ? "Off" : "On");
            btnLed3.Text = (leds.getLed(3) ? "Off" : "On");
            btnLed4.Text = (leds.getLed(4) ? "Off" : "On");
            btnLed5.Text = (leds.getLed(5) ? "Off" : "On");
            btnLed6.Text = (leds.getLed(6) ? "Off" : "On");
            btnLed7.Text = (leds.getLed(7) ? "Off" : "On");
            btnLed8.Text = (leds.getLed(8) ? "Off" : "On");
            pictureBox1.Image = (leds.getLed(1) ? Properties.Resources.download_acesa : Properties.Resources.download);
            pictureBox2.Image = (leds.getLed(2) ? Properties.Resources.download_acesa : Properties.Resources.download);
            pictureBox3.Image = (leds.getLed(3) ? Properties.Resources.download_acesa : Properties.Resources.download);
            pictureBox4.Image = (leds.getLed(4) ? Properties.Resources.download_acesa : Properties.Resources.download);
            pictureBox5.Image = (leds.getLed(5) ? Properties.Resources.download_acesa : Properties.Resources.download);
            pictureBox6.Image = (leds.getLed(6) ? Properties.Resources.download_acesa : Properties.Resources.download);
            pictureBox7.Image = (leds.getLed(7) ? Properties.Resources.download_acesa : Properties.Resources.download);
            pictureBox8.Image = (leds.getLed(8) ? Properties.Resources.download_acesa : Properties.Resources.download);
        }

        private void btnLed1_Click(object sender, EventArgs e)
        {
            if (leds.getLed(1))
            {
                leds.apagar(1);
            }
            else
            {
                leds.acender(1);
            }
            atualizaInterface();
        }

        private void btnLed2_Click(object sender, EventArgs e)
        {
            if (leds.getLed(2))
            {
                leds.apagar(2);
            }
            else
            {
                leds.acender(2);
            }
            atualizaInterface();
        }

        private void btnLed3_Click(object sender, EventArgs e)
        {
            if (leds.getLed(3))
            {
                leds.apagar(3);
            }
            else
            {
                leds.acender(3);
            }
            atualizaInterface();
        }
        private void btnLed4_Click(object sender, EventArgs e)
        {
            if (leds.getLed(4))
            {
                leds.apagar(4);
            }
            else
            {
                leds.acender(4);
            }
            atualizaInterface();
        }
        private void btnLed5_Click(object sender, EventArgs e)
        {
            if (leds.getLed(5))
            {
                leds.apagar(5);
            }
            else
            {
                leds.acender(5);
            }
            atualizaInterface();
        }
        private void btnLed6_Click(object sender, EventArgs e)
        {
            if (leds.getLed(6))
            {
                leds.apagar(6);
            }
            else
            {
                leds.acender(6);
            }
            atualizaInterface();
        }
        private void btnLed7_Click(object sender, EventArgs e)
        {
            if (leds.getLed(7))
            {
                leds.apagar(7);
            }
            else
            {
                leds.acender(7);
            }
            atualizaInterface();
        }
        private void btnLed8_Click(object sender, EventArgs e)
        {
            if (leds.getLed(8))
            {
                leds.apagar(8);
            }
            else
            {
                leds.acender(8);
            }
            atualizaInterface();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
       
        
}

