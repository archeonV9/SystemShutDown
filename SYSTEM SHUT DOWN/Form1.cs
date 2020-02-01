using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSTEM_SHUT_DOWN
{


    public partial class Form1 : Form
    {


        int TogMove;
        int MValX;
        int MValY;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            START startForm = new START();
            startForm.ShowDialog();


        }

        private void buttonWYJSCIE_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimalize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }




        private void Form1_MouseUp_1(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {

                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Autor Autor = new Autor();
            Autor.ShowDialog();
        }
    }
}
