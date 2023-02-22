using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculadora.tests
{
    [TestClass]
    public class MultiplyOperationsTest
    {

        public static IEnumerable<object[]> AdditionData
        {
            get
            {
                return new[]
                {
                    new object[] { 1, 2, 2 },
                    new object[] { -2, -3, 6 },
                    new object[] { -7, 3, -21 },
                    new object[] { 12, -8, -96 },
                    new object[] { 0, 1, 0 },
                    new object[] { 9, 0, 0 },
                    new object[] { -9, 0, 0 },
                    new object[] { 0, -6, 0 },
                    new object[] { 0, 0, 0 },
                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(AdditionData))]
        public void VerifyMultiplyOfTwoIntegerNumbers(int firstNumber, int secondNumber, int expectedMultiply)
        {
            var resultOfMultiply = new Multiply(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedMultiply, resultOfMultiply, $"The Expected result of Multiply should be {expectedMultiply} But it was: {resultOfMultiply}");
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
