using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot7
{
    internal class Lambdas
    {
        class Program
        {
            static void Main(string[] args)
            {
                string[] names = { "david", "Jane", "Peter", "John", "Mark" };
                foreach (string item in names.OrderBy(s=>s)) 
                { 
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }
        }
    }
}
