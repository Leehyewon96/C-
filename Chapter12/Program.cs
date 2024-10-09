using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TryCatch
{
    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    int[] arr = { 1, 2, 3 };

        //    try
        //    {
        //        for (int i = 0; i < 5; i++)
        //        {
        //            Console.WriteLine(arr[i]);
        //        }
        //    }
        //    catch (IndexOutOfRangeException e)
        //    {
        //        Console.WriteLine($"예외가 발생했습니다 : {e.Message}");
        //    }

        //    Console.WriteLine("종료");
        //}
    }
}

namespace Throw
{
    class MainApp
    {
        static void DoSomething(int arg)
        {
            if (arg < 10)
            {
                Console.WriteLine($"args : {arg}");
            }
            else
            {
                throw new Exception("arg가 10보다 큽니다.");
            }
        }

        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        DoSomething(1);
        //        DoSomething(3);
        //        DoSomething(5);
        //        DoSomething(9);
        //        DoSomething(11);
        //        DoSomething(13);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }
        //}
    }
}

namespace ThrowException
{
    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        int? a = null;
        //        int? b = a ?? throw new ArgumentNullException();
        //    }
        //    catch (ArgumentNullException e)
        //    {
        //        Console.WriteLine(e);
        //    }

        //    try
        //    {
        //        int[] array = new[] { 1, 2, 3 };
        //        int index = 4;
        //        int value = array[
        //            index >= 0 && index < 3
        //            ? index : throw new IndexOutOfRangeException()
        //            ];
        //    }
        //    catch(IndexOutOfRangeException e)
        //    {
        //        Console.WriteLine(e);
        //    }
        //}
    }
}

namespace Finally
{ 
    class MainApp
    {
        static int Divide(int dividend, int divisor)
        {
            try
            {
                Console.WriteLine("Divide() 시작");
                return dividend / divisor;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide() 예외 발생");
                
                throw e;
            }
            finally
            {
                Console.WriteLine("Divide() 끝");
            }
        }

        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        Console.Write("피제수를 입력하세요. :");
        //        String temp = Console.ReadLine();
        //        int dividend = Convert.ToInt32(temp);

        //        Console.Write("제수를 입력하세요. :");
        //        temp = Console.ReadLine();
        //        int divisor = Convert.ToInt32(temp);

        //        Console.WriteLine("{0}/{1} = {2}", dividend, divisor, Divide(dividend, divisor));
        //    }
        //    catch (FormatException e)
        //    {
        //        Console.WriteLine("에러 : " + e.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("프로그램을 종료합니다.");
        //    }
        //}
    }
}

namespace MyException
{
    class InvalidArgumentException : Exception
    {
        public InvalidArgumentException()
        {

        }

        public InvalidArgumentException(string message)
            : base(message)
        {

        }

        public object Argument
        {
            get;
            set;
        }

        public string Range
        {
            get;
            set;
        }
    }

    class MainApp
    {
        static uint MergeARGB(uint alpha, uint red, uint green, uint blue)
        {
            uint[] args = new uint[] { alpha, red, green, blue };
            
            foreach(uint arg in args)
            {
                if(arg > 255)
                {
                    throw new InvalidArgumentException()
                    {
                        Argument = arg,
                        Range = "0~255"
                    };
                }
            }

            return (alpha << 24 & 0xFF000000) |
                   (red   << 16 & 0x00FF0000) |
                   (green << 8  & 0x0000FF00) |
                   (blue        & 0x000000FF);
        }

        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        Console.WriteLine($"0x{0:X}", MergeARGB(255, 111, 111, 111));
        //        Console.WriteLine($"0x{0:X}", MergeARGB(1, 65, 192, 128));
        //        Console.WriteLine($"0x{0:X}", MergeARGB(0, 255, 255, 300));
        //    }
        //    catch (InvalidArgumentException e)
        //    {
        //        Console.WriteLine(e.Message);
        //        Console.WriteLine($"Argument:{e.Argument}, Range:{e.Range}");
        //    }
        //}
    }
}

namespace ExceptionFiltering
{
    class FilterableException : Exception
    {
        public int ErrorNo { get; set; }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter Number Between 0~10");
        //    string input = Console.ReadLine();
        //    try
        //    {
        //        int num = Int32.Parse(input);

        //        if(num < 0 || num>10)
        //        {
        //            throw new FilterableException()
        //            {
        //                ErrorNo = num
        //            };
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Output : {num}");
        //        }
        //    }
        //    catch(FilterableException e) when (e.ErrorNo < 10)
        //    {
        //        Console.WriteLine("Negative input is not allowed.");
        //    }
        //    catch(FilterableException e) when (e.ErrorNo > 10)
        //    {
        //        Console.WriteLine("Too big number is not allowed.");
        //    }
        //}
    }
}

namespace StackTrace
{
    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        int a = 1;
        //        Console.WriteLine(3 / --a);
        //    }
        //    catch (DivideByZeroException e)
        //    {
        //        Console.WriteLine(e.StackTrace);
        //    }
        //}
    }
}

namespace Ex12_1
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for(int i = 0; i < 10; i++)
            {
                arr[i] = i;
            }

            try
            {
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}