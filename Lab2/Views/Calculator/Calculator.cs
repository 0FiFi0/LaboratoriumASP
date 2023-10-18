using Lab2.Models;

namespace Lab2.Views.Calculator
{
    public class Calculator
    {
        public Operators? Operator { get; set; }

        public double? x {get; set; }
        public double? y { get; set; }

        public double Calculate()
        {
            switch (Operator)
            {
                case Operators.Add: return (double)(x + y);
                    case Operators.Sub: return (double)(x - y);
                    case Operators.Mul: return (double)(x * y);
                    case Operators.Div: return (double)(x / y);
                default: return double.NaN;
            }
        }

        public bool IsValid()
        {
            return Operator != null && x != null && y != null;
        }

    }
}
