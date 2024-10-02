using System;
using static System.Console;
namespace Chapter2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("사용법 : Hello.exe <이름>");
                return;
            }



            
            WriteLine("Hello", args[0]);
        }
    }
}
