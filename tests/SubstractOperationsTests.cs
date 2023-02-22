using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculadora.tests
{
    [TestClass]
    public class SubstractOperationsTests
    {

        public static IEnumerable<object[]> AdditionData
        {
            get
            {
                return new[]
                {
                    new object[] { 2, 1, 1 },
                    new object[] { -2, -3, 1 },
                    new object[] { -7, 3, -10 },
                    new object[] { 12, -8, 20 },
                    new object[] { 0, 1, -1 },
                    new object[] { 9, 0, 9 },
                    new object[] { -9, 0, -9 },
                    new object[] { 0, -6, +6 },
                    new object[] { 0, 0, 0 },
                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(AdditionData))]
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
