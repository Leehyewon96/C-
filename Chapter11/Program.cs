using System;
using System.Collections;

namespace Chapter11
{
    class CopyingArray
    {
        static void CopyArray<T>(T[] source, T[] target)
        {
            for(int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        //static void Main(string[] args)
        //{
        //    int[] source = { 1, 2, 3, 4, 5 };
        //    int[] target = new int[source.Length];

        //    CopyArray<int>(source, target);

        //    foreach (int element in target)
        //    {
        //        Console.WriteLine(element);
        //    }

        //    string[] source2 = { "하나", "둘", "셋" };
        //    string[] target2 = new string[source2.Length];

        //    CopyArray<string>(source2, target2);
        //    foreach (string element in target2)
        //    {
        //        Console.WriteLine(element);
        //    }
        //}
    }
}

namespace Generic
{
    class MyList<T>
    {
        private T[] array;

        public MyList()
        {
            array = new T[3];
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize(ref array, index + 1);
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
        //    MyList<string> str_list = new MyList<string>();
        //    str_list[0] = "abc";
        //    str_list[1] = "def";
        //    str_list[2] = "ghi";
        //    str_list[3] = "jkl";
        //    str_list[4] = "mno";

        //    for(int i = 0; i < str_list.Length; i++)
        //    {
        //        Console.WriteLine(str_list[i]);
        //    }

        //    Console.WriteLine();

        //    MyList<int> int_list = new MyList<int>();
        //    int_list[0] = 0;
        //    int_list[1] = 1;
        //    int_list[2] = 2;
        //    int_list[3] = 3;
        //    int_list[4] = 4;

        //    for(int i = 0; i < int_list.Length; i++)
        //    {
        //        Console.WriteLine(int_list[i]);
        //    }
        //}
    }
}

namespace ConstraintsOnTypeParameters
{
    class StructArray<T> where T : struct
    {
        public T[] Array { get; set; }
        public StructArray(int size)
        {
            Array = new T[size];
        }
    }

    class RefArray<T> where T : class
    {
        public T[] Array { get; set; }
        public RefArray(int size)
        {
            Array= new T[size];
        }
    }

    class Base { }
    class Derived : Base { }
    class BaseArray<U> where U : Base
    {
        public U[] Array { get; set; }
        public BaseArray(int size)
        {
            Array = new U[size];
        }

        public void CopyArray<T>(T[] Source) where T : U
        {
            Source.CopyTo(Array, 0);
        }
    }

    class MainApp
    {
        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }

        //static void Main(string[] args)
        //{
        //    StructArray<int> a = new StructArray<int>(3);
        //    a.Array[0] = 1;
        //    a.Array[1] = 2;
        //    a.Array[2] = 3;

        //    RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
        //    b.Array[0] = new StructArray<double>(5);
        //    b.Array[1] = new StructArray<double>(10);
        //    b.Array[2] = new StructArray<double>(1005);

        //    BaseArray<Base> c = new BaseArray<Base>(3);
        //    c.Array[0] = new Base();
        //    c.Array[1] = new Derived();
        //    c.Array[2] = CreateInstance<Base>();

        //    BaseArray<Derived> d = new BaseArray<Derived>(3);
        //    d.Array[0] = new Derived();
        //    d.Array[1] = CreateInstance<Derived>();
        //    d.Array[2] = CreateInstance<Derived>();

        //    BaseArray<Derived> e = new BaseArray<Derived>(3);
        //    e.CopyArray<Derived>(d.Array);
        //}
    }
}

namespace EnumerableGeneric
{
    class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        private T[] array;
        int position = -1;

        public MyList()
        {
            array = new T[3];
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                if (index >= array.Length)
                {
                    Array.Resize(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }

                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        public T Current
        {
            get { return array[position]; }
        }

        object IEnumerator.Current
        { 
            get { return array[position]; }
        }

        public bool MoveNext()
        {
            if(position == array.Length - 1)
            {
                return false;
            }

            position++;
            return (position < array.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {

        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";

            foreach(string str in str_list)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();

            MyList<int> int_list = new MyList<int>();
            int_list[0] = 1;
            int_list[1] = 2;
            int_list[2] = 3;
            int_list[3] = 4;
            int_list[4] = 5;             

            foreach(int no in int_list)
            {
                Console.WriteLine(no);
            }
        }
    }
}