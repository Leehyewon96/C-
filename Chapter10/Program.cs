using System.Collections;

namespace Slice
{
    class MainApp
    {
        static void PrintArray(System.Array array)
        {
            foreach (var e in array)
            {
                Console.Write(e);
            }
            Console.WriteLine();
        }

        //static void Main(string[] args)
        //{
        //    char[] array = new char['Z' - 'A' + 1];
        //    for(int i = 0; i < array.Length; i++)
        //    {
        //        array[i] = (char)('A' + i);
        //    }

        //    PrintArray(array[..]);
        //    PrintArray(array[5..]);

        //    Range range_5_10 = 5..10;
        //    PrintArray(array[range_5_10]);

        //    Index last = ^0;
        //    Range range_5_last = 5..last;
        //    PrintArray(array[range_5_last]);

        //    PrintArray(array[^4..^1]);
        //}
    }
}

namespace _2DArray
{
    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4,5,6} };

        //    for(int i = 0; i < arr.GetLength(0); i++)
        //    {
        //        for(int j = 0; j < arr.GetLength(1); j++)
        //        {
        //            Console.Write($"[{i}, {j}] : {arr[i, j]}");
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine();

            
        //    int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            
        //    for(int i = 0; i < arr2.GetLength(0); i++)
        //    {
        //        for(int j = 0; j < arr2.GetLength(1); j++)
        //        {
        //            Console.Write($"[{i}, {j}] : {arr2[i, j]}");
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine();


        //    int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 } };
        //    for (int i = 0; i < arr3.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < arr3.GetLength(1); j++)
        //        {
        //            Console.Write($"[{i}, {j}] : {arr3[i, j]}");
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine();
        //}
    }
}

namespace JaggedArray
{
    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    int[][] jagged = new int[3][];
        //    jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
        //    jagged[1] = new int[] { 1, 2, 3 };
        //    jagged[2] = new int[] { 100, 200 };

        //    foreach (int[] arr in jagged)
        //    {
        //        Console.Write($"Length : {arr.Length}, ");
        //        foreach(int e in arr)
        //        {
        //            Console.Write($"{e} ");
        //        }
        //        Console.WriteLine("");
        //    }
        //    Console.WriteLine("");

        //    int[][] jagged2 = new int[2][]
        //    {
        //        new int[] { 1000, 2000},
        //        new int[] {6,7,8,9 }
        //    };

        //    foreach (int[] arr in jagged2)
        //    {
        //        foreach(int e in arr)
        //        {
        //            Console.Write($"{e} ");
        //        }
        //        Console.WriteLine("");
        //    }
        //    Console.WriteLine("");
        //}
    }
}

namespace UsingList
{
    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    ArrayList list = new ArrayList();
        //    for(int i = 0; i < 5; i++)
        //    {
        //        list.Add(i);
        //    }

        //    foreach(object obj in list)
        //    {
        //        Console.Write($"{obj} ");
        //    }
        //    Console.WriteLine();

        //    list.RemoveAt(2);

        //    foreach(object obj in list)
        //    {
        //        Console.Write($"{obj} ");
        //    }
        //    Console.WriteLine();

        //    list.Insert(2, 2);

        //    foreach(object obj in list)
        //    {
        //        Console.Write($"{obj} ");
        //    }
        //    Console.WriteLine();

        //    list.Add("abc");
        //    list.Add("def");

        //    for(int i = 0; i <list.Count; i++)
        //    {
        //        Console.Write($"{list[i]} ");
        //    }
        //    Console.WriteLine();
        //}
    }
}

namespace UsingQueue
{
    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Queue que = new Queue();
        //    que.Enqueue(1);
        //    que.Enqueue(2);
        //    que.Enqueue(3);
        //    que.Enqueue(4);
        //    que.Enqueue(5);

        //    while(que.Count > 0)
        //    {
        //        Console.WriteLine(que.Dequeue());
        //    }
        //}
    }
}

namespace UsingStack
{
    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Stack stack = new Stack();
        //    stack.Push(1);
        //    stack.Push(2);
        //    stack.Push(3);
        //    stack.Push(4);
        //    stack.Push(5);

        //    while(stack.Count > 0)
        //    {
        //        Console.WriteLine(stack.Pop());
        //    }
        //}
    }
}

namespace UsingHashtable
{
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Hashtable ht = new Hashtable();
    //        ht["하나"] = "one";
    //        ht["둘"] = "two";
    //        ht["셋"] = "three";
    //        ht["넷"] = "four";
    //        ht["다섯"] = "five";

    //        Console.WriteLine(ht["하나"]);
    //        Console.WriteLine(ht["둘"]);
    //        Console.WriteLine(ht["셋"]);
    //        Console.WriteLine(ht["넷"]);
    //        Console.WriteLine(ht["다섯"]);
    //    }
    //}
}

namespace InitializingCollections
{
    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    int[] arr = { 123, 456, 789 };

        //    ArrayList list= new ArrayList(arr);
        //    foreach(object item in list)
        //    {
        //        Console.WriteLine($"ArrayList : {item}");
        //    }
        //    Console.WriteLine();


        //    Stack stack = new Stack(arr);
        //    foreach (object item in stack)
        //    {
        //        Console.WriteLine($"ArrayList : {item}");
        //    }
        //    Console.WriteLine();


        //    Queue queue = new Queue(arr);
        //    foreach (object item in queue)
        //    {
        //        Console.WriteLine($"ArrayList : {item}");
        //    }
        //    Console.WriteLine();


        //    ArrayList list2 = new ArrayList() { 11, 22, 33};
        //    foreach (object item in list2)
        //    {
        //        Console.WriteLine($"ArrayList : {item}");
        //    }
        //    Console.WriteLine();
        //}
    }
}

namespace Indexer
{
    class MyList
    {
        private int[] array;

        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if(index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }

                array[index] = value;
            }
        }

        public int Length
        {
            get
            {
                return array.Length;
            }
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    MyList list = new MyList();
        //    for(int i = 0; i < 5; i++)
        //    {
        //        list[i] = i;
        //    }

        //    for(int i = 0; i < list.Length; i++)
        //    {
        //        Console.WriteLine(list[i]);
        //    }
        //}
    }
}

namespace Yield
{
    class MyEnumerator
    {
        int[] numbers = { 1, 2, 3, 4 };

        public IEnumerator GetEnumerator()
        {
            yield return numbers[0];
            yield return numbers[1];
            yield return numbers[2];
            yield break;
            yield return numbers[3];
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    var obj = new MyEnumerator();
        //    foreach(int i in obj)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
    }
}

namespace Enumerable
{
    class MyList : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1;

        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if(index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }

                array[index] = value;
            }
        }

        //IEnumerator 멤버
        public object Current
        {
            get
            {
                return array[position];
            }
        }

        //IEnumerator 멤버
        public bool MoveNext()
        {
            if(position == array.Length - 1)
            {
                Reset();
                return false;
            }

            position++;
            return true;
        }

        //IEnumerator 멤버
        public void Reset()
        {
            position = -1;
        }

        //IEnumerable 멤버
        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        MyList list = new MyList();
    //        for(int i = 0; i < 5; i++)
    //        {
    //            list[i] = i;
    //        }

    //        foreach(int e in list)
    //        {
    //            Console.WriteLine(e);
    //        }
    //    }
    //}
}

namespace Ex2
{
    class Ex2
    {
        static int[,] mA = new int[2, 2] { { 3, 2 }, { 1, 4 } };
        static int[,] mB = new int[2, 2] { { 9, 2 }, { 1, 7 } };

        public static void MultiplyMatrix()
        {
            int[,] answer = new int[2, 2];
            answer[0, 0] = mA[0, 0] * mB[0, 0] + mA[0, 1] * mB[1, 0];
            answer[0, 1] = mA[0, 0] * mB[0, 1] + mA[0, 1] * mB[1, 1];
            answer[1, 0] = mA[1, 0] * mB[0, 0] + mA[1, 1] * mB[1, 0];
            answer[1, 1] = mA[1, 0] * mB[0, 1] + mA[1, 1] * mB[1, 1];

            for(int i  = 0; i < answer.GetLength(0); i++)
            {
                for(int j = 0; j < answer.GetLength(1); j++)
                {
                    Console.Write($"{answer[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        //static void Main(string[] args)
        //{
        //    MultiplyMatrix();
        //}
    }
}

namespace Ex5
{
    class Ex5
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["회사"] = "Microsoft";
            ht["URL"] = "www.microsoft.com";

            Console.WriteLine("회사 : {0}", ht["회사"]);
            Console.WriteLine("URL : {0}", ht["URL"]);
        }
    }
}