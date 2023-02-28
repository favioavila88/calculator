using System.Collections.Generic;
using Calculadora.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculadora.tests
{
    [TestClass]
    public class SumOperationsTests
    {
        public static IEnumerable<object[]> AdditionData
        {
            get
            {
                return SumOperationHelper.GetAdditionData();
            }
        }

        [TestMethod]
        [DynamicData(nameof(AdditionData))]
        public void VerifySumOfTwoIntegerNumbers(int id, string firstNumber, string secondNumber, string expectedSum)
        {
            var resultOfSum = new Sum(int.Parse(firstNumber), int.Parse(secondNumber)).Perform();
            Assert.AreEqual(int.Parse(expectedSum), resultOfSum, $"The Expected result of Sum should be {expectedSum} But it was: {resultOfSum}");
        }

        [TestMethod]
        public void VerifyUndoOfASumOfPositiveNumbers()
        {
            var expectedSum = 3;
            var expectedUndo = 1;
            var firstNumber = 1;
            var secondNumber = 2;

            var sumToTest = new Sum(firstNumber, secondNumber);
            var resultOfSum = sumToTest.Perform();
            var resultOfUndo = sumToTest.Undo();

            Assert.AreEqual(expectedSum, resultOfSum, $"The Expected result of Sum should be {expectedSum} But it was: {resultOfSum}");
            Assert.AreEqual(expectedUndo, resultOfUndo, $"The Expected result of Undo in Sum should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }

}
