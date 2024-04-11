using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    public abstract class Operations(string a, string b)
    {
        public double A { get; set; } = double.Parse(a);
        public double B { get; set; } = double.Parse(b);
        public abstract double Calculate();
    }
    public class Devide : Operations
    {
        public Devide(string a, string b) : base(a, b)
        {
        }

        public override double Calculate()
        {
            return A / B;
        }
    }

    public class Multiply : Operations
    {
        public Multiply(string a, string b) : base(a, b)
        {
        }

        public override double Calculate()
        {
            return A * B;
        }
    }

    public class Minus : Operations
    {
        public Minus(string a, string b) : base(a, b)
        {
        }

        public override double Calculate()
        {
            return A - B;
        }
    }
    public class Plus : Operations
    {
        public Plus(string a, string b) : base(a, b)
        {
        }

        public override double Calculate()
        {
            return A + B;
        }
    }
    public class Sinus : Operations
    {
        public Sinus(string a) : base(a, "0") //copilot
        {
        }

        public override double Calculate()
        {
            return Math.Sin(A);
        }
    }
}
   