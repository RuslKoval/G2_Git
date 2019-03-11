using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_G2
{
    public class ParentClass
    {
        public int myInt = 1;
        public char myChar = 'A';

        public virtual void TestMethod()
        {            
            Console.WriteLine("Parent Class");
        }

        public int GetSumOfTwoInteger(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int GetSumOfTwoInteger(int firstNumber, string secondNumber)
        {
            return 0;
        }
        public int GetSumOfTwoInteger(string firstNumber, int secondNumber)
        {
            return 1;
        }
        public int GetSumOfTwoIntegerA(int firstNumber)
        {
            int secondNumber = 2;
            return firstNumber + secondNumber;
        }

        public void PrintSumOfTwoInteger(int firstNumber, int secondNumber)
        {
            Console.WriteLine(GetSumOfTwoInteger(firstNumber, secondNumber));
        }

    }
}
