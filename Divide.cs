namespace Calculadora
{
    public class Divide
    {
        public int firstNumber;
        public int secondNumber;
        public int resultDivide;

        public Divide(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public int Perform()
        {
            resultDivide = firstNumber / secondNumber;
            return resultDivide;
        }

        public int Undo()
        {
            return resultDivide * secondNumber;
        }
    }
}
