using System;
using System.Linq;

namespace From
{
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };
    //        var result = from n in numbers
    //                     where n % 2 == 0
    //                     orderby n
    //                     select n;

    //        foreach(var n in result)
    //        {
    //            Console.WriteLine($"짝수 : {n}");
    //        }
    //    }
    //}
}

namespace SimpleLinq
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Profile[] arrProfile =
        //    {
        //        new Profile() {Name = "정우성", Height = 186},
        //        new Profile() {Name = "김태희", Height = 158},
        //        new Profile() {Name = "고현정", Height = 172},
        //        new Profile() {Name = "이문세", Height = 178},
        //        new Profile() {Name = "하하", Height = 171},
        //    };

        //    var profiles = from profile in arrProfile
        //                   where profile.Height < 175
        //                   orderby profile.Height
        //                   select new 
        //                   {
        //                        Name = profile.Name,
        //                        InchHeight = profile.Height * 0.393
        //                   };

        //    foreach (var profile in profiles)
        //    {
        //        Console.WriteLine($"{profile.Name}, {profile.InchHeight}");
        //    }

        //}
    }
}

namespace FromFrom
{
    class Class
    {
        public string Name { get; set; }
        public int[] Score { get; set; }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Class[] arrClass =
        //    {
        //        new Class() { Name = "연두반", Score = new int[] { 99,80,70,24} },
        //        new Class() { Name = "분홍반", Score = new int[] { 60,45,87,72} },
        //        new Class() { Name = "파랑반", Score = new int[] { 92,30,85,94 } },
        //        new Class() { Name = "노랑반", Score = new int[] { 90,88,0,17 } },
        //    };

        //    var classes = from c in arrClass
        //                  from s in c.Score
        //                  where s < 60
        //                  orderby s
        //                  select new { c.Name, Lowest = s };

        //    foreach(var c in classes)
        //    {
        //        Console.WriteLine($"낙제 : {c.Name} {c.Lowest}");
        //    }
        //}
    }
}

namespace GroupBy
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Profile[] arrProfile =
        //    {
        //        new Profile() { Name = "정우성", Height = 186 },
        //        new Profile() { Name = "김태희", Height = 158 },
        //        new Profile() { Name = "고현정", Height = 172 },
        //        new Profile() { Name = "이문세", Height = 178 },
        //        new Profile() { Name = "하하", Height = 171 },
        //    };
            
        //    var listProfile = from profile in arrProfile
        //                      orderby profile.Height
        //                      group profile by profile.Height < 175 into g
        //                      select new { GroupKey = g.Key, Profiles = g };

        //    foreach(var Group in listProfile)
        //    {
        //        Console.WriteLine($"- 175cm 미만? : {Group.GroupKey}");

        //        foreach(var profile in Group.Profiles)
        //        {
        //            Console.WriteLine($">>> {profile.Name}, {profile.Height}");
        //        }
        //    }
        //}
    }
}

namespace Join
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class Product
    {
        public string Title { get; set; }
        public string Star { get; set; }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Profile[] arrProfile =
        //    {
        //        new Profile() { Name = "정우성", Height = 186 },
        //        new Profile() { Name = "김태희", Height = 158 },
        //        new Profile() { Name = "고현정", Height = 172 },
        //        new Profile() { Name = "이문세", Height = 178 },
        //        new Profile() { Name = "하하", Height = 171 },
        //    };

        //    Product[] arrProduct =
        //    {
        //        new Product() { Title = "비트", Star = "정우성" },
        //        new Product() { Title = "CF 다수", Star = "김태희" },
        //        new Product() { Title = "아이리스", Star = "김태희"},
        //        new Product() { Title = "모래시계", Star = "고현정" },
        //        new Product() { Title = "Solo 예찬", Star = "이문세" },
        //    };

        //    var listProfile =
        //    from profile in arrProfile
        //    join product in arrProduct on profile.Name equals product.Star
        //    select new
        //    {
        //        Name = profile.Name,
        //        Work = product.Title,
        //        Height = profile.Height,
        //    };

        //    Console.WriteLine("--- 내부 조인 결과 ---");
        //    foreach(var profile in listProfile)
        //    {
        //        Console.WriteLine("이름:{0}, 작품:{1}, 키:{2}cm", profile.Name, profile.Work, profile.Height);
        //    }

        //    listProfile =
        //        from profile in arrProfile
        //        join product in arrProduct on profile.Name equals product.Star into ps
        //        from product in ps.DefaultIfEmpty(new Product() { Title = "그런거 없음" })
        //        select new
        //        {
        //            Name = profile.Name,
        //            Work = product.Title,
        //            Height = profile.Height,
        //        };

        //    Console.WriteLine();
        //    Console.WriteLine("--- 외부 조인 결과 ---");
        //    foreach(var profile in listProfile)
        //    {
        //        Console.WriteLine("이름:{0}, 작품:{1}, 키:{2}cm", profile.Name, profile.Work, profile.Height);
        //    }
        //}
    }
}

namespace MinMaxAvg
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Profile[] arrProfile =
        //    {
        //        new Profile() { Name = "정우성", Height = 186 },
        //        new Profile() { Name = "김태희", Height = 158 },
        //        new Profile() { Name = "고현정", Height = 172 },
        //        new Profile() { Name = "이문세", Height = 178 },
        //        new Profile() { Name = "하하", Height = 171 },
        //    };

        //    var heightStat = from profile in arrProfile
        //                     group profile by profile.Height < 175 into g
        //                     select new
        //                     {
        //                         Group = g.Key == true ? "175미만" : "175이상",
        //                         Count = g.Count(),
        //                         Max = g.Max(profile => profile.Height),
        //                         Min = g.Min(profile => profile.Height),
        //                         Average = g.Average(profile => profile.Height),
        //                     };

        //    foreach(var stat in heightStat)
        //    {
        //        Console.Write("{0} - Count:{1}, Max:{2}, ",
        //            stat.Group, stat.Count, stat.Max);
        //        Console.WriteLine("Min:{0}, Average:{1}",
        //            stat.Min, stat.Average);
        //    }
        //}
    }
}

namespace Ex15_1
{
    class Car
    {
        public int Cost { get; set; }
        public int MaxSpeed { get; set; }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Car[] cars =
        //    {
        //          new Car(){Cost = 56, MaxSpeed = 120},
        //          new Car(){Cost = 70, MaxSpeed = 150},
        //          new Car(){Cost = 45, MaxSpeed = 180},
        //          new Car(){Cost = 32, MaxSpeed = 200},
        //          new Car(){Cost = 82, MaxSpeed = 280},
        //        };

        //    var selected = from car in cars
        //                   where car.Cost >= 50 && car.MaxSpeed >= 150
        //                   select car;

        //    foreach (var s in selected)
        //    {
        //        Console.WriteLine($"{s.Cost} {s.MaxSpeed}");
        //    }

        //}
    }
}

namespace Ex15_2
{
    class Car
    {
        public int Cost { get; set; }
        public int MaxSpeed { get; set; }
    }

    class MainApp
    {

        static void Main(string[] args)
        {
            Car[] cars =
            {
                  new Car(){Cost = 56, MaxSpeed = 120},
                  new Car(){Cost = 70, MaxSpeed = 150},
                  new Car(){Cost = 45, MaxSpeed = 180},
                  new Car(){Cost = 32, MaxSpeed = 200},
                  new Car(){Cost = 82, MaxSpeed = 280},
            };

            var selected = from car in cars
                           where car.Cost < 60
                           orderby car.Cost
                           select car;

            foreach(var car in selected)
            {
                Console.WriteLine($"{car.Cost} {car.MaxSpeed}");
            }
        }
    }
}