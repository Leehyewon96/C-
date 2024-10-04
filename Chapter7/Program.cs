using MyExtension;

namespace BasicClass
{
    class Cat
    {
        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Cat kitty = new Cat();
        //    kitty.Color = "하얀색";
        //    kitty.Name = "키티";
        //    kitty.Meow();
        //    Console.WriteLine($"{kitty.Name} : {kitty.Color}");

        //    Cat nero = new Cat();
        //    nero.Color = "검은색";
        //    nero.Name = "네로";
        //    nero.Meow();
        //    Console.WriteLine($"{nero.Name} : {nero.Color}");
        //}
    }
}

namespace Constructor
{
    class Cat
    {
        public Cat()
        {
            Name = "";
            Color = "";
        }

        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }

        ~Cat()
        {
            Console.WriteLine($"{Name} : 잘가");
        }

        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Cat kitty = new Cat("키티", "하얀색");
        //    kitty.Meow();
        //    Console.WriteLine($"{kitty.Name} : {kitty.Color}");

        //    Cat nero = new Cat("네로", "검은색");
        //    nero.Meow();
        //    Console.WriteLine($"{nero.Name} : {nero.Color}");
        //}
    }
}

namespace StaticStudy
{
    class Global
    {
        public static int Count = 0;
    }

    class ClassA
    {
        public ClassA()
        {
            Global.Count++;
        }
    }

    class ClassB
    {
        public ClassB()
        {
            Global.Count++;
        }
    }

    class MainApp
    {
        //static void Main()
        //{
        //    Console.WriteLine($"Global.Count : {Global.Count}");

        //    new ClassA();
        //    new ClassA();
        //    new ClassB();
        //    new ClassB();

        //    Console.WriteLine($"Global.Count : {Global.Count}");
        //}
    }
}

namespace DeepCopy
{
    class MyClass
    {
        public int MyField1;
        public int MyField2;

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = MyField1;
            newCopy.MyField2 = MyField2;
            
            return newCopy;
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Shallow Copy");

        //    {
        //        MyClass source = new MyClass();
        //        source.MyField1 = 10;
        //        source.MyField2 = 20;

        //        MyClass target = source;
        //        target.MyField2 = 30;

        //        Console.WriteLine($"{source.MyField1} {source.MyField2}");
        //        Console.WriteLine($"{target.MyField1} {target.MyField2}");
        //    }

        //    Console.WriteLine("Deep Copy");
        //    {
        //        MyClass source = new MyClass();
        //        source.MyField1 = 10;
        //        source.MyField2 = 20;

        //        MyClass target = source.DeepCopy();
        //        target.MyField2 = 30;

        //        Console.WriteLine($"{source.MyField1} {source.MyField2}");
        //        Console.WriteLine($"{target.MyField1} {target.MyField2}");
        //    }
        //}
    }
}

namespace ThisConstructor
{
    class MyClass
    {
        int a, b, c;

        public MyClass()
        {
            this.a = 5425;
            Console.WriteLine("MyClass()");
        }

        public MyClass(int b) : this()
        {
            this.b = b;
            Console.WriteLine($"MyClass({b})");
        }

        public MyClass(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine($"MyClass({b}, {c})");
        }

        public void PrintFields()
        {
            Console.WriteLine($"a:{a}, b:{b}, c:{c}");
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    MyClass a = new MyClass();
        //    a.PrintFields();
        //    Console.WriteLine();

        //    MyClass b = new MyClass(1);
        //    b.PrintFields();
        //    Console.WriteLine();

        //    MyClass c = new MyClass(10, 20);
        //    c.PrintFields();
        //    Console.WriteLine();
        //}
    }
}

namespace AccessModifier
{
    class WaterHeater
    {
        protected int temperature;

        public void SetTemperature(int temperature)
        {
            if(temperature < -5 || temperature > 42)
            {
                throw new Exception("Out of temperature range");
            }

            this.temperature = temperature;
        }

        internal void TurnOnWater()
        {
            Console.WriteLine($"Turn on water : {temperature}");
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        WaterHeater heater = new WaterHeater();
        //        heater.SetTemperature(20);
        //        heater.TurnOnWater();

        //        heater.SetTemperature(-2);
        //        heater.TurnOnWater();

        //        heater.SetTemperature(50);
        //        heater.TurnOnWater();
        //    }
        //    catch(Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}
    }
}

namespace Inheritance
{
    class Base
    {
        protected string Name;
        public Base(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Base()");
        }

        ~Base()
        {
            Console.WriteLine($"{this.Name}.~Base()");
        }

        public void BaseMethod()
        {
            Console.WriteLine($"{Name}.BaseMethod()");
        }
    }

    class Derived : Base
    {
        public Derived(string Nane) : base(Nane)
        {
            Console.WriteLine($"{this.Name}.Derived()");
        }

        ~Derived()
        {
            Console.WriteLine($"{this.Name}.~Derived()");
        }

        public void DrivedMethod()
        {
            Console.WriteLine($"{Name}.DerivedMethod()");
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{

        //    Base a = new Base("a");
        //    a.BaseMethod();

        //    Derived b = new Derived("b");
        //    b.BaseMethod();
        //    b.DrivedMethod();
        //}
    }
}

namespace TypeCasting
{
    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }

    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }

    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow()");
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Mammal mammal = new Dog();
        //    Dog dog;

        //    if(mammal is Dog)
        //    {
        //        dog = (Dog)mammal;
        //        dog.Bark();
        //    }

        //    Mammal mammal2 = new Cat();
        //    Cat cat = mammal2 as Cat;
        //    if(cat != null)
        //    {
        //        cat.Meow();
        //    }

        //    Cat cat2 = mammal as Cat;
        //    if(cat2 != null)
        //    {
        //        cat2.Meow();
        //    }
        //    else
        //    {
        //        Console.WriteLine("cat2 is not a Cat");
        //    }
        //}
    }
}

namespace Overriding
{
    class ArmorSuite
    {
        public virtual void Initialize()
        {
            Console.WriteLine("Armored");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Repulsor Rays Armed");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Double-Barrel Cannons Armed");
            Console.WriteLine("Micro-Rocket Launcher Armed");
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine($"Creating ArmorSuite...");
        //    ArmorSuite armorSuite = new ArmorSuite();
        //    armorSuite.Initialize();

        //    Console.WriteLine($"Creating IronMan...");
        //    IronMan ironMan = new IronMan();
        //    ironMan.Initialize();

        //    Console.WriteLine($"Creating WarMachine...");
        //    WarMachine warMachine = new WarMachine();
        //    warMachine.Initialize();
        //}
    }
}

namespace SealedStudy
{
    class Base
    {
        public virtual void SealMe()
        {

        }
    }

    class Derived : Base
    {
        public sealed override void SealMe()
        {
            
        }
    }

    class WantToOverride : Derived
    {
        //public override void SealMe()
        //{

        //}
    }

    class MainApp
    { 
        //static void Main(string[] args)
        //{

        //}
    }
}

namespace NestedClass
{
    class Configuration
    {
        List<ItemValue> listConfig = new List<ItemValue>();

        public void SetConfig(string item, string value)
        {
            ItemValue iv = new ItemValue();
            iv.SetValue(this, item, value);
        }

        public string GetConfig(string item)
        {
            foreach(ItemValue iv in listConfig)
            {
                if(iv.GetItem() == item)
                {
                    return iv.GetValue();
                }
            }

            return "";
        }

        private class ItemValue
        {
            private string item;
            private string value;

            public void SetValue(Configuration config, string item, string value)
            {
                this.item = item;
                this.value = value;

                bool found = false;
                for(int i = 0; i < config.listConfig.Count; i++)
                {
                    if (config.listConfig[i].item == item)
                    {
                        config.listConfig[i] = this;
                        found = true;
                        break;
                    }
                }

                if(found == false)
                {
                    config.listConfig.Add(this);
                }
            }

            public string GetItem()
            {
                return this.item;
            }

            public string GetValue()
            {
                return this.value;
            }
        }
    }

    class MainApp
    {
        //static void Main(string[] args) 
        //{
        //    Configuration config = new Configuration();
        //    config.SetConfig("Version", "V 5.0");
        //    config.SetConfig("Size", "655,324 KB");

        //    Console.WriteLine(config.GetConfig("Version"));
        //    Console.WriteLine(config.GetConfig("Size"));

        //    config.SetConfig("Version", "V 5.0.1");
        //    Console.WriteLine(config.GetConfig("Version"));
        //}
    }
}

namespace MyExtension
{
    public static class IntegerExtension
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }

        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for(int i = 1; i < exponent; i++)
            {
                result *= myInt;
            }

            return result;
        }
    }
}

namespace ExtesionMethod
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3^2 : {3.Square()}");
            Console.WriteLine($"3^4 : {3.Power(4)}");
            Console.WriteLine($"2^10 : {2.Power(10)}");
        }
    }
}