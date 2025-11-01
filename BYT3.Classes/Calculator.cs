namespace BYT3_Calculator
{
    public interface ICalculator
    {
        double Calculate();
    }
}

namespace BYT3_Calculator
{
    public class Calculator : ICalculator
    {
        private readonly double _a;
        private readonly double _b;
        private readonly string _operation;

        public Calculator(double a, double b, string operation)
        {
            _a = a;
            _b = b;
            _operation = operation;
        }

        public double Calculate()
        {
            double result;

            switch (_operation)
            {
                case "+":
                    result = _a + _b;
                    break;
                case "-":
                    result = _a - _b;
                    break;
                case "*":
                    result = _a * _b;
                    break;
                case "/":
                    if (_b == 0)
                        throw new Exception("Division by zero is not allowed");

                    result = _a / _b;
                    break;
                default:
                    throw new Exception("Operation is not supported or is incorrect");
            }

            if (double.IsInfinity(result))
            {
                throw new Exception("The double boundaries have been violated");
            }

            return result;
        }
    }
}