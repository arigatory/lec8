using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec8
{
    delegate int MathOperation(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            NumericalIntegrator integrator = new NumericalIntegrator();

            F function = new F(Square);

            double result = integrator.Integrate(function, 1, 2, 1000);
            Console.WriteLine(result);


            //неявное создание делегата
            result = integrator.Integrate(Program.Cube, -2, 2, 10000);
            Console.WriteLine(result);
            
            //явное создание делегата
            result = integrator.Integrate(new F(Math.Sin), -2, 2, 10000);
            Console.WriteLine(result);

            Console.ReadLine();
        }


        static double Square(double x)
        {
            return x * x;
        }

        static double Cube(double x)
        {
            return x * x * x;
        }
    }
}
