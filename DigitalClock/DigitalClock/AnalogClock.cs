using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class AnalogClock : Form
    {
        Bitmap img;
        Graphics g;
        int start_x, start_y;
        
        //int end_x, end_y;
        //int myAngle = 6;


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DESIGNED BY\nSudhananda Biswas\nA Professional Programmer","About Me!",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }

        public AnalogClock()
        {
            InitializeComponent();
            Thread.Sleep(6);
            t.Tick += new EventHandler(this.t_Tick);
            label1.Text = DateTime.Now.DayOfWeek.ToString();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            img = new Bitmap(AnalogDisplay.Width, AnalogDisplay.Height);
            g = Graphics.FromImage(img);

            g.Clear(Color.Black);

            //g.DrawString("3", DefaultFont, Brushes.Green, new Point(start_x + 105, start_y - 5));

            start_x = AnalogDisplay.Width / 2;
            start_y = AnalogDisplay.Height / 2;

            DrawClock();

            //end_x = (int)(start_x + Math.Sin(myAngle * (Math.PI / 180)) * 90);
            //end_y = (int)(start_y + Math.Cos(myAngle * (Math.PI / 180)) * 90);
            //myAngle += 6;

            //int ss = DateTime.Now.Second;
            //int[] c = msCoord(ss, 90);
            //end_x = c[0];
            //end_y = c[1];

            //my_Angle.Text = (int.Parse(my_Angle.Text) + 1).ToString();

            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;

            //Point ssCoord = msCoord(ss, 90);
            //Point mmCoord = msCoord(mm, 60);
            //Point hhCoord = hrCoord(hh, mm, 30);

            int[] coord = msCoord(ss, 90);
            Point ssCoord = new Point(coord[0], coord[1]);
            coord = msCoord(mm, 70);
            Point mmCoord = new Point(coord[0], coord[1]);
            Point hhCoord = hrCoord(hh, mm, 45);

            //second
            g.DrawLine(new Pen(Color.WhiteSmoke, 1f), new Point(start_x, start_y), ssCoord);
            //Minute
            g.DrawLine(new Pen(Color.Red, 1.5f), new Point(start_x, start_y), mmCoord);
            //Hour
            g.DrawLine(new Pen(Color.SkyBlue, 2f), new Point(start_x, start_y), hhCoord);


            g.FillEllipse(Brushes.DarkSlateGray, start_x - 5, start_y - 5, 10, 10);

            this.Text = DateTime.Now.ToShortTimeString();
            my_Angle.Text = DateTime.Now.ToLongTimeString() +"  "+ DateTime.Now.ToShortDateString();

            AnalogDisplay.Image = img;
        }

        private void DrawClock()
        {
            //Draw Clock
            for (int i = 0; i < 60; i++)
            {
                int[] lcoord = msCoord(i, 100);
                Point ssCoord = new Point(lcoord[0], lcoord[1]);
                if (i == 0 || i == 15 || i == 30 || i == 45)
                {
                    g.DrawLine(new Pen(Color.DarkGoldenrod, 1f), new Point(start_x, start_y), ssCoord);
                }
                else if (i == 5 || i == 10 || i == 20 || i == 25 || i == 35 || i == 40 || i == 50 || i == 55)
                {
                    g.DrawLine(new Pen(Color.Green, 1f), new Point(start_x, start_y), ssCoord);
                }
                else
                {
                    g.DrawLine(new Pen(Color.Blue, 1f), new Point(start_x, start_y), ssCoord);
                }
                
            }

            int[] coord = new int[2];

            coord = msCoord(0, 114);
            g.DrawString("12", DefaultFont, Brushes.DarkGoldenrod, new Point(coord[0] - 10, coord[1]));
            coord = msCoord(5, 100);
            g.DrawString("1", DefaultFont, Brushes.Green, new Point(coord[0], coord[1]-14));
            coord = msCoord(10, 100);
            g.DrawString("2", DefaultFont, Brushes.Green, new Point(coord[0], coord[1]-10));
            coord = msCoord(15, 100);
            g.DrawString("3", DefaultFont, Brushes.DarkGoldenrod, new Point(coord[0], coord[1]-6));
            coord = msCoord(20, 100);
            g.DrawString("4", DefaultFont, Brushes.Green, new Point(coord[0], coord[1]));
            coord = msCoord(25, 100);
            g.DrawString("5", DefaultFont, Brushes.Green, new Point(coord[0], coord[1]));
            coord = msCoord(30, 100);
            g.DrawString("6", DefaultFont, Brushes.DarkGoldenrod, new Point(coord[0]-5, coord[1]));
            coord = msCoord(35, 100);
            g.DrawString("7", DefaultFont, Brushes.Green, new Point(coord[0]-9, coord[1]-1));
            coord = msCoord(40, 100);
            g.DrawString("8", DefaultFont, Brushes.Green, new Point(coord[0]-13, coord[1]-1));
            coord = msCoord(45, 110);
            g.DrawString("9", DefaultFont, Brushes.DarkGoldenrod, new Point(coord[0], coord[1]-6));
            coord = msCoord(50, 100);
            g.DrawString("10", DefaultFont, Brushes.Green, new Point(coord[0]-14, coord[1]-10));
            coord = msCoord(55, 100);
            g.DrawString("11", DefaultFont, Brushes.Green, new Point(coord[0]-10, coord[1]-14));

            int circleWidth = 200;
            g.DrawEllipse(new Pen(Color.AntiqueWhite, 2f), start_x - circleWidth / 2, start_y - circleWidth / 2, circleWidth, circleWidth);
        }

        private int[] msCoord(int val, int hlen)
        {
            int[] coord = new int[2];
            val *= 6;
            my_Angle.Text = val.ToString();
            if (val >= 0 && val <= 180)
            {
                coord[0] = start_x + (int)(Math.Sin(val * (Math.PI / 180)) * hlen);
                coord[1] = start_y - (int)(Math.Cos(val * (Math.PI / 180)) * hlen);
            }
            else
            {
                coord[0] = start_x - (int)(-Math.Sin(val * (Math.PI / 180)) * hlen);
                coord[1] = start_y - (int)(Math.Cos(val * (Math.PI / 180)) * hlen);
            }
            return coord;
        }
        private Point hrCoord(int hval,int mval, int hlen)
        {
            int[] coord = new int[2];
            int val  = (int) ((hval * 30) + (mval * 0.5));
            my_Angle.Text = val.ToString();
            if (val >= 0 && val <= 180)
            {
                coord[0] = start_x + (int)(Math.Sin(val * (Math.PI / 180)) * hlen);
                coord[1] = start_y - (int)(Math.Cos(val * (Math.PI / 180)) * hlen);
            }
            else
            {
                coord[0] = start_x - (int)(-Math.Sin(val * (Math.PI / 180)) * hlen);
                coord[1] = start_y - (int)(Math.Cos(val * (Math.PI / 180)) * hlen);
            }
            return new Point(coord[0], coord[1]);
        }
    }
}
