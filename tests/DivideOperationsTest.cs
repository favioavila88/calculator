using System.Collections.Generic;
using Calculadora.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculadora.tests
{
    [TestClass]
    public class DivideOperationsTest
    {
        public static IEnumerable<object[]> DivideData
        {
            get
            {
                return DivideOperationHelper.GetDivideData();
            }
        }

        [TestMethod]
        [DynamicData(nameof(DivideData))]
        public void VerifyDivideOfTwoIntegerNumbers(int id, string firstNumber, string secondNumber, string expectedDivide)
        {
            var resultOfDivide = new Divide(int.Parse(firstNumber), int.Parse(secondNumber)).Perform();

            Assert.AreEqual(int.Parse(expectedDivide), resultOfDivide, $"The Expected result of Divide should be {expectedDivide} But it was: {resultOfDivide}");
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
