using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec8
{
    public delegate double F(double x);
    class NumericalIntegrator
    {
        public double Integrate(F f, double a, double b,int n)
        {
            double result = 0;
            double delta = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                result += f(a + delta * i) * delta;
            }

            return result;
        }
    }
}
