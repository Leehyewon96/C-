using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace GetType
{
    class MainApp
    {
        static void PrintInterfaces(Type type)
        {
            Console.WriteLine("------- Interfaces -------");

            Type[] interfaces = type.GetInterfaces();
            foreach (Type i in interfaces)
            {
                Console.WriteLine("Name : {0}", i.Name);
            }
            Console.WriteLine();
        }

        static void PrintFields(Type type)
        {
            Console.WriteLine("------- Fields -------");

            FieldInfo[] fields = type.GetFields(
                BindingFlags.NonPublic |
                BindingFlags.Public |
                BindingFlags.Static |
                BindingFlags.Instance);

            foreach(FieldInfo field in fields)
            {
                String accessLevel = "protected";
                if(field.IsPublic)
                {
                    accessLevel = "public";
                }
                else if(field.IsPrivate)
                {
                    accessLevel = "private";
                }

                Console.WriteLine("Access:{0}, Type:{1}, Name:{2}", accessLevel, field.FieldType.Name, field.Name);
            }

            Console.WriteLine();
        }

        static void PrintMethods(Type type)
        {
            Console.WriteLine("------- Methods -------");

            MethodInfo[] methods = type.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.Write("Type:{0}, Name:{1}, Parameter:", method.ReturnType.Name, method.Name);

                ParameterInfo[] args = method.GetParameters();
                for(int i =0; i < args.Length; i++)
                {
                    Console.WriteLine("{0}", args[i].ParameterType.Name);
                    if(i < args.Length - 1)
                    {
                        Console.WriteLine(", ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintProperties(Type type)
        {
            Console.WriteLine("------- Properties -------");
            PropertyInfo[] properties = type.GetProperties();

            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine("Type:{0}, Name:{1}", property.PropertyType.Name, property.Name);
            }

            Console.WriteLine();
        }

        //static void Main(string[] args)
        //{
        //    int a = 0;
        //    Type type = a.GetType();

        //    PrintInterfaces(type);
        //    PrintFields(type);
        //    PrintProperties(type);
        //    PrintMethods(type);
        //}
    }
}

namespace DynamicInstance
{
    class Profile
    {
        private string name;
        private string phone;
        public Profile()
        {
            name = "";
            phone = "";
        }

        public Profile(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public void Print()
        {
            Console.WriteLine($"{name}, {phone}");
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Type type = Type.GetType("DynamicInstance.Profile");
        //    MethodInfo methodInfo = type.GetMethod("Print");

        //    PropertyInfo nameProperty = type.GetProperty("Name");
        //    PropertyInfo phoneProperty = type.GetProperty("Phone");

        //    object profile = Activator.CreateInstance(type, "박상현", "512-1234");
        //    methodInfo.Invoke(profile, null);

        //    profile = Activator.CreateInstance(type);
        //    nameProperty.SetValue(profile, "박찬호", null);
        //    phoneProperty.SetValue(profile, "997-5511", null);

        //    Console.WriteLine("{0} {1}",
        //        nameProperty.GetValue(profile, null),
        //        phoneProperty.GetValue(profile, null));
        //}
    }
}

namespace EmitTest
{ 
    public class MainApp
    {
        //public static void Main()
        //{
        //    AssemblyBuilder newAssembly = AssemblyBuilder.DefineDynamicAssembly(
        //        new AssemblyName("CalculatorAssembly"),
        //        AssemblyBuilderAccess.Run);

        //    ModuleBuilder newModule = newAssembly.DefineDynamicModule("Calculator");

        //    TypeBuilder newType = newModule.DefineType("Sum1To100");

        //    MethodBuilder newMethod = newType.DefineMethod(
        //        "Calculate",
        //        MethodAttributes.Public,
        //        typeof(int),
        //        new Type[0]);

        //    ILGenerator generator = newMethod.GetILGenerator();
        //    generator.Emit(OpCodes.Ldc_I4, 1);

        //    for(int i = 2; i <= 100; i++)
        //    {
        //        generator.Emit(OpCodes.Ldc_I4, i);
        //        generator.Emit(OpCodes.Add);
        //    }

        //    generator.Emit(OpCodes.Ret);
        //    newType.CreateType();

        //    object sum1To100 = Activator.CreateInstance(newType);
        //    MethodInfo Calculate = sum1To100.GetType().GetMethod("Calculate");
        //    Console.WriteLine(Calculate.Invoke(sum1To100, null));
        //}
    }
}

namespace BasicAttribute
{ 
    class MyClass
    {
        [Obsolete("OldMethod는 폐기되었습니다. NewMethod()를 이용하세요.")]
        public void OldMethod()
        {
            Console.WriteLine("I'm old");
        }

        public void NewMethod()
        {
            Console.WriteLine("I'm new");
        }
    }

    class MainApp()
    { 
        //static void Main(string[] args)
        //{
        //    MyClass obj = new MyClass();
        //    obj.OldMethod();
        //    obj.NewMethod();
        //}
    }
}

namespace CallerInfo
{
    public static class Trace
    {
        public static void WriteLine(string message,
            [CallerFilePath] string file = "",
            [CallerLineNumber] int line = 0,
            [CallerMemberName] string member = "")
        {
            Console.WriteLine($"{file}(Line:{line}) {member}: {message}");
        }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Trace.WriteLine("즐거운 프로그래밍!");
        //}
    }
}

namespace HistoryAttribute
{
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
    class History : System.Attribute
    {
        private string programmer;
        public double version;
        public string changes;

        public History(string programmer)
        {
            this.programmer = programmer;
            version = 1.0;
            changes = "First release";
        }

        public string GetProgrammer()
        {
            return programmer;
        }
    }

    [History("Sean", version = 0.1, changes = "2017-11-01 Created class sub")]
    [History("Bob", version = 0.2, changes = "2020-12-03 Added Func() Method")]
    class MyClass
    {
        public void Func()
        {
            Console.WriteLine("Func()");
        }
    }

    class MainApp
    { 
        static void Main(string[] args)
        {
            Type type = typeof(MyClass);
            Attribute[] attributes = Attribute.GetCustomAttributes(type);

            Console.WriteLine("MyClass change history...");

            foreach(Attribute a in attributes)
            {
                History h = a as History;
                if(h != null)
                {
                    Console.WriteLine("Version:{0}, Programmer:{1}, Changes:{2}", h.version, h.GetProgrammer(), h.changes);
                }
            }

        }
    }
}