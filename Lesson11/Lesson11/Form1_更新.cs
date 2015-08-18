using System;
using System.Windows.Forms;

namespace Lesson11
{
    public partial class Form1 : Form
    {
        class Operator
        {
            //readonly(読み取り専用)のstring型displayStringを定義
            readonly string displayString;
            //readonly(読み取り専用)のラムダ式の型calculateFuncを定義
            readonly Func<int, int, object> calculateFunc;

            //コンストラクタ
            internal Operator(string symbol, Func<int, int, object> calcFunc)
            {
                displayString = symbol;
                calculateFunc = calcFunc;
            }

            public override string ToString()
            {
                return displayString;
            }

            /// <summary>
            /// 与えられたパラメータをint型に変換してから所定の演算を実行する。
            /// </summary>
            /// <param name="left">左項</param>
            /// <param name="right">右項</param>
            /// <returns>計算結果</returns>
            internal string Calculate(string left, string right)
            {
                return calculateFunc(ToInt(left), ToInt(right)).ToString();
            }

            //Calculateメソッドの下請けメソッド(文字列をintに変換)
            int ToInt(string value)
            {
                try
                {
                    return int.Parse(value);
                }
                catch (Exception e)
                {
                    throw new ArgumentException(value + "は不正な入力です。", e);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add(new Operator("+", (left, right) => { return left + right; }));
            comboBox1.Items.Add(new Operator("-", (left, right) => { return left - right; }));
            comboBox1.Items.Add(new Operator("*", (left, right) => { return left * right; }));
            comboBox1.Items.Add(new Operator("/", (left, right) => { return left / right; }));
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)//
        {
            var calculator = comboBox1.SelectedItem as Operator;
            try
            {
                label1.Text = calculator.Calculate(textBox1.Text, textBox2.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            textBox1.SelectAll();
            textBox1.Focus();
        }
    }
}
