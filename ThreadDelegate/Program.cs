using System;
using System.Threading;

namespace ThreadDelegate
{

    internal delegate void BinaryOperation(int a, int y);

    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("[{0}] Main called, ", Thread.CurrentThread.ManagedThreadId);
            BinaryOperation asyncAdd = Add;
            asyncAdd.BeginInvoke(2, 2, null, null);
            Thread.Sleep(1000);
            Console.WriteLine("[{0}] Main finished, ", Thread.CurrentThread.ManagedThreadId);
            Console.ReadKey();
        }


        static void Add(int a, int b)
        {
            Console.WriteLine("[{0}] Add({1}, {2}) => {3}",
                Thread.CurrentThread.ManagedThreadId,
                a, b, (a + b ));
        }
    }
}
