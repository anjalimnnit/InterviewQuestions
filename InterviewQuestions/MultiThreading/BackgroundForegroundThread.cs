using System;
using System.Threading;


namespace MultiThreading
{
    class BackgroundForegroundThread
    {
        public static void Main()
        {
           Console.WriteLine($"Main is executed by thread with id :{Thread.CurrentThread.ManagedThreadId}");
            ThreadPool.QueueUserWorkItem(new WaitCallback(ForegroundTask));
           Thread foreground = new Thread(() => ForegroundTask());
            Thread foreground1 = new Thread(() => ForegroundTask1());
            Thread background = new Thread(() => BackgroundTask()){ IsBackground = true};
           foreground.Start();
            foreground1.Start();
           background.Start();
            Console.WriteLine($"Main is exiting");
        }

        // Stops running once all the foreground thread completes there execution
        public static void BackgroundTask()
        {
            for(int i =0;i<15;i++)
            {
                Console.WriteLine($"Task{i} is executed by background thread{Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Background thread finished execution");
        }

        // Runs even after the main thread completes it execution
        public static void ForegroundTask()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Task{i} is executed by foreground thread{Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Foreground thread finished execution");
        }

        public static void ForegroundTask1()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Task{i} is executed by foreground1 thread{Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Foreground thread1 finished execution");
        }
    }
}
