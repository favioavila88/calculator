using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Utils
{
    internal class MultiplyOperationHelper
    {
        public static IEnumerable<object[]> GetMultiplynData()
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
}
