using System;
using System.Collections.Generic;

namespace Descriminant_procent
{
    public class Descriminanit_procent
    {
        public List<double> Discriminant_Solver(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            List<double> roOt = new List<double>();

            if (discriminant > 0)
            {
                roOt.Add((-b + Math.Sqrt(discriminant)) / (2 * a));
                roOt.Add((-b - Math.Sqrt(discriminant)) / (2 * a));
            }
            else if (discriminant == 0)
            {
                roOt.Add(-b / (2 * a));
            }

            return roOt;
        }

        public double SearchProcient(double number, double percentage)
        {
            return (number * percentage) / 100.0f;
        }
    }
}