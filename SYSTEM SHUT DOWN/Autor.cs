using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SYSTEM_SHUT_DOWN
{
    public partial class Autor : Form
    {
        int TogMove;
        int MValX;
        int MValY;

        public Autor()
        {
            InitializeComponent();
        }

       

        private void Autor_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void Autor_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {

                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void Autor_MouseDown(object sender, MouseEventArgs e)
        {
            {
                TogMove = 1;
                MValX = e.X;
                MValY = e.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/bartosz.janiuk");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://plus.google.com/u/0/112135581555658477417?tab=wX"); 

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/bartosz-janiuk-89265717b/");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/archeonV9");
            
        }

        
    }
}
