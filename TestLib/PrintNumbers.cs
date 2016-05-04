using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public static partial class PrintClass
    {
        public static string[] PrintNumbers(int lowerRange, int upperRange, Dictionary<int, string> divisibleList)
        {
            string[] printList = new string[upperRange];

            for (int i = lowerRange; i <= upperRange; i++)
            {
                printList[i-1] = ((BuildOutputString(i, divisibleList)).ToString());
            }

            return printList;
        }
    }
}
