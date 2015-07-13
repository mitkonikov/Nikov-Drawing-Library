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
            for (int i = 1; i <= 360; i++)
            {
                g.FillRectangle(new SolidBrush(Color.Green), nikov.Circle(i, 400 / 2 - 70, new Point(200, 300))[0], nikov.Circle(i, 400 / 2 - 70, new Point(200, 300))[1], 5, 5);
            }

            for (int i = 1; i <= 360; i++)
            {
                g.FillRectangle(new SolidBrush(Color.Green), nikov.Circle(i, 400 / 2 - 70, new Point(300, 100))[0], nikov.Circle(i, 400 / 2 - 70, new Point(300, 100))[1], 5, 5);
            }
        }
    }
}
