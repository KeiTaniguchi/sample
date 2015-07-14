using System;
using System.Collections.Generic;

/*
"Hi He Lied Because Boron Could Not Oxidize Fluorine. New Nations Might Also Sign Peace Security Clause. Arthur King Can."
 * という文を単語に分解し，1, 5, 6, 7, 8, 9, 15, 16, 19番目の単語は先頭の1文字，それ以外の単語は先頭に2文字を取り出し，
 * 取り出した文字列から単語の位置（先頭から何番目の単語か）への連想配列（辞書型もしくはマップ型）を作成せよ．
 * 0,4,5,6,7,8,14,15,18
*/

namespace myapp
{
    public class genso
    {
        public static void Main(string[] args)
        {
            string genso = "Hi He Lied Because Boron Could Not Oxidize Fluorine. New Nations Might Also Sign Peace Security Clause. Arthur King Can.";
            string[] strsplitData = genso.Split(' ');

            //単純にswitchで当てはまった時に出力してみる。今回の課題はList化することなのでCollectionの勉強が必要。
            //for (int i = 0 ; i < strsplitData.Length; i++)
            //{
            //    switch ( i )
            //    {
            //        case 0:
            //        case 4:
            //        case 5:
            //        case 6:
            //        case 7:
            //        case 8:
            //        case 14:
            //        case 15:
            //        case 18:
            //            Console.WriteLine(strsplitData[i].Substring(0, 1));
            //            break;
            //        default:
            //            Console.WriteLine(strsplitData[i].Substring(0, 2));
            //            break;
            //    }
            //}

            Dictionary<int, string> dict = new Dictionary<int, string>();
            for( int d=0 ; d < strsplitData.Length ; d++)
            {
                if (d == 0 || d == 4 || d == 5 || d == 6 || d == 7 || d == 8 || d == 14 || d == 15 || d == 18)
                {
                    dict[d] = strsplitData[d].Substring(0, 1);
                }
                else
                {
                    dict[d] = strsplitData[d].Substring(0, 2);
                }
                Console.WriteLine(dict[d]);
            }
            Console.ReadKey();
        }
    }
}
