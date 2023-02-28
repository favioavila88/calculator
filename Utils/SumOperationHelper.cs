using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Utils
{
    internal class SumOperationHelper
    {
        public static IEnumerable<object[]> GetAdditionData()
        {
            return new[]
            {
                new object[] { 1, 2, 3 },
                new object[] { -2, -3, -5 },
                new object[] { -7, 3, -4 },
                new object[] { 12, -8, 4 },
                new object[] { 0, 1, 1 },
                new object[] { 9, 0, 9 },
                new object[] { -9, 0, -9 },
                new object[] { 0, -6, -6 },
                new object[] { 0, 0, 0 },
            };

        }
    }
}
