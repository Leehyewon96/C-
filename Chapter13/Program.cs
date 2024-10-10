using System;

namespace Delegate
{
    delegate int MyDelegate(int a, int b);

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Calculator Calc = new Calculator();
        //    MyDelegate Callback;

        //    Callback = new MyDelegate(Calc.Plus);
        //    Console.WriteLine(Callback(3, 4));

        //    Callback = new MyDelegate(Calculator.Minus);
        //    Console.WriteLine(Callback(7, 5));
        //}
    }
}

namespace UsingCallback
{
    delegate int Compare(int a, int b);

    class MainApp
    {
        static int AscendCompare(int a, int b)
        {
            if(a > b)
            {
                return 1;
            }
            else if(a == b)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        static int DescendCompare(int a, int b)
        {
            if(a < b)
            {
                return 1;
            }
            else if(a == b)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        static void BubbleSort(int[] DataSet, Compare Comparer)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for(i = 0; i < DataSet.Length - 1; i++)
            {
                for(j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        //static void Main(string[] args)
        //{
        //    int[] array = { 3, 7, 4, 2, 10 };

        //    Console.WriteLine("Sorting ascending...");
        //    BubbleSort(array, new Compare(AscendCompare));

        //    for(int i = 0; i < array.Length; i++)
        //    {
        //        Console.Write($"{array[i]} ");
        //    }

        //    int[] array2 = { 7, 2, 8, 10, 11 };
        //    Console.WriteLine("\nSorting descending...");
        //    BubbleSort(array2, new Compare(DescendCompare));
        //    for (int i = 0; i < array2.Length; i++)
        //    {
        //        Console.Write($"{array2[i]} ");
        //    }

        //    Console.WriteLine();
        //}
    }
}

namespace GenericDelegate
{
    delegate int Compare<T>(T a, T b);
    
    class MainApp
    {
        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
        }

        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) * -1;
        }

        static void BubbleSort<T>(T[] DataSet, Compare<T> comparer)
        {
            T temp;
            for(int i = 0; i< DataSet.Length - 1; i++)
            {
                for(int j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j];
                        DataSet[j] = DataSet[j + 1];
                        DataSet[j + 1] = temp;
                    }
                }
            }
        }

        //static void Main(string[] args)
        //{
        //    int[] array = { 3, 7, 4, 2, 10 };

        //    Console.WriteLine("Sorting ascending...");
        //    BubbleSort<int>(array, new Compare<int>(AscendCompare));

        //    for(int i = 0; i < array.Length; i++)
        //    {
        //        Console.Write($"{array[i]} ");
        //    }

        //    Console.WriteLine();

        //    string[] array2 = { "abc", "def", "ghi", "jkl", "mno" };

        //    Console.WriteLine("Sorting descending...");
        //    BubbleSort<string>(array2, new Compare<string>(DescendCompare));

        //    for (int i = 0; i < array2.Length; i++)
        //    {
        //        Console.Write($"{array2[i]} ");
        //    }

        //    Console.WriteLine();
        //}
    }
}

namespace DelegateChains
{
    delegate void Notify(string message);

    class Notifier
    {
        public Notify EventOccured;
    }

    class EventLister
    {
        private string name;
        public EventLister(string name)
        {
            this.name = name;
        }

        public void SomethingHappened(string message)
        {
            Console.WriteLine($"{name}.SomethingHappened : {message}");
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Notifier notifier = new Notifier();
        //    EventLister listener1 = new EventLister("Listener1");
        //    EventLister listener2 = new EventLister("Listener2");
        //    EventLister listener3 = new EventLister("Listener3");

        //    notifier.EventOccured += listener1.SomethingHappened;
        //    notifier.EventOccured += listener2.SomethingHappened;
        //    notifier.EventOccured += listener3.SomethingHappened;
        //    notifier.EventOccured("You've got mail."); // 호출

        //    Console.WriteLine();

        //    notifier.EventOccured -= listener2.SomethingHappened;
        //    notifier.EventOccured("Download complete."); // 호출

        //    Console.WriteLine();

        //    notifier.EventOccured = new Notify(listener2.SomethingHappened)
        //        + new Notify(listener3.SomethingHappened);
        //    notifier.EventOccured("Nuclear launch detected.");

        //    Console.WriteLine();

        //    Notify notify1 = new Notify(listener1.SomethingHappened);
        //    Notify notify2 = new Notify(listener2.SomethingHappened);

        //    notifier.EventOccured = (Notify)System.Delegate.Combine(notify1, notify2);
        //    notifier.EventOccured("Fire!!");

        //    Console.WriteLine();

        //    notifier.EventOccured = (Notify)System.Delegate.Remove(notifier.EventOccured, notify2);
        //    notifier.EventOccured("RPG!");
        //}
    }
}

namespace AnonymousMethod
{
    delegate int Compare(int a, int b);

    class MainApp
    {
        static void BubbleSort(int[] DataSet, Compare compare)
        {
            int temp = 0;
            for(int i = 0; i < DataSet.Length - 1; i++)
            {
                for(int j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (compare(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j];
                        DataSet[j] = DataSet[j + 1];
                        DataSet[j + 1] = temp;
                    }
                }
            }
        }

        //static void Main(string[] args)
        //{
        //    int[] array = { 3, 7, 4, 2, 10 };

        //    Console.WriteLine("Sorting ascending...");
        //    BubbleSort(array, delegate (int a, int b)
        //    {
        //        if(a > b)
        //        {
        //            return 1;
        //        }
        //        else if(a == b)
        //        {
        //            return 0;
        //        }
        //        else
        //        {
        //            return -1;
        //        }
        //    });

        //    for(int i = 0; i < array.Length; i++)
        //    {
        //        Console.Write($"{array[i]} ");
        //    }

        //    Console.WriteLine();

        //    int[] array2 = { 7, 2, 8, 10, 11 };
        //    Console.WriteLine("Sorting descending...");

        //    BubbleSort(array2, delegate (int a, int b)
        //    {
        //        if(a < b)
        //        {
        //            return 1;
        //        }
        //        else if(a == b)
        //        {
        //            return 0; 
        //        }
        //        else
        //        {
        //            return -1;
        //        }
        //    });

        //    for (int i = 0; i < array2.Length; i++)
        //    {
        //        Console.Write($"{array2[i]} ");
        //    }
        //}
    }
}

namespace EventTest
{
    delegate void EventHandler(string message);

    class MyNotifier
    {
        public event EventHandler SomethingHappened;

        public void DoSomething(int number)
        {
            int temp = number % 10;
            if(temp != 0 && temp % 3 == 0)
            {
                SomethingHappened(String.Format("{0} : 짝", number));
            }
        }
    }

    class MainApp
    {
        static void MyHandler(string message)
        {
            Console.WriteLine(message);
        }

        //static void Main(string[] args)
        //{
        //    MyNotifier notifier = new MyNotifier();
        //    notifier.SomethingHappened += new EventHandler(MyHandler);

        //    for(int i = 1; i < 30; i++)
        //    {
        //        notifier.DoSomething(i);
        //    }
        //}
    }
}

namespace Ex13_1
{
    delegate int MyDelegate(int a, int b);

    class MainApp
    { 
        //static void Main(string[] args)
        //{
        //    MyDelegate Callback;

        //    Callback = new MyDelegate(delegate(int a, int b)
        //    {
        //        return a + b;
        //    });

        //    Console.WriteLine(Callback(3, 4));

        //    Callback = new MyDelegate(delegate (int a, int b)
        //    {
        //        return a - b;
        //    });

        //    Console.WriteLine(Callback(7, 5));
        //}
    }
}

namespace Ex13_2
{
    delegate void MyDelegate(int a);

    class Market
    {
        public event MyDelegate CustomerEvent;

        public void BuySomething(int CustomerNo)
        {
            if(CustomerNo == 30)
            {
                CustomerEvent(30);
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Market market = new Market();
            market.CustomerEvent += new MyDelegate(delegate (int a)
            {
                Console.WriteLine($"축하합니다! {a}번째 고객 이벤트에 당첨되셨습니다.");
            });

            for(int i = 0; i < 100; i++)
            {
                market.BuySomething(i);
            }
        }
    }
}
