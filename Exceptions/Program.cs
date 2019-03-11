using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception();

            string testString = null;

            try
            {
                Console.WriteLine(testString.Length);
                Console.WriteLine("code after exception");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argument exception");
                Console.WriteLine(e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("null reference exception");
                Console.WriteLine(e.Message);
                //throw;
            }


            Console.ReadKey();



        }
    }
}
