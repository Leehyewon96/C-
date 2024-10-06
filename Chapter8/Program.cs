using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Interface
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(
                "{0} {1}",
                DateTime.Now.ToLocalTime(), message);
        }
    }

    class FileLogger : ILogger
    {
        private StreamWriter writer;
        
        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            writer.WriteLine("{0} {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }

    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }

        public void Start()
        {
            while(true)
            {
                Console.WriteLine("온도를 입력해주세요.: ");
                string temperature = Console.ReadLine();
                if(temperature == "")
                {
                    break;
                }

                logger.WriteLog("현재온도 : " + temperature);
            }
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    //ClimateMonitor monitor = new ClimateMonitor(
        //    //    new FileLogger("MyLog.txt"));

        //    ClimateMonitor monitor = new ClimateMonitor(new ConsoleLogger());

        //    monitor.Start();
        //}
    }
}

namespace DerivedInterface
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params object[] args);
    }

    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}",
                DateTime.Now.ToLocalTime(), message);
        }

        public void WriteLog(string format, params object[] args)
        {
            string message = String.Format(format, args);
            Console.WriteLine("{0} {1}",
                DateTime.Now.ToLocalTime(), message);
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    IFormattableLogger logger = new ConsoleLogger2();
        //    logger.WriteLog("The World is not flat.");
        //    logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);
        //}
    }
}

namespace MultiInterfaceInheritance
{
    interface IRunnable
    {
        void Run();
    }

    interface IFlyable
    {
        void Fly();
    }

    class FlyingCar : IRunnable, IFlyable
    {
        public void Run()
        {
            Console.WriteLine("Run! Run!");
        }

        public void Fly()
        {
            Console.WriteLine("Fly! Fly!");
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    FlyingCar car = new FlyingCar();
        //    car.Run();
        //    car.Fly();

        //    IRunnable runnable = car as IRunnable;
        //    runnable.Run();

        //    IFlyable flyable = car as IFlyable;
        //    flyable.Fly();
        //}
    }
}

namespace DefaultImplementation
{
    interface ILogger
    {
        void WriteLog(string message);

        void WriteError(string error)
        {
            WriteLog($"Error: {error}");
        }
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}", message);
        }
    }

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        ILogger logger = new ConsoleLogger();
    //        logger.WriteLog("System Up");
    //        logger.WriteError("System Fail");

    //        ConsoleLogger clogger = new ConsoleLogger();
    //        clogger.WriteLog("System Up");
    //    }
    //}
}

namespace AbstractClass
{
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }

        public void publicMethodA()
        {
            Console.WriteLine("AbstractBase.publicMethodA()");
        }

        public abstract void AbstractMethodA();
    }

    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            Console.WriteLine("Derived.AbstractMethodA()");
            PrivateMethodA();
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.publicMethodA();
        }
    }
}
