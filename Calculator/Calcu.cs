using Calculator.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calcu
    {

        public void Calculate(List<string> symbols)
        {
            new Plus();
            new Minus();
            new Multiply();
            new Devide();
            new Sinus();

            int selectedNumberOne;
            int selectedNumberTwo;

            while (symbols.Count > 1)
            {

                if (symbols.Contains("sin"))
                {
                    selectedNumberOne = symbols.IndexOf("sin") + 1;
                    symbols[selectedNumberOne] = Sinus.OperationSinus(symbols[selectedNumberOne]);
                    symbols.RemoveAt((selectedNumberOne) - 1);
                }

                else if (symbols.Contains("*"))
                {
                    selectedNumberOne = symbols.IndexOf("*") - 1;
                    selectedNumberTwo = symbols.IndexOf("*") + 1;
                    symbols[selectedNumberOne] = Multiply.OperationMultiply(symbols[selectedNumberOne], symbols[selectedNumberTwo]);
                    symbols.RemoveAt((selectedNumberTwo) - 1);
                    symbols.RemoveAt((selectedNumberTwo) - 1);
                }

                else if (symbols.Contains("/"))
                {
                    selectedNumberOne = symbols.IndexOf("/") - 1;
                    selectedNumberTwo = symbols.IndexOf("/") + 1;
                    symbols[selectedNumberOne] = Devide.OperationDevide(symbols[selectedNumberOne], symbols[selectedNumberTwo]);
                    symbols.RemoveAt((selectedNumberTwo) - 1);
                    symbols.RemoveAt((selectedNumberTwo) - 1);
                }

                else if (symbols.Contains("+"))
                {
                    selectedNumberOne = symbols.IndexOf("+") - 1;
                    selectedNumberTwo = symbols.IndexOf("+") + 1;
                    symbols[selectedNumberOne] = Plus.OperationPlus(symbols[selectedNumberOne], symbols[selectedNumberTwo]);

                    symbols.RemoveAt((selectedNumberTwo) - 1);
                    symbols.RemoveAt((selectedNumberTwo) - 1);

                }

                else if (symbols.Contains("-"))
                {
                    selectedNumberOne = symbols.IndexOf("-") - 1;
                    selectedNumberTwo = symbols.IndexOf("-") + 1;
                    Console.WriteLine("1" + symbols[selectedNumberOne]);
                    Console.WriteLine("2" + symbols[selectedNumberTwo]);

                    symbols[selectedNumberOne] = Minus.OperationMinus(symbols[selectedNumberOne], symbols[selectedNumberTwo]);
                    symbols.RemoveAt((selectedNumberTwo) - 1);
                    symbols.RemoveAt((selectedNumberTwo) - 1);
                }

            }
            foreach (string symbol in symbols)
            {
                Console.WriteLine("Výsledek:" + symbol);
            }

        }   
    }
}
