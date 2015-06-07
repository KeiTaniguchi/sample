using System;

namespace hikisu
{
    class Program
    {
        public static void Main(String[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("Hello {0}さん。", args[0]);
            }
            else
            {
                Console.WriteLine("Hello gestさん。");
            }
        }
    }
}