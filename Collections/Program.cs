using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> testList = new List<string>();
            Console.WriteLine(testList.Count());
            testList.Add("str1");
            Console.WriteLine(testList.Count());
            Console.WriteLine(testList.Exists(st => st.Contains("3")));
         


            Dictionary<int, string> testDictionary = new Dictionary<int, string>();
            testDictionary.Add(0, "test 0");
            testDictionary.Add(1, "test 1");
            testDictionary.Add(2, "test 2");
            testDictionary.Add(3, "test 3");
            testDictionary.Add(4, "test 4");

            var keys = testDictionary.Keys;

            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }

            var values = testDictionary.Values;

            foreach (var value in values)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();

            

        }
    }
}
