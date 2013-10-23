using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P244_7
{
    class Area
    {
        public static void Main()
        {
            
            int width = 5;
            int height = 3;
            ComputeArea(width, height);
            ComputeArea(Convert.ToDouble(width), Convert.ToDouble(height));
            ComputeArea(width, Convert.ToDouble(height));
            
        }

        public static void ComputeArea(int w, int h)
        {
            int area = w * h;
        }

        public static void ComputeArea(double w, double h)
        {
            double area = w * h;
        }

        public static void ComputeArea(int w, double h)
        {
            double area = w * h;
        }
    }
}
