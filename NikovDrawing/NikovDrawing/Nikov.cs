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
        public int[] Circle(int Angle, int Radius, Point Center)
        {
            int[] coord = new int[2]; // Setting up the int array for return
            Angle %= 360; // The angle that gets in must be below 360
            Angle *= 1;

            if (Angle >= 0 && Angle <= 180)
            {
                coord[0] = Center.X + (int)(Radius * Math.Sin(Math.PI * Angle / 180));
                coord[1] = Center.Y - (int)(Radius * Math.Cos(Math.PI * Angle / 180));
            }
            else
            {
                coord[0] = Center.X - (int)(Radius * -Math.Sin(Math.PI * Angle / 180));
                coord[1] = Center.Y - (int)(Radius * Math.Cos(Math.PI * Angle / 180));
            }
            return coord;
        }
    }
}
