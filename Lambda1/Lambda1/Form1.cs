using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Lambda1
{
    //ラムダ式を使ってボタンクリック時に各ラベルに数字が表示されるようなものを作ってみる。
    public partial class Form1 : Form
    {
        Func<int , string> AA = (int y) =>
        {
            y = 67890;
            string GM = "おはよう"+y;
            return GM;
        };

        //Func<string>型の AAを定義し
        //()内の引数(int型のy)を元に
        //=>{}内に記載されているメソッドを実行している。

        Func<int , string> BB = (int x) =>
        {
            string GE = "こんばんは"+x;
            return GE;

        //Func<string>型の BBを定義し
        //()内の引数を元に(今回の場合は引数なし)
        //=>{}内に記載されているメソッドを実行している。
        };

        public Form1()
        {
            InitializeComponent();
            label1.Text = "挨拶1";
            label2.Text = "挨拶2";
            label3.Text = "挨拶3";
        }

        public void subAA()
        {
            FuncAll(AA);
        }

        public void subBB()
        {
            FuncAll(BB);
        }

        public void subCC()
        {
            string filepathC = "testC.txt";
            using (StreamWriter CC = new StreamWriter(filepathC))
            {
            CC.WriteLine(textBox1);
            }

        }

        public void subDD()
        {
            string filepathD = "testD.txt";
            //string filepathD = "D:\\testD.txt";
            //\\をのように書く必要があるので注意。
            using (StreamReader DD = new StreamReader(filepathD))
            {
                textBox1.Text = DD.ReadToEnd();
            }
        }

        public void FuncAll(Func<int,string> afunc)
        {
            int hogehoge = 12345;
            label1.Text = "こんにちは";
            label2.Text = afunc(hogehoge);
            label3.Text = "こんにちは";
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            subAA();
            subDD();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            subBB();
            subCC();
        }
    }
}

//上記とは別でふと思い出した疑問点。
//そういえば、このゲッターとセッターって詳しく説明できない。
//今少し調べた知識としては、ユーザが入力したものをpublicで公開
//してしまうと危険。隠蔽するために取得(getしてNo変数にsetしている。)
