using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculadora.tests
{
    [TestClass]
    public class DivideOperationsTest
    {

        public static IEnumerable<object[]> AdditionData
        {
            get
            {
                return new[]
                {
                    new object[] { 2, 1, 2 },
                    new object[] { -6, -2, 3 },
                    new object[] { -21, 3, -7 },
                    new object[] { 12, -2, -6 },
                    new object[] { 0, 1, 0 },
                    new object[] { 0, -6, 0 },
                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(AdditionData))]
        public void VerifyDivideOfTwoIntegerNumbers(int firstNumber, int secondNumber, int expectedDivide)
        {
            var resultOfDivide = new Divide(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedDivide, resultOfDivide, $"The Expected result of Divide should be {expectedDivide} But it was: {resultOfDivide}");
        }


        [TestMethod]
        public void VerifyUndoOfADivideOfPositiveNumbers()
        {
            var expectedDivide = 2;
            var expectedUndo = 2;
            var firstNumber = 2;
            var secondNumber = 1;

            var divideToTest = new Divide(firstNumber, secondNumber);
            var resultOfDivide = divideToTest.Perform();
            var resultOfUndo = divideToTest.Undo();

            Assert.AreEqual(expectedDivide, resultOfDivide, $"The Expected result of Divide should be {expectedDivide} But it was: {resultOfDivide}");
            Assert.AreEqual(expectedUndo, resultOfUndo, $"The Expected result of Undo in Divide should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }

}
