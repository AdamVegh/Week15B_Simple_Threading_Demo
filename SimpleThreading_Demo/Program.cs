using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleThreading_Demo
{
	class Program
	{
		static void Counting()
		{
			for (int i = 1; i <= 10; i++)
			{
				Console.WriteLine("Count: {0}, Thread ID: {1}", i, Thread.CurrentThread.ManagedThreadId);
				Thread.Sleep(10);
			}
		}

		static void Main(string[] args)
		{
			ThreadStart threadStart = new ThreadStart(Counting);
			Thread thread1 = new Thread(threadStart);
			Thread thread2 = new Thread(threadStart);

			Console.WriteLine("Thread1 starts...");
			thread1.Start();
			Console.WriteLine("Thread2 starts...");
			thread2.Start();

			thread1.Join();
			thread2.Join();
			Console.WriteLine("Thread1 and thread2 are joined...");

			Console.WriteLine("Press enter to exit...");
			Console.ReadLine();
		}
	}
}
