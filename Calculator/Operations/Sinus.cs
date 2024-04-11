using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    internal class Sinus
    {
        public static string OperationSinus(string a)
        {
            Console.WriteLine(a);
            double numberA = double.Parse(a);
            double result = Math.Sin(numberA);
            return result.ToString();
        }
    }
}
