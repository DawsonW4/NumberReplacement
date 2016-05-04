using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowerRange = 1, upperRange = 100000000;

            Dictionary<int, string> divisibleList = new Dictionary<int, string>();

            divisibleList.Add(6, "Woof");
            divisibleList.Add(11, "Meow");
            divisibleList.Add(4, "Grr");
            divisibleList.Add(7, "Buzz");

            string[] printString = PrintClass.PrintNumbers(lowerRange, upperRange, divisibleList);

            foreach (var item in printString)
            {
                Console.WriteLine(item);
            }

            //List<TestStruct> printString = PrintClass.PrintNumbers_Struct(lowerRange, upperRange, divisibleList);
            //foreach (var item in printString)
            //{
            //    Console.WriteLine(item.TestString.ToString());
            //}

            Console.ReadLine();
        }
    }
}
