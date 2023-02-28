using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Utils
{
    internal class SubstractOperationHelper
    {
        public static IEnumerable<object[]> GetSubstractData()
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
}
