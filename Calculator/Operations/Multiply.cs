using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    internal class Multiply
    {
        public static string OperationMultiply(string a, string b)
        {
            double numberA = double.Parse(a);
            double numberB = double.Parse(b);
            double result = numberA * numberB;
            return result.ToString();
        }
    }
}
