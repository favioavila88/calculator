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
        public void VerifyMultiplyOfTwoIntegerNumbers(int id, string firstNumber, string secondNumber, string expectedMultiply)
        {
            var resultOfMultiply = new Multiply(int.Parse(firstNumber), int.Parse(secondNumber)).Perform();

            Assert.AreEqual(int.Parse(expectedMultiply), resultOfMultiply, $"The Expected result of Multiply should be {expectedMultiply} But it was: {resultOfMultiply}");
        }



        [TestMethod]
        public void VerifyUndoOfAMultiplyOfPositiveNumbers()
        {
            var expectedMultiply = 2;
            var expectedUndo = 1;
            var firstNumber = 1;
            var secondNumber = 2;

            var multiplyToTest = new Multiply(firstNumber, secondNumber);
            var resultOfMultiply = multiplyToTest.Perform();
            var resultOfUndo = multiplyToTest.Undo();

            Assert.AreEqual(expectedMultiply, resultOfMultiply, $"The Expected result of Multiply should be {expectedMultiply} But it was: {resultOfMultiply}");
            Assert.AreEqual(expectedUndo, resultOfUndo, $"The Expected result of Undo in Multiply should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }

}
