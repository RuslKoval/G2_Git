using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class BaseClass
    {
        private int testInt;
        private string testString;

        public BaseClass(int testInt, string testString)
        {
            this.testInt = testInt;
            this.testString = testString;
        }

    }
}
