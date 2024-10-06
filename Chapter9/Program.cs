using Record;
using System.Security.Cryptography;

namespace Property
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    BirthdayInfo birth = new BirthdayInfo();
        //    birth.Name = "서현";
        //    birth.Birthday = new DateTime(1991, 6, 28);

        //    Console.WriteLine($"Name : {birth.Name}");
        //    Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
        //    Console.WriteLine($"Age : {birth.Age}");
        //}
    }
}

namespace AutoImplementedProperty
{
    class BirthdayInfo
    {
        public string Name { get; set; } = "Unknown";
        public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    
    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    BirthdayInfo birth = new BirthdayInfo();
        //    Console.WriteLine($"Name : {birth.Name}");
        //    Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
        //    Console.WriteLine($"Age : {birth.Age}");

        //    birth.Name = "서현";
        //    birth.Birthday = new DateTime(1991, 6, 28);

        //    Console.WriteLine($"Name : {birth.Name}");
        //    Console.WriteLine($"Birthday : {birth.Birthday}");
        //    Console.WriteLine($"Age : {birth.Age}");
        //}
    }
}

namespace ConstructorWithProperty
{
    class BirthdayInfo
    {
        public string Name
        {
            get;
            set;
        }

        public DateTime Birthday
        {
            get;
            set;
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        BirthdayInfo birth = new BirthdayInfo()
    //        {
    //            Name = "서현",
    //            Birthday = new DateTime(1991, 6, 28)
    //        };

    //        Console.WriteLine($"Name : {birth.Name}");
    //        Console.WriteLine($"Birthday : {birth.Birthday}");
    //        Console.WriteLine($"Age : {birth.Age}");
    //    }
    //}
}

namespace InitOnly
{
    class Transaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : {Amount}";
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Transaction tr1 = new Transaction
        //    {
        //        From = "Alice",
        //        To = "Bob",
        //        Amount = 100
        //    };
        //    Transaction tr2 = new Transaction
        //    {
        //        From = "Bob",
        //        To = "Charlie",
        //        Amount = 50
        //    };
        //    Transaction tr3 = new Transaction
        //    {
        //        From = "Charlie",
        //        To = "Alice",
        //        Amount = 50
        //    };

        //    Console.WriteLine(tr1);
        //    Console.WriteLine(tr2);
        //    Console.WriteLine(tr3);
        //}
    }
}

namespace RequiredProperty
{
    class BirthdayInfo
    {
        public required string Name { get; set; }
        public required DateTime Birthday { get; init; }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    BirthdayInfo birth = new BirthdayInfo()
        //    {
        //        Name = "서현",
        //        Birthday = new DateTime(1991, 6, 28)
        //    };

        //    Console.WriteLine($"Name : {birth.Name}");
        //    Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
        //    Console.WriteLine($"Age : {birth.Age}");
        //}
    }
}

namespace Record
{
    record RTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    RTransaction tr1 = new RTransaction
        //    {
        //        From = "Alice",
        //        To = "Bob",
        //        Amount = 100
        //    };

        //    RTransaction tr2 = new RTransaction
        //    {
        //        From = "Alice",
        //        To = "Charlie",
        //        Amount = 100
        //    };

        //    Console.WriteLine(tr1);
        //    Console.WriteLine(tr2);
        //}
    }
}

namespace WithExp
{
    record WithExp
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From} ->  {To} : ${Amount}";
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    RTransaction tr1 = new RTransaction
        //    {
        //        From = "Alice",
        //        To = "Bob",
        //        Amount = 100
        //    };
        //    RTransaction tr2 = tr1 with { To = "Charlie" };
        //    RTransaction tr3 = tr2 with { From = "Dave", Amount = 30 };

        //    Console.WriteLine(tr1);
        //    Console.WriteLine(tr2);
        //    Console.WriteLine(tr3);
        //}
    }
}

namespace RecordComp
{
    class CTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From} ->  {To} : ${Amount}";
        }
    }

    record RTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From} ->  {To} : ${Amount}";
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    CTransaction trA = new CTransaction
        //    {
        //        From = "Alice",
        //        To = "Bob",
        //        Amount = 100
        //    };

        //    CTransaction trB = new CTransaction
        //    {
        //        From = "Alice",
        //        To = "Bob",
        //        Amount = 100
        //    };

        //    Console.WriteLine(trA);
        //    Console.WriteLine(trB);
        //    Console.WriteLine($"trA equals to trB : {trA.Equals(trB)}");

        //    RTransaction tr1 = new RTransaction
        //    {
        //        From = "Alice",
        //        To = "Bob",
        //        Amount = 100
        //    };
        //    RTransaction tr2 = new RTransaction
        //    {
        //        From = "Alice",
        //        To = "Bob",
        //        Amount = 100
        //    };

        //    Console.WriteLine(tr1);
        //    Console.WriteLine(tr2);
        //    Console.WriteLine($"trA equals to trB : {tr1.Equals(tr2)}");
        //}
    }
}

namespace AnonymousType
{
    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    var a = new { Name = "박상현", Age = 123 };
        //    Console.WriteLine($"Name:{a.Name}, Age:{a.Age}");

        //    var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };

        //    Console.Write($"Subject: {b.Subject}, Scores: ");
        //    foreach(var score in b.Scores)
        //    {
        //        Console.Write($"{score} ");
        //    }

        //    Console.WriteLine();
        //}
    }
}

namespace PropertiesInterface
{
    interface INamedValue
    {
        string Name
        {
            get;
            set;
        }

        string Value
        {
            get;
            set;
        }
    }

    class NamedValue : INamedValue
    {
        public string Name
        {
            get;
            set;
        }

        public string Value
        {
            get;
            set;
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    NamedValue name = new NamedValue
        //    {
        //        Name = "이름",
        //        Value = "박상현"
        //    };

        //    NamedValue height = new NamedValue
        //    {
        //        Name = "키",
        //        Value = "177cm"
        //    };

        //    NamedValue weight = new NamedValue
        //    {
        //        Name = "몸무게",
        //        Value = "90kg"
        //    };

        //    Console.WriteLine($"{name.Name} : {name.Value}");
        //    Console.WriteLine($"{height.Name} : {height.Value}");
        //    Console.WriteLine($"{weight.Name} : {weight.Value}");
        //}
    }
}

namespace PropertiesInAbstractClass
{
    abstract class Product
    {
        private static int serial = 0;
        public string SerialID
        {
            get { return String.Format("{0:d5}", serial++); }
        }

        abstract public DateTime ProductDate
        {
            get;
            set;
        }
    }

    class MyProduct : Product
    {
        public override DateTime ProductDate
        {
            get;
            set;
        }
    }

    class MainApp
    { 
        //static void Main(string[] args)
        //{
        //    Product product_1 = new MyProduct()
        //    {
        //        ProductDate = new DateTime(2023, 1, 10)
        //    };

        //    Console.WriteLine("Product:{0}, Product Date :{1}", product_1.SerialID, product_1.ProductDate);

        //    Product product_2 = new MyProduct()
        //    {
        //        ProductDate = new DateTime(2023, 2, 3)
        //    };

        //    Console.WriteLine("Product:{0}, Product Date :{1}", product_2.SerialID, product_2.ProductDate);
        //}
    }
}

namespace Ex
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var nameCard = new { Name = "박상현", Age = 17 };
            Console.WriteLine("이름 : {0} 나이 : {1}", nameCard.Name, nameCard.Age);

            var complex = new { Real = 3, Imaginary = -12 };
            Console.WriteLine("Real : {0} Imaginary : {1}", complex.Real, complex.Imaginary);
        }
    }
}