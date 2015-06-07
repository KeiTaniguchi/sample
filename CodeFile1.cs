using System;

namespace myapp
{
    class gusukisu
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("整数値を入力してください。");
            string a;
            a = Console.ReadLine();
            int b;
            if (int.TryParse(a , out b))
            {
            if (b % 2 == 0)
            {
                Console.WriteLine(b + "は偶数です。");
            }
            else
            {
                Console.WriteLine(b + "は奇数です。");
            }
            }
            else
            {
                Console.WriteLine("入力した値は整数値ではありません。");
            }
            Console.ReadKey();
        }
    }
}
