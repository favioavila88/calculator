using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Utils
{
    internal class DivideOperationHelper
    {
        public static IEnumerable<object[]> GetDivideData()
        {
            return new[]
            {
                new object[] { 2, 1, 2 },
                new object[] { -6, -2, 3 },
                new object[] { -21, 3, -7 },
                new object[] { 12, -2, -6 },
                new object[] { 0, 1, 0 },
                new object[] { 0, -6, 0 },
            };

        }
    }
}
