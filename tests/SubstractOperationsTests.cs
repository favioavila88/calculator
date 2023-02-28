using System.Collections.Generic;
using Calculadora.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculadora.tests
{
    [TestClass]
    public class SubstractOperationsTests
    {
        public static IEnumerable<object[]> SubstractData
        {
            get
            {
                return SubstractOperationHelper.GetSubstractData();
            }
        }

        [TestMethod]
        [DynamicData(nameof(SubstractData))]
        public void VerifySubstractOfTwoIntegerNumbers(int firstNumber, int secondNumber, int expectedSubstract)
        {
            var resultOfSubstract = new Substract(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedSubstract, resultOfSubstract, $"The Expected result of Substract should be {expectedSubstract} But it was: {resultOfSubstract}");
        }


        [TestMethod]
        public void VerifyUndoOfASubstractOfPositiveNumbers()
        {
            var expectedSubstract = 1;
            var expectedUndo = 2;
            var firstNumber = 2;
            var secondNumber = 1;

            var SubstractToTest = new Substract(firstNumber, secondNumber);
            var resultOfSubstract = SubstractToTest.Perform();
            var resultOfUndo = SubstractToTest.Undo();

            Assert.AreEqual(expectedSubstract, resultOfSubstract, $"The Expected result of Substract should be {expectedSubstract} But it was: {resultOfSubstract}");
            Assert.AreEqual(expectedUndo, resultOfUndo, $"The Expected result of Undo in Substract should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }

}
