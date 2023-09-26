using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot7
{
    internal class Generic
    {
        class Program
        {
            static int Sum(int x, int y) => x + y;
            static void Print(string msg) => Console.WriteLine(msg.ToUpper());
            static void Main(string[] args)
            {
                int a = 15, b=25,s;
                string result;

                Func<int, int, int> sumFunc = Sum;
                s = sumFunc(a, b);
                result = $"{a}+{b}={s}";
                Console.WriteLine("invoke Print method by Action delegate");

                Action<string> action = Print;
                action(result);

                Console.ReadLine();
            }
        }
    }
}
