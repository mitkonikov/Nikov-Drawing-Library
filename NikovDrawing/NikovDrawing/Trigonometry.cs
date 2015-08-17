using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;

namespace NikovDrawing
{
    // This is open source Library created by Mitko Nikov
    // Feel free to add new Algorithms
    // GitHub: https://github.com/mitkonikov/Nikov-Drawing-Library

    public class Trigonometry
    {
        // This class takes care of the basics Drawing Algorithms using Trigonometry

        // Video : https://www.youtube.com/watch?v=Bte4MZpvdXA
        // This video will show you how you can use this algorithm for Rotating a Plane in 2D
        /// <summary>
        /// Get the point on the circle by angle
        /// </summary>
        /// <param name="Angle">The angle from the starting point to wanted point</param>
        /// <param name="Radius">The radius of the circle</param>
        /// <param name="Center">The Center of the circle</param>
        /// <returns></returns>
        public Point LineCircle(int Angle, int Radius, Point Center)
        {
            Point coord = new Point(0, 0); // Setting up the point for return
            Angle %= (360); // The angle that gets in must be below 360
            Angle *= 1;

            if (Angle >= 0 && Angle <= 180)
            {
                coord.X = Center.X + (int)(Radius * Math.Sin(Math.PI * Angle / 180));
                coord.Y = Center.Y - (int)(Radius * Math.Cos(Math.PI * Angle / 180));
            }
            else
            {
                coord.X = Center.X - (int)(Radius * -Math.Sin(Math.PI * Angle / 180));
                coord.Y = Center.Y - (int)(Radius * Math.Cos(Math.PI * Angle / 180));
            }
            return coord;
        }

        /// <summary>
        /// Get the point on the circle by angle
        /// </summary>
        /// <param name="Angle">The angle from the starting point to wanted point</param>
        /// <param name="Radius">The radius of the circle</param>
        /// <param name="Center">The Center of the circle</param>
        /// <param name="Accuracy"></param>
        /// <returns></returns>
        public Point LineCircle(int Angle, int Radius, Point Center, int Accuracy)
        {
            Point coord = new Point(0, 0); // Setting up the point for return
            Angle %= (360 * Accuracy); // The angle that gets in must be below 360
            Angle *= 1;

            if (Angle >= 0 && Angle <= 180 * Accuracy)
            {
                coord.X = Center.X + (int)(Radius * Math.Sin(Math.PI * Angle / (180 * Accuracy)));
                coord.Y = Center.Y - (int)(Radius * Math.Cos(Math.PI * Angle / (180 * Accuracy)));
            }
            else
            {
                coord.X = Center.X - (int)(Radius * -Math.Sin(Math.PI * Angle / (180 * Accuracy)));
                coord.Y = Center.Y - (int)(Radius * Math.Cos(Math.PI * Angle / (180 * Accuracy)));
            }
            return coord;
        }

        // Video : https://www.youtube.com/watch?v=rFgA9EpHoRg
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Angle"> The Angle </param>
        /// <param name="radiusWidth"> The Width Radius </param>
        /// <param name="radiusHeight"> The Height Radius </param>
        /// <param name="Center"> The Center of the ellipse </param>
        /// <returns></returns>
        public Point LineEllipse(int Angle, int radiusWidth, int radiusHeight, Point Center)
        {
            Point ptfPoint = new Point((int)(Center.X + radiusWidth * Math.Cos(Angle * Math.PI / 180)), (int)(Center.Y + radiusHeight * Math.Sin(Angle * Math.PI / 180)));
            return ptfPoint;
        }
    }
}
