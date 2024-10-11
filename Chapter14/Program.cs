using System.Linq.Expressions;

namespace SimpleLamda
{
    class MainApp
    {
        delegate int Calculate(int a, int b);

        //static void Main(string[] args)
        //{
        //    Calculate Calc = (a, b) => a + b;

        //    Console.WriteLine($"{3} + {4} : {Calc(3, 4)}");
        //}
    }
}

namespace StatementLamda
{
    class MainApp
    {
        delegate string Concatenate(string[] args);

        //static void Main(string[] args)
        //{
        //    Concatenate concat =
        //        (arr) =>
        //        {
        //            string result = "";
        //            foreach (string s in arr)
        //            {
        //                result += s;
        //            }
        //            return result;
        //        };

        //    Console.WriteLine(concat(args));
        //}
    }
}

namespace FuncTest
{
    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Func<int> func1 = () => 10;
        //    Console.WriteLine(func1());

        //    Func<int, int> func2 = (x) => x * 2;
        //    Console.WriteLine($"func2(4) : {func2(4)}");

        //    Func<double, double, double> func3 = (x, y) => x / y;
        //    Console.WriteLine($"func3(22,7) : {func3(22, 7)}");
        //}
    }
}

namespace ActionTest
{
    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Action act1 = () => Console.WriteLine("Action()");
        //    act1();

        //    int result = 0;
        //    Action<int> act2 = (x) => result = x * x;
        //    act2(3);
        //    Console.WriteLine($"result : {result}");

        //    Action<double, double> act3 = (x, y) =>
        //    {
        //        double pi = x / y;
        //        Console.WriteLine($"Action<T1, T2>({x}, {y} : {pi})");
        //    };

        //    act3(22.0, 7.0);
        //}
    }
}

namespace UsingExpressionTree
{
    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    //1*2 + x - y
        //    Expression const1 = Expression.Constant(1);
        //    Expression const2 = Expression.Constant(2);

        //    Expression leftExp = Expression.Multiply(const1, const2);
        //    Expression param1 = Expression.Parameter(typeof(int));
        //    Expression param2 = Expression.Parameter(typeof(int));

        //    Expression rightExp = Expression.Subtract(param1, param2);

        //    Expression exp = Expression.Add(leftExp, rightExp);

        //    Expression<Func<int, int, int>> expression =
        //        Expression<Func<int, int, int>>.Lambda<Func<int, int, int>>(
        //            exp, new ParameterExpression[]
        //            {
        //                (ParameterExpression)param1,
        //                (ParameterExpression)param2,
        //            });

        //    Func<int, int, int> func = expression.Compile();

        //    // x = 7, y = 8
        //    Console.WriteLine($"1*2+({7} - {8}) = {func(7, 8)}");
        //}
    }
}

namespace ExpressionTreeViaLamda
{
    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Expression<Func<int, int, int>> expression =
        //        (a, b) => 1 * 2 + (a - b);
        //    Func<int, int, int> func = expression.Compile();

        //    //x = 7, y = 8
        //    Console.WriteLine($"1*2 + {7}- {8} = {func(7, 8)}");
        //}
    }
}

namespace ExpressionBodiedMember
{ 
    class FriendList
    {
        private List<string> list = new List<string>();

        public void Add(string name) => list.Add(name);
        public void Remove(string name) => list.Remove(name);
        public void PrintAll()
        {
            foreach(var s in list)
            {
                Console.WriteLine(s);
            }
        }

        public FriendList() => Console.WriteLine("FriendList()");
        ~FriendList() => Console.WriteLine("~FriendList()");

        // public int capacity => list.Capacity; // 읽기 전용 프로퍼티 (get 생략)

        public int Capacity
        {
            get => list.Capacity;
            set => list.Capacity = value;
        }

        // public string this[int index] => list[index]; //읽기 전용 인덱서 (get 생략)

        public string this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    FriendList obj = new FriendList();
        //    obj.Add("Eeny");
        //    obj.Add("Meeny");
        //    obj.Add("Miny");
        //    obj.Remove("Eeny");
        //    obj.PrintAll();

        //    Console.WriteLine($"{obj.Capacity}");
        //    obj.Capacity = 10;
        //    Console.WriteLine($"{obj.Capacity}");

        //    Console.WriteLine($"{obj[0]}");
        //    obj[0] = "Moe";
        //    obj.PrintAll();
        //}
    }
}

namespace Ex14_2
{ 
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 22, 33, 44, 55 };

            foreach(int a in array)
            {
                Action action = () => Console.WriteLine(a * a);
                action.Invoke();
            }
        }
    }
}