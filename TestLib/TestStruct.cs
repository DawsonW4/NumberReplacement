using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public struct TestStruct
    {
        private byte[] _testString;

        public string TestString
        {
            get
            {
                return Encoding.Default.GetString(_testString);
            }
            set
            {
                _testString = Encoding.ASCII.GetBytes(value);
            }
        }
    }
}
