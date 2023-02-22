namespace Calculadora
{
    public class Sum
    {
        public int firstNumber;
        public int secondNumber;
        public int resultSum;

        public Sum(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public int Perform()
        {
            resultSum = firstNumber + secondNumber;
            return resultSum;
        }

        public int Undo()
        {
            return resultSum - secondNumber;
        }
    }
}
