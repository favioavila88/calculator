using System.Collections.Generic;
using Calculadora;
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
        public void VerifySubstractOfTwoIntegerNumbers(int id, string firstNumber, string secondNumber, string expectedSubstract, string expectedUndo)
        {
            var resultOfSubstract = new Substract(int.Parse(firstNumber), int.Parse(secondNumber)).Perform();

            Assert.AreEqual(int.Parse(expectedSubstract), resultOfSubstract, $"The Expected result of Substract should be {expectedSubstract} But it was: {resultOfSubstract}");
        }


        [TestMethod]
        [DynamicData(nameof(SubstractData))]
        public void VerifyUndoOfASubstractOfPositiveNumbers(int id, string firstNumber, string secondNumber, string expectedSubstract, string expectedUndo)
        {
            var Substract = new Substract(int.Parse(firstNumber), int.Parse(secondNumber));
            var resultOfSubstract = Substract.Perform();
            var resultOfUndo = Substract.Undo();

            Assert.AreEqual(int.Parse(expectedSubstract), resultOfSubstract, $"The Expected result of Substract should be {expectedSubstract} But it was: {resultOfSubstract}");
            Assert.AreEqual(int.Parse(expectedUndo), resultOfUndo, $"The Expected result of Undo in Substract should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }

}
