using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region array
            int[] array = new int[5];

            array[0] = 45;
            //array[1] = "string";
            array[2] = 'c';

            int[] intArray = { 23, 54, 2, 9 };
            var newArray1 = Array.CreateInstance(array.GetType(), 4);
            #endregion

            #region While

            int counter = 1;

            while (counter<10)
            {
                Console.WriteLine(counter);
                //counter++;
            }

            Console.ReadKey();
            #endregion

            #region DoWhile

            do
            {

            } while (false);

            #endregion

            #region For

            for (int i = 1; i < 6; i++)
            {
                //if (i == 3)
                //{
                //    break;
                //}

                if (i == 3)
                {                    
                    continue;                    
                }
            
                Console.WriteLine(i);
           
            }

            #endregion

            #region Foreach

            int[] array2 = { 2,3,4,5};

            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }

            #endregion




        }
    }
}
