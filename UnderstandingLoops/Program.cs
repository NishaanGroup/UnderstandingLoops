using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintFibonacci(20);
            //PrintFibonacciRecursive(0, 1, 1, 10);
            int i = 10;
            string num = i.ToString();

            string count = "20Mma";
            int counter;
            bool isParsed = int.TryParse(count, out counter);
            if (isParsed)
            {
                Console.WriteLine(counter);
            }
            else
            {
                Console.WriteLine("Cannot convert the string to integer");
            }
            Console.ReadKey();
        }
        static void PrintFibonacci(int count)
        {
            int start = 0;
            int first = 1;
            
            for(int i =0; i < count; i++)
            {
                int temp = start;//0
                start = first;//
                first = temp + start;//
                //0,1,1,2,3,5,8,13,21...
                Console.WriteLine(start);
            }
            Console.ReadKey();
        }

        static void PrintFibonacciRecursive(int a, int b,int counter,int length)
        {
            if (counter < length)
            {
                Console.WriteLine(a);
                PrintFibonacciRecursive(b, a + b, counter + 1, length);
            }
            Console.ReadKey();

        }
        
    }
}
