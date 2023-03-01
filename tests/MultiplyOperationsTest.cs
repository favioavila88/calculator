using System.Collections.Generic;
using Calculadora.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculadora.tests
{
    [TestClass]
    public class MultiplyOperationsTest
    {

        public static IEnumerable<object[]> MultiplyData
        {
            get
            {
                return MultiplyOperationHelper.GetMultiplyData();
            }
        }

        [TestMethod]
        [DynamicData(nameof(MultiplyData))]
        public void VerifyMultiplyOfTwoIntegerNumbers(int id, string firstNumber, string secondNumber, string expectedMultiply, string expectedUndo)
        {
            var resultOfMultiply = new Multiply(int.Parse(firstNumber), int.Parse(secondNumber)).Perform();

            Assert.AreEqual(int.Parse(expectedMultiply), resultOfMultiply, $"The Expected result of Multiply should be {expectedMultiply} But it was: {resultOfMultiply}");
        }



        [TestMethod]
        [DynamicData(nameof(MultiplyData))]
        public void VerifyUndoOfAMultiplyOfPositiveNumbers(int id, string firstNumber, string secondNumber, string expectedMultiply, string expectedUndo)
        {
            var multiply = new Multiply(int.Parse(firstNumber), int.Parse(secondNumber));
            var resultOfMultiply = multiply.Perform();
            var resultOfUndo = multiply.Undo();

            Assert.AreEqual(int.Parse(expectedMultiply), resultOfMultiply, $"The Expected result of Multiply should be {expectedMultiply} But it was: {resultOfMultiply}");
            Assert.AreEqual(int.Parse(expectedUndo), resultOfUndo, $"The Expected result of Undo in Multiply should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }

}
