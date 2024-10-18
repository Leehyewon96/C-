using Synchronize;
using System;
using System.Numerics;
using System.Threading;

namespace BasicThread
{
    class MainApp
    {
        static void DoSomething()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10); //10ms 동안 CPU 사용을 멈춤
            }
        }

        //static void Main(string[] args)
        //{
        //    Thread t1 = new Thread(new ThreadStart(DoSomething));

        //    Console.WriteLine("Starting thread...");
        //    t1.Start();

        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine($"Main : {i}");
        //        Thread.Sleep(10);
        //    }

        //    Console.WriteLine("Waiting until thread stops...");
        //    t1.Join();

        //    Console.WriteLine("Finished");

        //}
    }
}

namespace UsingThreadState
{
    class MainApp
    {
        private static void PrintThreadState(ThreadState state)
        {
            Console.WriteLine("{0,-16} : {1}", state, (int)state);
        }

        //static void Main(string[] args)
        //{
        //    PrintThreadState(ThreadState.Running);
        //    PrintThreadState(ThreadState.StopRequested);
        //    PrintThreadState(ThreadState.SuspendRequested);
        //    PrintThreadState(ThreadState.Background);
        //    PrintThreadState(ThreadState.Unstarted);
        //    PrintThreadState(ThreadState.Stopped);
        //    PrintThreadState(ThreadState.WaitSleepJoin);
        //    PrintThreadState(ThreadState.Suspended);
        //    PrintThreadState(ThreadState.AbortRequested);
        //    PrintThreadState(ThreadState.Aborted);
        //    PrintThreadState(ThreadState.Aborted | ThreadState.Stopped);
        //}
    }
}

namespace InterruptingThread
{
    class SideTask
    {
        int count;

        public SideTask(int count)
        {
            this.count = count;
        }

        public void KeepAlive()
        {
            try
            {
                Console.WriteLine("Running thread isn't gonna be intrrupted");
                Thread.Sleep(100);

                while(count > 0)
                {
                    Console.WriteLine($"{count--} left");

                    Console.WriteLine("Entering into WaitJoinSleep State...");
                    Thread.Sleep(10);
                }

                Console.WriteLine("Count : 0");
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Clearing resource...");
            }
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    SideTask task = new SideTask(100);
        //    Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
        //    t1.IsBackground = false;

        //    Console.WriteLine("Starting Thread...");
        //    t1.Start();

        //    Thread.Sleep(100);

        //    Console.WriteLine("Interrupting Thread...");
        //    t1.Interrupt();

        //    Console.WriteLine("Waiting until thread stops...");
        //    t1.Join();

        //    Console.WriteLine("Finished");
        //}
    }
}

namespace Synchronize
{
    class Counter
    {
        const int LOOP_COUNT = 1000;
        readonly object thisLock;

        private int count;
        public int Count
        {
            get { return count; }
        }
        
        public Counter()
        {
            thisLock = new object();
            count = 0;
        }

        public void Increase()
        {
            int loopCount = LOOP_COUNT;

            while(loopCount-- > 0)
            {
                lock (thisLock)
                {
                    count++;
                }
                //count++;
                Thread.Sleep(1);
            }
        }

        public void Decrease()
        {
            int loopCount = LOOP_COUNT;
            while(loopCount-- > 0)
            {
                lock (thisLock)
                {
                    count--;
                }
                //count--;
                Thread.Sleep(1);
            }
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Counter counter = new Counter();

        //    Thread incThread = new Thread(
        //        new ThreadStart(counter.Increase));

        //    Thread decThread = new Thread(
        //        new ThreadStart(counter.Decrease));

        //    incThread.Start();
        //    decThread.Start();

        //    incThread.Join();
        //    decThread.Join();

        //    Console.WriteLine(counter.Count);
        //}
    }
}

namespace UsingMonitor
{
    class Counter
    {
        const int LOOP_COUNT = 1000;

        readonly object thisLock;

        private int count;
        public int Count
        {
            get { return count; }
        }

        public Counter()
        {
            thisLock = new object();
        }

        public void Increase()
        {
            int loopCount = LOOP_COUNT;
            while(loopCount-- > 0)
            {
                Monitor.Enter(thisLock);
                try
                {
                    Console.WriteLine($"Inc count : {count}");
                    count++;
                    
                }
                finally
                {
                    Monitor.Exit(thisLock);
                }
                Thread.Sleep(1);
            }
        }

        public void Decrease()
        {
            int loopCount = LOOP_COUNT;
            while (loopCount-- > 0)
            {
                Monitor.Enter(thisLock);
                try
                {
                    Console.WriteLine($"Dec count : {count}");
                    count--;
                    
                }
                finally
                {
                    Monitor.Exit(thisLock);
                }
                Thread.Sleep(1);
            }
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Counter counter = new Counter();

        //    Thread incThread = new Thread(new ThreadStart(counter.Increase));
        //    Thread decThread = new Thread(new ThreadStart(counter.Decrease));

        //    incThread.Start();
        //    decThread.Start();

        //    incThread.Join();
        //    decThread.Join();

        //    Console.WriteLine(counter.Count);
        //}
    }
}

namespace WaitPulse
{
    class Counter
    {
        const int LOOP_COUNT = 1000;
        readonly object thisLock;
        bool lockedCount = false;

        private int count;
        public int Count
        {
            get { return count; }
        }

        public Counter()
        {
            thisLock = new object();
            count = 0;
        }

        public void Increase()
        {
            lock(thisLock)
            {
                while(count > 0 || lockedCount == true)
                {
                    Monitor.Wait(thisLock);
                }

                lockedCount = true;
                count++;
                lockedCount = false;

                Monitor.Pulse(thisLock);
            }
        }

        public void Decrease()
        {
            lock(thisLock)
            {
                while(count < 0 || lockedCount == true)
                {
                    Monitor.Wait(thisLock);
                }

                lockedCount = true;
                count--;
                lockedCount = false;

                Monitor.Pulse(thisLock);
            }
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Counter counter = new Counter();

        //    Thread t1 = new Thread(new ThreadStart(counter.Increase));
        //    Thread t2 = new Thread(new ThreadStart(counter.Decrease));

        //    t1.Start();
        //    t2.Start();

        //    t1.Join();
        //    t2.Join();

        //    Console.WriteLine(counter.Count);
        //}
    }
}

namespace UsingTask
{
    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    string srcFile = args[0];

        //    Action<object> FileCopyAction = (object state) =>
        //    {
        //        String[] paths = (String[])state;
        //        File.Copy(paths[0], paths[1]);

        //        Console.WriteLine("TaskID:{0}, ThreadID:{1}, {2} was copied to {3}",
        //            Task.CurrentId, Thread.CurrentThread.ManagedThreadId, paths[0], paths[1]);
        //    };

        //    Task t1 = new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy1" });
        //    Task t2 = Task.Run(() =>
        //    {
        //        FileCopyAction(new string[] { srcFile, srcFile + ".copy2" });
        //    });

        //    t1.Start();

        //    Task t3 = new Task(FileCopyAction, new string[] {srcFile, srcFile + ".copy3"});

        //    t3.RunSynchronously();

        //    t1.Wait();
        //    t2.Wait();
        //    t3.Wait();

        //}
    }
}

namespace TaskResult
{
    class MainApp
    {
        static bool IsPrime(long number)
        {
            if(number < 2)
            {
                return false;
            }

            if (number % 2 == 0 && number != 2)
            {
                return false;
            }

            for(long i = 2; i < number; i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        //static void Main(string[] args)
        //{
        //    long from = Convert.ToInt64(args[0]);
        //    long to = Convert.ToInt64(args[1]);
        //    int taskCount = Convert.ToInt32(args[2]);

        //    Func<object, List<long>> FindPrimeFunc =
        //        (objRange) =>
        //        {
        //            long[] range = (long[])objRange;
        //            List<long> found = new List<long>();

        //            for (long i = range[0]; i < range[1]; i++)
        //            {
        //                if (IsPrime(i))
        //                {
        //                    found.Add(i);
        //                }
        //            }

        //            return found;
        //        };

        //    Task<List<long>>[] tasks = new Task<List<long>>[taskCount];
        //    long currentFrom = from;
        //    long currentTo = to / tasks.Length;
        //    for(int i = 0; i < tasks.Length; i++)
        //    {
        //        Console.WriteLine("Task[{0}] : {1} ~ {2}", i, currentFrom, currentTo);
        //        tasks[i] = new Task<List<long>>(FindPrimeFunc, new long[] { currentFrom, currentTo });
        //        currentFrom = currentTo + 1;

        //        if(i == tasks.Length - 2)
        //        {
        //            currentTo = to;
        //        }
        //        else
        //        {
        //            currentTo = currentTo + (to / tasks.Length);
        //        }
        //    }

        //    Console.WriteLine("Please press enter to start...");
        //    Console.ReadLine();
        //    Console.WriteLine("Started...");

        //    DateTime startTime = DateTime.Now;
        //    foreach(Task<List<long>> task in tasks)
        //    {
        //        task.Start();
        //    }

        //    List<long> total = new List<long>();

        //    foreach (Task<List<long>> task in tasks)
        //    {
        //        task.Wait();
        //        total.AddRange(task.Result.ToArray());
        //    }

        //    DateTime endTime = DateTime.Now;

        //    TimeSpan elapsed = endTime - startTime;

        //    Console.WriteLine("Prime number count between {0} and {1} : {2}", from, to, total.Count);
        //    Console.WriteLine("Elapsed time : {0}", elapsed);
        //}
    }
}

namespace ParallelLoop
{
    class MainApp
    {
        static bool IsPrime(long number)
        {
            if(number < 2)
            {
                return false;
            }

            if(number % 2 == 0 && number != 2)
            {
                return false;
            }

            for(long i = 2; i < number; i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        //static void Main(string[] args)
        //{
        //    long from = Convert.ToInt64(args[0]);
        //    long to = Convert.ToInt64(args[1]);

        //    Console.WriteLine("Please press enter to start...");
        //    Console.ReadLine();
        //    Console.WriteLine("Started...");

        //    DateTime startTime = DateTime.Now;
        //    List<long> total = new List<long>();

        //    Parallel.For(from, to, (long i) =>
        //    {
        //        if (IsPrime(i))
        //        {
        //            lock (total)
        //            {
        //                total.Add(i);
        //            }
        //        }
        //    });

        //    DateTime endTime = DateTime.Now;

        //    TimeSpan elapsed = endTime - startTime;

        //    Console.WriteLine("Prime number count between {0} and {1} : {2}", from, to, total.Count);
        //    Console.WriteLine("Elapsed time : {0}", elapsed);
        //}
    }
}

namespace Async
{
    class MainApp
    {
        async static private void MyMethodAsync(int count)
        {
            Console.WriteLine("C");
            Console.WriteLine("D");

            await Task.Run(async () =>
            {
                for (int i = 0; i <= count; i++)
                {
                    Console.WriteLine($"{i}/{count}...");
                    await Task.Delay(100);
                }
            });

            Console.WriteLine("G");
            Console.WriteLine("H");
        }

        static void Caller()
        {
            Console.WriteLine("A");
            Console.WriteLine("B");

            MyMethodAsync(3);

            Console.WriteLine("E");
            Console.WriteLine("F");
        }

        //static void Main(string[] args)
        //{
        //    Caller();

        //    Console.ReadLine();
        //}
    }
}

namespace AsyncFileIO
{
    class MainApp
    {
        static async Task<long> CopyAsync(string FromPath, string ToPath)
        {
            using (var fromStream = new FileStream(FromPath, FileMode.Open))
            {
                long totalCopied = 0;

                using (var toStream = new FileStream(ToPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024];
                    int nRead = 0;
                    while((nRead = await fromStream.ReadAsync(buffer, 0, buffer.Length))!=0)
                    {
                        await toStream.WriteAsync(buffer, 0, nRead);
                        totalCopied += nRead;
                    }

                   
                }

                return totalCopied;
            }
        }

        static async void DoCopy(string FromPath, string ToPath)
        {
            long totalCopied = await CopyAsync(FromPath, ToPath);
            Console.WriteLine($"Copied Total {totalCopied} Bytes");
        }

        static void Main(string[] args)
        {
            if(args.Length < 2)
            {
                Console.WriteLine("Usage : AsyncFileIO <Source> <Destination>");
                return;
            }

            DoCopy(args[0], args[1]);

            Console.ReadLine();
        }
    }

}