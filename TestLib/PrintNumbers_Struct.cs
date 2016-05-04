using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public static partial class PrintClass
    {
        public static List<TestStruct> PrintNumbers_Struct(int lowerRange, int upperRange, Dictionary<int, string> divisibleList)
        {
            List<TestStruct> printList = new List<TestStruct>();

            for (int i = lowerRange; i <= upperRange; i++)
            {
                printList.Add(new TestStruct() { TestString = (BuildOutputString(i, divisibleList)).ToString() } );
            }

            return printList;
        }
    }
}
