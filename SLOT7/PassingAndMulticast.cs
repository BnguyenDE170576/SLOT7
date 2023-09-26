using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot7
{
    internal class PassingAndMulticast
    {
        public delegate void MyDelegate(string msg);

        class MyClass
        {
            public static void Print(string msg) => Console.WriteLine($"{msg.ToUpper()}");
            public static void Show(string msg) => Console.WriteLine($"{msg.ToLower()}");
            public static void Display(string msg) => Console.WriteLine($"{msg}");
        }

        class Program
        {
            static void InvokeDelegate(MyDelegate dele, string msg) => dele(msg);

            static void Main(string[] args)
            {
                string msg = "Passing Delegate As A Parameter";
                InvokeDelegate(MyClass.Print, msg);
                InvokeDelegate(MyClass.Show, msg);

                //--------------------------
                msg = "Multicast Delegate";

                MyDelegate MyDele01 = MyClass.Print;

                MyDelegate MyDele02 = MyClass.Show;
                Console.WriteLine("***Combines MyDele01 + MyDele02***");
                MyDelegate myDele = MyDele01 + MyDele02;
                myDele(msg);
                Console.WriteLine("***Combines MyDele01 + MyDele02 + MyDele03***");
                MyDelegate myDele03 = MyClass.Display;
                myDele03 += myDele03;
                myDele(msg);
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Remove MyDele2: ");
                myDele -= MyDele02;
                myDele("hello ");

                Console.ReadLine();



                Console.ReadLine();
            }

        }

    }



}
