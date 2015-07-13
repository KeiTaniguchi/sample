using System;

namespace mojigyaku
{
    public class mojigyaku
    {
        public static void Main(string[] args)
        {
            String mojiretsu = "stressed";
            char[] chaire = mojiretsu.ToCharArray();
            Array.Reverse(chaire);
            Console.WriteLine(new string(chaire));

            Console.ReadKey();
        }
    }

}


        //    gyaku g = new gyaku();
        //    g.moji = "stressed";
        //    irekae ire = new irekae();
        //}
        //    public class gyaku
        //    {
        //        public String moji;
        //    }
        //public class irekae : gyaku
        //{
        //    char[] charire = new char[10];
        //    int end = 0;
        //    for(int i=9 ; i == 0 ; i--)
        //{
