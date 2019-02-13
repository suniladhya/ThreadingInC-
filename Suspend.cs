using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading.Suspend
{
    public class FirstThread
    {
        public void CreateFirstThread()
        {
            Thread firstThread = new Thread(FirstFunction);
            firstThread.Name = "First Thread";
            Console.WriteLine("Threading Starts...");
            firstThread.Start();
            firstThread.

            Console.WriteLine("Thread Properties...");
            ThreadProperties(firstThread);
        }

        private void ThreadProperties(Thread firstThread)
        {
            Console.WriteLine("ThreadName: " + firstThread.Name);
            Console.WriteLine("CurrentCulture: " + firstThread.CurrentCulture);
            Console.WriteLine("CurrentUICulture: " + firstThread.CurrentUICulture);
            Console.WriteLine("ExecutionContext: " + firstThread.ExecutionContext);
            Console.WriteLine("IsAlive: " + firstThread.IsAlive);
            Console.WriteLine("IsBackground: " + firstThread.IsBackground);
            Console.WriteLine("IsThreadPoolThread: " + firstThread.IsThreadPoolThread);
            Console.WriteLine("ManagedThreadId: " + firstThread.ManagedThreadId);
            Console.WriteLine("Priority: " + firstThread.Priority);
            Console.WriteLine("ThreadState: " + firstThread.ThreadState);

        }

        public void FirstFunction()
        {
            for (int i = 0; i < 25; i++)
            {
                int time = new Random().Next(25, 50);
                Console.WriteLine("FirstThread Slept for : {0} Milliseconds", time.ToString());
                Console.WriteLine("First thread Displays: " + i);
                Thread.Sleep(time);
            }
            Console.WriteLine("\nPress enter to quit...");
            Console.ReadLine();
        }
    }
}
