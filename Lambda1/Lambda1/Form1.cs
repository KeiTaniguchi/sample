using System;
using System.Windows.Forms;

namespace Lambda1
{

    //ラムダ式を使ってボタンクリック時に各ラベルに数字が表示されるようなものを作ってみる。
    public partial class Form1 : Form
    {
        class kansuA
        {
            readonly Func<int, string> afunc;

        }
        public Form1()
        {
            InitializeComponent();

            Func<int , string> AA = (1 , AA)=> { string GM = "おはよう" };
            Func<int , string> BB = (2 , BB)=> { string GE = "こんばんは" };
            FuncAll(1,AA);
            FuncAll(2,BB);

        }

        public FuncAll(int n , Func<int , string> AA)
        {
            label1.Text = "こんにちは";
            label2.Text = AA(1);
            label3.Text = "こんにちは";
            label4.Text = "こんにちは";
            label5.Text = BB(2);//
            label6.Text = "こんにちは";
        }
        //AAのときに「おはよう」、BBの個所で「こんばんは」が表示されるようにしたいが出来ない。
        //詰まる時間がもったいないのできく。

        //上記とは別でふと思い出した疑問点。
        //そういえば、このゲッターとセッターって詳しく説明できない。
        //今少し調べた知識としては、ユーザが入力したものをpublicで公開
        //してしまうと危険。隠蔽するために取得(getしてNo変数にsetしている。)

        private void button1_Click(object sender, System.EventArgs e)
        {
            label1.Text = "共通1";


        }
    }
}
