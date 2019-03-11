using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_G2
{
    public class ChildClass : ParentClass
    {
        public int childInd = 111;

        public override void TestMethod()
        {
            Console.WriteLine("Child Class");

        }
    }
}
