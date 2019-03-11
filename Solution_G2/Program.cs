using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_G2
{
    class Program
    {
        static void Main(string[] args)
        {

            ParentClass parentClass = new ParentClass();

            Console.WriteLine(parentClass.myInt);

            ChildClass childClass = new ChildClass();

            Console.WriteLine(childClass.myInt + "  " + childClass.childInd);

            ParentClass parent11 = new ChildClass();


            //parentClass = childClass;

            // childClass = (ChildClass)parentClass; //  exception
            // Console.WriteLine(childClass.childInd);

            parent11.TestMethod();

            childClass.TestMethod();

            Console.ReadKey();
        }
    }
}
