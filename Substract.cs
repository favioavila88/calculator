using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Substract
    {
        public int firstNumber;
        public int secondNumber;
        public int resultSubstract;

        public Substract(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public int Perform()
        {
            resultSubstract = firstNumber - secondNumber;
            return resultSubstract;
        }

        public int Undo()
        {
            return resultSubstract + secondNumber;
        }
    }
}
