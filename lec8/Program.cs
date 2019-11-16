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
            MathOperation minus = Sub;

            int result = minus(5, 4);
            Console.WriteLine(result);

            minus = new MathOperation(Program.Add);
            result = minus(3, 4);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
