using System;

delegate void SomeDelegate(int a);
delegate void ShowMessage();

namespace delegate1
{
    class Program
    {
        static void Main(string[] args)
        {

            ////////////
            //使用例 1// 
            ////////////
            A(256);//delegateしないで、これだけじゃだめなの・・？

            //SomeDelegate a = new SomeDelegate(A);
            //Ver.2.0からはnewしなくても変換できるようになった。
            //Ver.2.0からはnewしなくてもいいので(↓)このように記載できる。
            SomeDelegate a = /*new SomeDelegate(*/A/*)*/;
            a(256);


            ////////////
            //使用例 2//インスタンスメソッドを代入できる。
            ////////////staticメソッド非staticメソッドのどちらも代入できる。
            Person p = new Person("谷口啓");


            ////////////
            //使用例 3//複数のメソッドを代入できる。
            ////////////
            ShowMessage show = /*new ShowMessage(*/p.ShowName/*)*/;
            //Ver.2.0からはnewしなくてもいいのでこのように↑記載できる。
            show += new ShowMessage(p.ShowName);
            show += new ShowMessage(B);
            show += new ShowMessage(C);

            show();
            //+=で代入した順に逐次実行される。
        }

        static void A(int n)
        {
            Console.Write("hogehoge{0}\n", n);
        }

        static void B()
        {
            Console.Write("hogehogeB\n");
        }
        static void C()
        {
            Console.Write("hogehogeC\n");
        }

        class Person
        {
            string name;
            public Person(string name)
            {
                this.name = name;
            }
            public void ShowName()
            {
                Console.Write("名前：{0}\n", this.name);
            }
        };
    }
}
