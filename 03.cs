using System;
using System.Windows.Forms;

namespace myapp
{
    public class tangolist
    {
        static void Main(string[] args)
        {
            string strData = "Now I need a drink, alcoholic of course, after the heavy lectures involving quantum mechanics.";
            string[] strsplitData = strData.Split(' ');

            //foreach (string showData in strsplitData)
            //{
            //    MessageBox.Show(showData);
            //}
            for (int i = 0; i < strsplitData.Length ; i++ )
            {
                if (i == 1)
                {
                    Console.Write(".");
                }
                if (strsplitData[i].EndsWith(",") || strsplitData[i].EndsWith("."))
                {
                    int lensplitData = strsplitData[i].Length - 1;
                    Console.Write(lensplitData);
                }
                else
                {
                    Console.Write(strsplitData[i].Length);
                }
            }
            Console.ReadKey();
        }
    }
}

