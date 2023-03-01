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
        public void VerifyDivideOfTwoIntegerNumbers(int id, string firstNumber, string secondNumber, string expectedDivide, string expectedUndo)
        {
            var resultOfDivide = new Divide(int.Parse(firstNumber), int.Parse(secondNumber)).Perform();

            Assert.AreEqual(int.Parse(expectedDivide), resultOfDivide, $"The Expected result of Divide should be {expectedDivide} But it was: {resultOfDivide}");
        }

        [TestMethod]
        [DynamicData(nameof(DivideData))]
        public void VerifyUndoOfADivideOfPositiveNumbers(int id, string firstNumber, string secondNumber, string expectedDivide, string expectedUndo)
        {
            var Divide = new Divide(int.Parse(firstNumber), int.Parse(secondNumber));

            var resultOfDivide = Divide.Perform();
            var resultOfUndo = Divide.Undo();

            Assert.AreEqual(int.Parse(expectedDivide), resultOfDivide, $"The Expected result of Divide should be {expectedDivide} But it was: {resultOfDivide}");
            Assert.AreEqual(int.Parse(expectedUndo), resultOfUndo, $"The Expected result of Undo in Divide should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }

}
