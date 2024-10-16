using System;
using System.Linq;
using System.IO;
using System.Reflection.Metadata;
using System.IO;
using FS = System.IO.FileStream;
using System.Formats.Asn1;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Dir 
{
    class MainApp
    {
        static void OnWrongPathType(string type)
        {
            Console.WriteLine($"{type} is wrong type");
            return;
        }

        //static void Main(string[] args)
        //{
        //    if(args.Length == 0)
        //    {
        //        Console.WriteLine("Usage : Touch.exe <Path> [Type:File/Directory]");
        //        return;
        //    }

        //    string path = args[0];
        //    string type = "File";
        //    if(args.Length > 1)
        //    {
        //        type = args[1];
        //    }

        //    if(File.Exists(path) || Directory.Exists(path))
        //    {
        //        if(type == "File")
        //        {
        //            File.SetLastWriteTime(path, DateTime.Now);
        //        }
        //        else if(type == "Directory")
        //        {
        //            Directory.SetLastWriteTime(path, DateTime.Now);
        //        }
        //        else
        //        {
        //            OnWrongPathType(path);
        //            return;
        //        }
        //        Console.WriteLine($"Updated {path} {type}");
        //    }
        //    else
        //    {
        //        if(type == "File")
        //        {
        //            File.Create(path).Close();
        //        }
        //        else if(type == "Directory")
        //        {
        //            Directory.CreateDirectory(path);
        //        }
        //        else
        //        {
        //            OnWrongPathType(path);
        //            return;
        //        }

        //        Console.WriteLine($"Created {path} {type}");
        //    }
        //}
    }
}

namespace BasicIO
{
    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    long someValue = 0x123456789ABCDEF0;
        //    Console.WriteLine("{0, -1} : 0x{1:X16}", "Original Data", someValue);

        //    Stream outStream = new FileStream("a.dat", FileMode.Create);
        //    byte[] wBytes = BitConverter.GetBytes(someValue); //쓸 데이터를 바이트로 변환

        //    Console.Write("{0, -13}", "Byte Array");

        //    foreach(byte b in wBytes)
        //    {
        //        Console.Write("{0:X2} ", b);
        //    }
        //    Console.WriteLine();

        //    outStream.Write(wBytes, 0, wBytes.Length);
        //    outStream.Close();

        //    //읽기
        //    Stream inStream = new FileStream("a.dat", FileMode.Open);
        //    byte[] rBytes = new byte[8];

        //    int i = 0;
        //    while(inStream.Position < inStream.Length)
        //    {
        //        rBytes[i++] = (byte)inStream.ReadByte();
        //    }

        //    long readValue = BitConverter.ToInt64(rBytes, 0);

        //    Console.WriteLine("{0,-13} : 0x{1:X16} ", "Read Data", readValue);
        //    inStream.Close();
        //}
    }
}

namespace SeqNRand
{
    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    Stream outStream = new FileStream("b.dat", FileMode.Create);
        //    Console.WriteLine($"Position : {outStream.Position}");

        //    outStream.WriteByte(0x01);
        //    Console.WriteLine($"Position : {outStream.Position}");

        //    outStream.WriteByte(0x02);
        //    Console.WriteLine($"Position : {outStream.Position}");

        //    outStream.WriteByte(0x03);
        //    Console.WriteLine($"Position : {outStream.Position}");

        //    outStream.Seek(5, SeekOrigin.Current);
        //    Console.WriteLine($"Position : {outStream.Position}");

        //    outStream.WriteByte(0x04);
        //    Console.WriteLine($"Position : {outStream.Position}");

        //    outStream.Close();

        //    FileStream inStream = new FileStream("b.dat", FileMode.Open);
        //    byte[] rBytes = new byte[1024];

        //    int i = 0;
        //    while(inStream.Position < inStream.Length)
        //    {
        //        rBytes[i++] = (byte)inStream.ReadByte();
        //    }

        //    long readInfo = BitConverter.ToInt32(rBytes);
        //    Console.WriteLine($"{readInfo}");
        //}
    }
}



namespace UsingDeclaration
{
    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    long someValue = 0x123456789ABCDEF0;
        //    Console.WriteLine("{0, -1} : 0X{1:X16}", "Original Data", someValue);

        //    using (Stream outStream = new FS("a.dat", FileMode.Open))
        //    {
        //        byte[] wBytes = BitConverter.GetBytes(someValue);

        //        Console.Write("{0, -13} : ", "Byte array");

        //        foreach(byte b in wBytes)
        //        {
        //            Console.Write("{0:X2} ", b);
        //        }

        //        Console.WriteLine();

        //        outStream.Write(wBytes, 0, wBytes.Length);
        //    }

        //    using (Stream inStream = new FS("a.dat", FileMode.Open))
        //    {
        //        byte[] rBytes = new byte[8];

        //        int i = 0;
        //        while(inStream.Position < inStream.Length)
        //        {
        //            rBytes[i++] = (byte)inStream.ReadByte();
        //        }

        //        long readValue = BitConverter.ToInt64(rBytes, 0);

        //        Console.WriteLine("{0,-13} : 0x{1:X16} ", "Read Data", readValue);
        //    }
        //}
    }
}

namespace BinaryFile
{
    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    using (BinaryWriter bw = new BinaryWriter(new FileStream("c.dat", FileMode.Create)))
        //    {
        //        //bw.Write(int.MaxValue);
        //        //bw.Write("Good Morning!");
        //        //bw.Write(uint.MaxValue);
        //        //bw.Write("안녕하세요!");
        //        //bw.Write(double.MaxValue);

        //        string str = string.Empty;
        //        for(int i = 0; i < 256; i++)
        //        {
        //            str += 'a';
        //        }
        //        bw.Write(str);
        //    }

        //    using (BinaryReader br = new BinaryReader(new FileStream("c.dat", FileMode.Open)))
        //    {
        //        Console.WriteLine($"File Size : {br.BaseStream.Length} bytes");
        //        //Console.WriteLine(br.ReadInt32());
        //        //Console.WriteLine(br.ReadString());
        //        //Console.WriteLine(br.ReadUInt32());
        //        //Console.WriteLine(br.ReadString());
        //        //Console.WriteLine(br.ReadDouble());

        //        Console.WriteLine(br.ReadString());
        //    }
        //}
    }
}

namespace TextFile
{
    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    using (StreamWriter sw = new StreamWriter(new FileStream("a.txt", FileMode.Create)))
        //    {
        //        sw.WriteLine(int.MaxValue);
        //        sw.WriteLine("Good Morning!");
        //        sw.WriteLine(uint.MaxValue);
        //        sw.WriteLine("안녕하세요!");
        //        sw.WriteLine(double.MaxValue);
        //    }

        //    using (StreamReader sr = new StreamReader(new FileStream("a.txt", FileMode.Open)))
        //    {
        //        Console.WriteLine($"File Size : {sr.BaseStream.Length} bytes");

        //        while(sr.EndOfStream == false)
        //        {
        //            Console.WriteLine(sr.ReadLine());
        //        }

        //    }
        //}
    }
}

namespace Serialization
{
    class NameCard
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
    }

    class MainApp
    {
        //static void Main(string[] args)
        //{
        //    var fileName = "a.json";

        //    using (Stream ws = new FileStream(fileName, FileMode.Create))
        //    {
        //        NameCard nc = new NameCard()
        //        {
        //            Name = "박상현",
        //            Phone = "010-123-4567",
        //            Age = 33

        //        };

        //        string jsonString = JsonSerializer.Serialize<NameCard>(nc);
        //        byte[] jsonBytes = System.Text.Encoding.UTF8.GetBytes(jsonString);
        //        ws.Write(jsonBytes, 0, jsonBytes.Length);
        //    }

        //    using (Stream rs = new FileStream(fileName, FileMode.Open))
        //    {
        //        byte[] jsonBytes = new byte[rs.Length];
        //        rs.Read(jsonBytes, 0, jsonBytes.Length);

        //        string jsonString = System.Text.Encoding.UTF8.GetString(jsonBytes);

        //        NameCard nc2 = JsonSerializer.Deserialize<NameCard>(jsonString);

        //        Console.WriteLine($"Name:   {nc2.Name}");
        //        Console.WriteLine($"Phone:   {nc2.Phone}");
        //        Console.WriteLine($"Age:   {nc2.Age}");
        //    }
        //}
    }
}

namespace Serialization2
{
    class NameCard
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            var fileName = "a.json";

            using (Stream ws = new FileStream(fileName, FileMode.Create))
            {
                var list = new List<NameCard>();
                list.Add(new NameCard() { Name = "박상현", Phone = "010-123-4567", Age = 22 });
                list.Add(new NameCard() { Name = "김연아", Phone = "010-323-1111", Age = 22 });
                list.Add(new NameCard() { Name = "장미란", Phone = "010-555-5555", Age = 22 });

                string jsonString = JsonSerializer.Serialize<List<NameCard>>(list);
                byte[] jsonBytes = System.Text.Encoding.UTF8.GetBytes(jsonString);
                ws.Write(jsonBytes, 0, jsonBytes.Length);
            }

            using (Stream rs = new FileStream(fileName, FileMode.Open))
            {
                byte[] jsonBytes = new byte[rs.Length];
                rs.Read(jsonBytes, 0, jsonBytes.Length);
                string jsonString = System.Text.Encoding.UTF8.GetString(jsonBytes);

                var list2 = JsonSerializer.Deserialize<List<NameCard>>(jsonString);
                foreach (NameCard nc in list2)
                {
                    Console.WriteLine($"Name : {nc.Name} Phone : {nc.Phone} Age : {nc.Age}");
                }
            }
        }
    }
}