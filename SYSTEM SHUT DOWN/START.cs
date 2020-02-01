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
    public partial class START : Form
    {



        int h; //hours
        int m; // mins
        int s; // secs

        int TogMove;
        int MValX;
        int MValY;


        public START()
        {
            InitializeComponent();
            labelHOURS.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            labelMINS.Visible = false;
            labelSECS.Visible = false;
            buttonWZNOW.Visible = false;
            panelTIME.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (numericUpDown1.Value == 0 && numericUpDown2.Value == 0 && numericUpDown3.Value == 0)
            {
                MessageBox.Show("Proszę podac czas ");
            }




            else if (string.IsNullOrEmpty(comboBox1.Text))
                {
                    MessageBox.Show("Wybierz opcje !");

                }
        
                else
                {
                
                    numericUpDown1.Visible = false;
                    numericUpDown2.Visible = false;
                    numericUpDown3.Visible = false;
                    panelTIME.Visible = true;


                    h = Convert.ToInt32(numericUpDown1.Value);
                    m = Convert.ToInt32(numericUpDown2.Value);
                    s = Convert.ToInt32(numericUpDown3.Value);

                    timer1.Start();
                    labelHOURS.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    labelMINS.Visible = true;
                    labelSECS.Visible = true;
                }
            
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            if(s == -1 )
            {
                m = m - 1;
                s = 59;
            }
            if (m == -1)
            {
                h = h - 1;
                m = 59;
            }
            if(h == 0 && m == 0 && s == 0)
                {
                timer1.Stop();

               
                if (comboBox1.Text == "Zamknij")
                {
                   System.Diagnostics.Process.Start("shutdown", "/s /f /t 0");
                }
                if (comboBox1.Text == "Uruchom ponownie")
                {
                    System.Diagnostics.Process.Start("shutdown", "/r /f /t 0");
                }
                if (comboBox1.Text == "Uśpij")
                {
                    System.Diagnostics.Process.Start("shutdown", "/h /f /t 0");
                }
                if (comboBox1.Text == "Wyloguj")
                {
                    System.Diagnostics.Process.Start("shutdown", "/l /t 0");
                }



            }
            string hh = Convert.ToString(h);
            string mm = Convert.ToString(m);
            string ss = Convert.ToString(s);

            labelHOURS.Text = hh;
            labelMINS.Text = mm;
            labelSECS.Text = ss;
        }

        private void buttonZATRZYMAJ_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            buttonWZNOW.Visible = true;
            buttonZATRZYMAJ.Visible = false;
        }

        private void buttonWZNOW_Click(object sender, EventArgs e)
        {
            timer1.Start();
            buttonWZNOW.Visible = false;
            buttonZATRZYMAJ.Visible = true;
        }

        private void buttonZAKONCZ_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimalize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void START_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void START_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void START_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {

                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }
    }
}
