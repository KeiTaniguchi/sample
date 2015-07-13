using System;

namespace mojirenketsu
{
    public class mojirenketsu
    {
        public static void Main(string[] args)
        {
            String patoka = "パトカー";
            String takushi = "タクシー";
            char[] str = new char[8];

            int pata = 0;
            int taku = 0;
            for( int i = 0 ; i < 8 ; i++)
            {
                if ( i % 2 == 0)
                {
                    str[i] = patoka[pata];
                    pata++;
                }
                else
                {
                    str[i] = takushi[taku];
                    taku++;
                }
            }
            Console.WriteLine(str);
        }
    }
}