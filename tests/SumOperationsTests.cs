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
        public void VerifySumOfTwoIntegerNumbers(int id, string firstNumber, string secondNumber, string expectedSum, string expectedUndo)
        {
            var resultOfSum = new Sum(int.Parse(firstNumber), int.Parse(secondNumber)).Perform();

            Assert.AreEqual(int.Parse(expectedSum), resultOfSum, $"The Expected result of Sum should be {expectedSum} But it was: {resultOfSum}");
        }

        [TestMethod]
        [DynamicData(nameof(AdditionData))]
        public void VerifyUndoOfASumOfPositiveNumbers(int id, string firstNumber, string secondNumber, string expectedSum, string expectedUndo)
        {
            var sum = new Sum(int.Parse(firstNumber), int.Parse(secondNumber));
            var resultOfSum = sum.Perform();
            var resultOfUndo = sum.Undo();

            Assert.AreEqual(int.Parse(expectedSum), resultOfSum, $"The Expected result of Sum should be {expectedSum} But it was: {resultOfSum}");
            Assert.AreEqual(int.Parse(expectedUndo), resultOfUndo, $"The Expected result of Undo in Sum should be {expectedSum} But it was: {resultOfUndo}");

        }
    }
}
