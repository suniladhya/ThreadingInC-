using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    public class FirstThread
    {
        public void CreateFirstThread()
        {
            Thread FirstThread = new Thread(FirstFunction);
            FirstThread.Name = "First Thread";
            Console.WriteLine("Threading Starts...");
            FirstThread.Start();
            

            Console.WriteLine("Thread Properties...");
            ThreadProperties(FirstThread);
        }

        private void ThreadProperties(Thread firstThread)
        {
            Console.WriteLine("ThreadName: " + firstThread.Name);
            Console.WriteLine("CurrentCulture: "+ firstThread.CurrentCulture);
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
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("First thread Displays: "+ i);
            }
            Console.WriteLine("\nPress enter to quit...");
            Console.ReadLine();
        }
    }
}