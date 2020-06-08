using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public static double[] Eqal(double a, double b, double c, out string error)
        {
            error = "";
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        error = "R";
                        return new double[0];
                    }
                    else
                    {
                        error = "Нет корней";
                        return new double[0];
                    }
                }
                else
                    return new double[] { (double)-b / c };
            }
            else
            {
                double D = b * b - 4 * a * c;
                if (D > 0) return new double[] {
                    (-b + Math.Sqrt(D)) / (2 * a),
                    (-b - Math.Sqrt(D)) / (2 * a) };
                else if (D == 0) return new double[] { -b / (2 * a) };
                else return new double[0];
            }
        }
    }
}
