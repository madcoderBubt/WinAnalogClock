using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        Pen mypen = new Pen(Color.Blue);
        System.Drawing.Graphics g = null;


        static int start_x, start_y;
        static int end_x, end_y;

        static int my_angle = 0;

        static int my_length = 100;

        private void AnalogDisplay_Paint(object sender, PaintEventArgs e)
        {
            start_x = AnalogDisplay.Width;
            start_y = AnalogDisplay.Height;

            mypen.Width = 5;

            
            //Random randomcolor = new Random();
            //mypen.Color = Color.FromArgb(randomcolor.Next(255), randomcolor.Next(255), randomcolor.Next(255));


            end_x = (int)(start_x + Math.Cos(my_angle * .017453292519) * my_length);
            end_y = (int)(start_y + Math.Sin(my_angle * .017453292519) * my_length);
            

            g.DrawLine(mypen, start_x,start_y,end_x,end_y);
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
