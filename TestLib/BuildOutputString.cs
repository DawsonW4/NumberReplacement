using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public static partial class PrintClass
    {
        public static string BuildOutputString(int divNum, Dictionary<int, string> divisibleList)
        {
            var stringsFromDivisibles = from item in divisibleList
                                        where (divNum % item.Key == 0)
                                        select item.Value.ToString();

            if (stringsFromDivisibles.Count() > 0)
            {
                return String.Join("", stringsFromDivisibles);
            }

            else
                return divNum.ToString(); 
        }
    }
}
