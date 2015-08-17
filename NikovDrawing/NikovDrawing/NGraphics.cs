using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;

namespace NikovDrawing
{
    public class NGraphics
    {
        // This class is for basic graphic Algorithms

        // These variables are used to save the up_left and down_right points relative to the source image, after the image is being cropped
        // Used in Isolate Function
        private Point up_left = new Point(0, 0);
        private Point down_right = new Point(0, 0);

        /// <summary>
        /// Isolates only the used part of the Bitmap, returns new Bitmap with a Rectangle around the Isolated part
        /// </summary>
        /// <param name="source"> The Bitmap you want to process </param>
        /// <param name="threshold"> The threshold color from which any colors below will go throw the filter </param>
        /// <returns></returns>
        public Bitmap IsolateRectangle(Bitmap source, Color threshold)
        {
            return Isolate(source, threshold, false);
        }

        /// <summary>
        /// Isolates only the used part of the Bitmap, returns new Bitmap just the Isolated part
        /// </summary>
        /// <param name="source"> The Bitmap you want to process </param>
        /// <param name="threshold"> The threshold color from which any colors below will go throw the filter </param>
        /// <returns></returns>
        public Bitmap IsolateBitmap(Bitmap source, Color threshold)
        {
            return Isolate(source, threshold, true);
        }

        private Bitmap Isolate(Bitmap source, Color threshold, bool Crop)
        {
            System.Drawing.Color color;

            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    color = source.GetPixel(x, y);

                    if (color.R <= threshold.R && color.G <= threshold.G && color.B <= threshold.B)
                    {
                        if (up_left.X == 0 && up_left.Y == 0)
                        {
                            up_left = new Point(x, y);
                        }

                        if (x < up_left.X)
                        {
                            up_left = new Point(x, up_left.Y);
                        }

                        if (down_right.X == 0 && down_right.Y == 0)
                        {
                            down_right = new Point(x, y);
                        }

                        if (x > down_right.X)
                        {
                            down_right = new Point(x, down_right.Y);
                        }

                        if (y > down_right.Y)
                        {
                            down_right = new Point(down_right.X, y);
                        }
                    }
                }
            }

            Graphics g;
            Bitmap bmpNew = new Bitmap(source.Width, source.Height); // Creates the new Bitmap
            g = Graphics.FromImage(bmpNew); // Binds the graphics to the new Bitmap
            Rectangle cropRect = new Rectangle(up_left.X, up_left.Y, down_right.X - up_left.X, down_right.Y - up_left.Y); // Defines the crop Rectangle

            if (Crop)
            {
                // If the picture needs to be cropped, then the new Bitmap is recreated with the crop's Rectangle size
                bmpNew = new Bitmap(down_right.X - up_left.X, down_right.Y - up_left.Y);
                g = Graphics.FromImage(bmpNew);
                g.DrawImage(source, new Rectangle(0, 0, bmpNew.Width, bmpNew.Height), cropRect, GraphicsUnit.Pixel); // Draws the sector to the new Bitmap
            }
            else
            {
                // Just clones the source image to the new Bitmap
                g.DrawImage(source, new Rectangle(0, 0, source.Width, source.Height), new Rectangle(0, 0, source.Width, source.Height), GraphicsUnit.Pixel);
                // Draws a rectangle
                g.DrawRectangle(new Pen(Color.Red, 3f), cropRect);
            }

            g.Dispose();

            // Resets the up_left and down_right points so they can be reused
            up_left = new Point(0, 0);
            down_right = new Point(0, 0);

            return bmpNew;
        }

        /// <summary>
        /// Returns a resized Bitmap with the new size (scale)
        /// </summary>
        /// <param name="source"> The Bitmap to process </param>
        /// <param name="scale"> The new size </param>
        /// <param name="intMode"> The quality of the new resized Bitmap </param>
        /// <returns></returns>
        public Bitmap ResizeBitmap(Bitmap source, Size scale, System.Drawing.Drawing2D.InterpolationMode intMode)
        {
            // Create the new bitmap
            // Note that Bitmap has a resize constructor, but you can't control the quality
            Bitmap bmp = new Bitmap(scale.Width, scale.Height);

            using (var g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = intMode;
                g.DrawImage(source, new Rectangle(0, 0, scale.Width, scale.Height));
                g.Dispose();
            }

            return bmp;
        }

        /// <summary>
        /// Zoom or unblur function, often can be used to show a small Image into pictureBox much bigger then the actual image
        /// </summary>
        /// <param name="source"> The original small image </param>
        /// <param name="scale"> The scale </param>
        /// <returns></returns>
        public Bitmap Zoom(Bitmap source, int scale)
        {
            // Create the new bitmap
            Bitmap bmpNew = new Bitmap(source.Width * scale, source.Height * scale);

            using (var g = Graphics.FromImage(bmpNew))
            {
                // It goes to every pixel and draws a bigger rectangle for the pixes
                for (int x = 0; x < source.Height; x++)
                {
                    for (int y = 0; y < source.Width; y++)
                    {
                        g.FillRectangle(new SolidBrush(source.GetPixel(x, y)), x * scale, y * scale, scale, scale);
                    }
                }
                g.Dispose();
            }

            return bmpNew;
        }
    }
}
