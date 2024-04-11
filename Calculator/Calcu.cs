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

            int selectedNumberOne;
            int selectedNumberTwo;

            while (symbols.Count > 1)
            {

                if (symbols.Contains("sin"))
                {
                    selectedNumberOne = symbols.IndexOf("sin") + 1;

                    symbols[selectedNumberOne] = new Sinus(symbols[selectedNumberOne]).Calculate().ToString();
                    symbols.RemoveAt((selectedNumberOne) - 1);
                }

                else if (symbols.Contains("*"))
                {
                    selectedNumberOne = symbols.IndexOf("*") - 1;
                    selectedNumberTwo = symbols.IndexOf("*") + 1;

                    symbols[selectedNumberOne] = new Multiply(symbols[selectedNumberOne], symbols[selectedNumberTwo]).Calculate().ToString();
                    symbols.RemoveAt((selectedNumberTwo) - 1);
                    symbols.RemoveAt((selectedNumberTwo) - 1);
                }

                else if (symbols.Contains("/"))
                {
                    selectedNumberOne = symbols.IndexOf("/") - 1;
                    selectedNumberTwo = symbols.IndexOf("/") + 1;

                    symbols[selectedNumberOne] = new Devide(symbols[selectedNumberOne], symbols[selectedNumberTwo]).Calculate().ToString();
                    symbols.RemoveAt((selectedNumberTwo) - 1);
                    symbols.RemoveAt((selectedNumberTwo) - 1);
                }

                else if (symbols.Contains("+"))
                {
                    selectedNumberOne = symbols.IndexOf("+") - 1;
                    selectedNumberTwo = symbols.IndexOf("+") + 1;

                    symbols[selectedNumberOne] = new Plus(symbols[selectedNumberOne], symbols[selectedNumberTwo]).Calculate().ToString();
                    symbols.RemoveAt((selectedNumberTwo) - 1);
                    symbols.RemoveAt((selectedNumberTwo) - 1);

                }

                else if (symbols.Contains("-"))
                {
                    selectedNumberOne = symbols.IndexOf("-") - 1;
                    selectedNumberTwo = symbols.IndexOf("-") + 1;

                    symbols[selectedNumberOne] = new Minus(symbols[selectedNumberOne], symbols[selectedNumberTwo]).Calculate().ToString();
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
