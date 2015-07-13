using System;


namespace myapp
{
    public class patat
    {
        public static void Main(string[] args)
        {
            String patato = "パタトクカシーー";

            char[] str = new char[4];
            int c = 0;      
            for(int i=0 ; i < 8 ; i++)
            {
                if (i % 2 == 0 )
                {
                    str[c] = patato[i];
                    c++;
                }
            }
            Console.WriteLine(str);
        }
    }
}

//String[] arr = patato.Split();

//char str1 = patato[0];
//char str3 = patato[2];
//char str5 = patato[4];
//char str7 = patato[6];

//Console.WriteLine(str1.ToString());
//Console.WriteLine(str3.ToString());
//Console.WriteLine(str5.ToString());
//Console.WriteLine(str7.ToString());