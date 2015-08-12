using System;
using System.Windows.Forms;

namespace Lesson9
{
    public partial class Form1 : Form
    {
        interface IOperator
        {
            /// <summary>
            /// 与えられたパラメータに2項演算を適用し結果を返送する。
            /// </summary>
            /// <param name="left">左項値</param>
            /// <param name="right">右項値</param>
            /// <returns>計算結果</returns>
            object Calculate(int left, int right);

        }
        class Plus : IOperator
        {
            public object Calculate(int left, int right)
            {
                return left + right;
            }
            public override string ToString()
            {
                return "+";
            }
        }
        class Minus : IOperator
        {
            public object Calculate(int left, int right)
            {
                return left - right;
            }
            public override string ToString()
            {
                return "-";
            }
        }
        class Asterisk : IOperator
        {
            public object Calculate(int left, int right)
            {
                return left * right;
            }
            public override string ToString()
            {
                return "*";
            }
        }
        class Slash : IOperator
        {
            public object Calculate(int left, int right)
            {
                return left / right;
            }
            public override string ToString()
            {
                return "/";
            }
        }
        class percent : IOperator
        {
            public object Calculate(int left, int right)
            {
                return left % right;
            }
            public override string ToString()
            {
                return "%";
            }
        }
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add(new Plus());
            comboBox1.Items.Add(new Minus());
            comboBox1.Items.Add(new Asterisk());
            comboBox1.Items.Add(new Slash());
            comboBox1.Items.Add(new percent());
            comboBox1.SelectedIndex = 0;
        }
        private void prepareInput()
        {
            textBox1.SelectAll();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var left = 0;
            var right = 0;
            try
            {
                left = int.Parse(textBox1.Text);
                right = int.Parse(textBox2.Text);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                prepareInput();
                return;
            }
            var operation = comboBox1.SelectedItem as IOperator;
            label1.Text = operation.Calculate(left, right).ToString();
        }
    }
}
