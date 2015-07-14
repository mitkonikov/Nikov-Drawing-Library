using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NikovDrawing;

namespace NikovTesting
{
    public partial class Form1 : Form
    {
        Bitmap bmp = new Bitmap(400, 400);
        Graphics g;

        int time = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var nikov = new Trigonometry();
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;

            // Testing Circle Drawing with offset center
            TestTimer.Start();
            for (int i = 1; i <= 360; i++)
            {
                g.FillRectangle(new SolidBrush(Color.Green), nikov.LineCircle(i, 400 / 2 - 70, new Point(200, 300), 1).X, nikov.LineCircle(i, 400 / 2 - 70, new Point(200, 300), 1).Y, 5, 5);
            }

            for (int i = 1; i <= 360; i++)
            {
                g.FillRectangle(new SolidBrush(Color.Green), nikov.LineCircle(i, 400 / 2 - 70, new Point(300, 100), 1).X, nikov.LineCircle(i, 400 / 2 - 70, new Point(300, 100), 1).Y, 5, 5);
            }

            for (int i = 1; i <= (360 * 4); i++)
            {
                bmp.SetPixel(nikov.LineCircle(i, 100, new Point(200, 200), 4).X, nikov.LineCircle(i, 100, new Point(200, 200), 4).Y, Color.Brown);
            }
            TestTimer.Stop();
            Console.WriteLine("Time: " + time);

            g.Dispose();
        }

        private void TestTimer_Tick(object sender, EventArgs e)
        {
            time++;
        }
    }
}
