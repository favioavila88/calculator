using System;

namespace Calculadora
{
    public class CalculatorProgram
    {
        public int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int Substract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public float Divide(int firstNumber, int secondNumber)
        {
            return (float) firstNumber / (float) secondNumber;
        }

        static void Main(string[] args)
        {
            var calculatorProgram = new CalculatorProgram();
            
            var sumOne = new Multiply(-2, 2);
            var sumSecond = new Multiply(sumOne.Perform(), 8);
            var sumThird = new Multiply(sumSecond.Perform(), 9);
            Console.WriteLine(sumThird.Perform());
            var resultAfterUndo = sumThird.Undo();

            Console.WriteLine("------------------------");
            Console.WriteLine(resultAfterUndo);
            Console.WriteLine("------------------------");


            var respSum = calculatorProgram.Sum(1, 2);
            respSum = calculatorProgram.Sum(respSum, 8);
            respSum = calculatorProgram.Sum(respSum, 9);

            var respSubstract = calculatorProgram.Substract(4, 2);
            var respMultiply = calculatorProgram.Multiply(3, 7);
            var respDivide = calculatorProgram.Divide(3, 2);
        }
    }
}
