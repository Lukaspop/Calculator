using System;
using System.Collections.Generic;

namespace Calculator
{
    internal class ManageInput
    {
        public List<string> Transform(string input)
        {
            List<string> symbols = new List<string>();
            string currentItem = "";

            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == '.') 
                {
                    currentItem += c;
                }

                else if (c == 's' || c == 'i' || c == 'n' || c == '(' || c == ')')
                {
                    
                    if (c == 's' || c == 'i' || c == 'n' )
                    {
                        currentItem += c;
                    }
                    
                    
                    else if (c == '(' || c == ')')
                    {
                        if (!string.IsNullOrEmpty(currentItem))
                        {
                            symbols.Add(currentItem);
                            currentItem = "";
                        }
                    }
                    
                    else
                    {
                        symbols.Add(c.ToString());
                    }
                }
                else if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    if (!string.IsNullOrEmpty(currentItem))
                    {
                        symbols.Add(currentItem);
                        currentItem = "";
                    }

                    symbols.Add(c.ToString());
                }   
            }
                    
            if (!string.IsNullOrEmpty(currentItem))
            {
                symbols.Add(currentItem);
            }

            return symbols;
        }
    }
}