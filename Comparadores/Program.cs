using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Collections.Generic;

namespace Comparadores
{

    public class Program:Dictionary
    {
        private static void Main(string[] args)
        {
            System.Collections.Generic.IEnumerable<int> numbers = new int[] { 1, 2, 3 };

            int[] fib = new int[10];
            fib[0] = fib[1] = 1;
            for (int i = 2; i < fib.Length; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            Console.WriteLine(fib[fib.Length - 1]);  // output: 55

            double[,] matrix = new double[2, 2];
            matrix[0, 0] = 1.0;
            matrix[0, 1] = 2.0;
            matrix[1, 0] = matrix[1, 1] = 3.0;
            var determinant = matrix[0, 0] * matrix[1, 1] - matrix[1, 0] * matrix[0, 1];
            Console.WriteLine(determinant);  // output: -3


        }


    }

    
}