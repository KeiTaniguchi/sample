using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson10
{
    public partial class Form1 : Form
    {
        abstract class Operator
        {
            readonly string displayString;
            internal Operator (string symbol)
            {
                displayString = symbol;
            }
            public override string ToString()
            {
                return displayString;
            }
            internal abstract object Calculate(int left , int right);
            internal string Calculate(string left , string right)
            {
                return Calculate(ToInt(left), ToInt(right)).ToString();
            }

            private int ToInt(string value)
            {
                try
                {
                    return int.Parse(value);
                }
                catch(Exception e)
                {
                    throw new ArgumentException(value + "は不正な入力です。", e);
                }
            }
        }

        class plus : Operator
        {
            internal plus(string symbol)
                : base(symbol)
            {

            }
            internal override object Calculate(int left , int right)
            {
                return left + right;
            }
        }
        class Minus : Operator
        {
            internal Minus(string symbol)
                :
                base(symbol)
            {

            }
            internal override object Calculate(int left, int right)
            {
                return left - right;
            }
        }
        class Asterisk : Operator
        {
            internal Asterisk(string symbol)
                :base(symbol)
            {

            }
            internal override object Calculate(int left, int right)
            {
                return left * right;
            }
        }
        class Slash : Operator
        {
            internal Slash(string symbol)
                : base(symbol)
            {

            }
            internal override object Calculate(int left, int right)
            {
                return left / right;
            }
        }
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add(new plus("+"));
            comboBox1.Items.Add(new Minus("-"));
            comboBox1.Items.Add(new Asterisk("*"));
            comboBox1.Items.Add(new Slash("/"));
            comboBox1.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var calculator = comboBox1.SelectedItem as Operator;
            try
            {
                label1.Text = calculator.Calculate(textBox1.Text, textBox2.Text);
            }
            catch(ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
            }
            textBox1.SelectAll();
            textBox1.Focus();
        }
    }
}
