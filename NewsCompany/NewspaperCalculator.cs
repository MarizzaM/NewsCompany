using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    static class NewspaperCalculator
    {
        internal static int CalcNumberOfChars(Newspaper x)
        {
            return x.ToString().Length;
        }
    }
}
