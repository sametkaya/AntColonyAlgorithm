using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntColonyAlgorithmApp
{
    class MyMath
    {
        public static double distanceLPoint(LPoint p1, LPoint p2)
        {
            double result= Math.Round(Math.Sqrt(Math.Pow((p1.location.X - p2.location.X), 2) + Math.Pow((p1.location.Y - p2.location.Y), 2)),1);
            return result;
        }
    }
}
