namespace Calculator
{
    public class CalculatorNumberService
    {
        public decimal Add(decimal number1, decimal number2)
        {
            return number1 + number2;
        }

        public decimal Sustraction(decimal number1, decimal number2)
        {
            return number1 - number2;
        }

        public decimal Multiply(decimal number1, decimal number2)
        {
            return number1 * number2;
        }

        public decimal Divide(decimal number1, decimal number2)
        {
            return number1 / number2;
        }
    }
}
