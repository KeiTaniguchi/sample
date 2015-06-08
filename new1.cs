using System;

namespace myapp
{
    class Program
    {
        public static void Main(string[] args)
        {
            MyObject obj = new MyObject();
            obj.name = "谷口";
            obj.age = 30;
            obj.printData();
            Console.ReadKey();

        }
    }

    class MyObject
    {
        public string name = "(noname)";
        public int age = 0;

        public void printData()
    {
        Console.WriteLine("名前:{0},年齢:{1}歳" , name , age);
    }
    }
}
