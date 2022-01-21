// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Threading;
class Program
{
    static void Counting()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Count: {0} - Thread {1} ", i, Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(10);
        }

    }
    static void Main(string[] args)
    {
        ThreadStart starter = new ThreadStart(Counting);
        Thread first = new Thread(starter);
        Thread second = new Thread(starter);
        Thread third = new Thread(starter);
        Thread fourth = new Thread(starter);
        first.Start();
        second.Start();
        third.Start();
        fourth.Start();
        first.Join(); 
        second.Join();
        third.Join();
        fourth.Join();
        //Console.Read();

    }

}

