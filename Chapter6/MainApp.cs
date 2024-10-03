
using System;

namespace Chapter4
{
    class Program
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }


        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine($"x : {x} y : {y}");

            Swap(ref x, ref y);

            Console.WriteLine($"x : {x} y : {y}");
        }
    }
}

namespace RefReturn
{
    class Product
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Price : {price}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Product carrot = new Product();
            ref int ref_local_price = ref carrot.GetPrice();
            int normal_local_price = carrot.GetPrice();

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price : {ref_local_price}");
            Console.WriteLine($"Normal Local Price : {normal_local_price}");

            ref_local_price = 200;

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price : {ref_local_price}");
            Console.WriteLine($"Normal Local Price : {normal_local_price}");
        }
    }
}

namespace UsingOut
{
    class MainApp
    {
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        static void Main(string[] args)
        {
            int a = 20;
            int b = 20;
            //int c;
            //int d;
            Divide(a, b, out int c, out int d);

            Console.WriteLine($"a:{a}, b:{b}, a/b:{c}, a%b:{d}");
        }
    }
}

namespace UsingParams
{
    class MainApp
    {
        static int Sum(params int[] args)
        {
            Console.WriteLine("Summing...");

            int sum = 0;
            for (int i = 0; i < args.Length; ++i)
            {
                if(i > 0)
                {
                    Console.Write(", ");
                    
                }
                Console.Write(args[i]);
                sum += args[i];
            }

            Console.WriteLine();
            return sum;
        }

        //static void Main(string[] args)
        //{
        //    int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);

        //    Console.WriteLine($"Sum : {sum}");
        //}
    }
}

namespace NamedParameter
{
    class MainApp
    {
        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine($"name : {name} phone : {phone}");
        }

        //static void Main(string[] args)
        //{
        //    PrintProfile(name: "박찬호", phone: "010-123-1234");
        //    PrintProfile(phone: "010-987-9876", name: "박지성");
        //}
    }
}

namespace LocalFunction
{
    class MainApp
    {
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();
            for(int i = 0; i < arr.Length; ++i)
            {
                arr[i] = ToLowerChar(i);
            }

            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90)
                {
                    return arr[i];
                }
                else
                {
                    return (char)(arr[i] + 32);
                }
            }

            return new string(arr);
        }

        /*static void Main(string[] args)
        {
            Console.WriteLine(ToLowerString("Hello!"));
            Console.WriteLine(ToLowerString("Good Morning."));
            Console.WriteLine(ToLowerString("This is C#."));
        }*/
    }
}

namespace Ex6_1
{
    class MainApp
    {
        static double Square(double arg)
        {
            return arg * arg;
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("수를 입력하세요: ");
        //    string input = Console.ReadLine();

        //    double arg = Convert.ToDouble(input);

        //    Console.WriteLine("결과 : {0}", Square(arg));
        //}
    }
}

namespace Ex6_2
{
    class MainApp
    {
        //public static void Main()
        //{
        //    double mean = 0;
        //    Mean(1, 2, 3, 4, 5, ref mean);

        //    Console.WriteLine("평균 : {0}", mean);
        //}

        public static void Mean(double a, double b, double c, double d, double e, ref double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }
        
    }
}

namespace Ex6_3
{
    class MainApp
    {
        public static void Main()
        {
            int a = 3;
            int b = 4;
            int resultA = 0;

            Plus(a, b, out resultA);

            Console.WriteLine("{0} + {1} = {2}", a, b, resultA);

            double x = 2.4;
            double y = 3.1;
            double resultB = 0;

            Plus(x, y, out resultB);

            Console.WriteLine("{0} + {1} = {2}", x, y, resultB);
        }

        public static void Plus(int a, int b, out int c)
        {
            c = a + b;
        }

        public static void Plus(double a, double b, out double c)
        {
            c = a + b;
        }
    }
}
