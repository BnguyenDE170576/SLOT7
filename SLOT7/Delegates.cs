using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot7
{
    internal class Delegates
    {
        public delegate int MyDelegate(int a, int b);
        class Program
        {
            static int Add(int a, int b) => a + b;
            static int Sub(int a, int b) => a - b;

            static void Main(string[] args)
            {
                int n1 = 25;
                int n2 = 15;
                int result;

                MyDelegate obj1 = new MyDelegate(Add);
                result = obj1(n1, n2);
                Console.WriteLine($"{n1} + {n2}, result: {result}");

                MyDelegate obj2 = Sub;
                result = obj2.Invoke(n1, n2);
                Console.WriteLine($"{n1} - {n2}, result: {result}");
                Console.ReadLine();
            }
        }
    }
}

