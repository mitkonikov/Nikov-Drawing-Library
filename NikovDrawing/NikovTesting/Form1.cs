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
        Bitmap bmpSmall = new Bitmap(10, 10);
        Graphics g;
        Color color = Color.Black;
        Trigonometry nikov = new Trigonometry();
        NGraphics basic = new NGraphics();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            pictureBox1.Image = bmp;
            g.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }


        // For the Painting
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            RenderTimer.Start();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            RenderTimer.Stop();
        }

        private void RenderTimer_Tick(object sender, EventArgs e)
        {
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;

            g.FillRectangle(new SolidBrush(color), PointToClient(Cursor.Position).X, PointToClient(Cursor.Position).Y, 5, 5);
            g.Dispose();
        }


        // Clear Button
        private void button1_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(400, 400);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            pictureBox1.Image = bmp;
            g.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bmp = basic.IsolateRectangle(bmp, Color.FromArgb(100, 100, 100));
            pictureBox1.Image = bmp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bmp = basic.IsolateBitmap(bmp, Color.FromArgb(100, 100, 100));
            pictureBox1.Image = bmp;
        }

        // Value Changed on TrackBars
        private void RTrackBar_ValueChanged(object sender, EventArgs e)
        {
            color = Color.FromArgb(RTrackBar.Value, GTrackBar.Value, BTrackBar.Value);
        }

        private void GTrackBar_ValueChanged(object sender, EventArgs e)
        {
            color = Color.FromArgb(RTrackBar.Value, GTrackBar.Value, BTrackBar.Value);
        }

        private void BTrackBar_ValueChanged(object sender, EventArgs e)
        {
            color = Color.FromArgb(RTrackBar.Value, GTrackBar.Value, BTrackBar.Value);
        }


        // Resize Button
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                bmpSmall = basic.ResizeBitmap(bmp, new Size(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text)), System.Drawing.Drawing2D.InterpolationMode.Default);
                pictureBox2.Image = bmpSmall;
            }
            catch
            {
                textBox1.Text = "Write a number!";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bmpSmall = basic.Zoom(bmpSmall, 30);
            pictureBox2.Image = bmpSmall;
        }
    }
}
