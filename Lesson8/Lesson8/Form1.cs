using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShowResult(object result)
        {
            label1.Text = result.ToString();
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
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                prepareInput();
                return;
            }

            var operand = comboBox1.SelectedItem as String;

            if(operand == "+" )
            {
                ShowResult(left + right);
            }

            else if(operand == "-" )
            {
                ShowResult(left - right);
            }

            else if(operand == "*" )
            {
                ShowResult(left * right);
            }

            else if(operand == "/" )
            {
                ShowResult(left / right);
            }
            
            else if(operand == "%" )
            {
                ShowResult(left % right);
            }     

            else if(operand == "<<" )
            {
                ShowResult(left << right);
            } 
                
            else if(operand == ">>" )
            {
                ShowResult(left >> right);
            }

            else if (operand == "<")
            {
                ShowResult(left < right);
            }
            else if (operand == ">")
            {
                ShowResult(left > right);
            }
            else if (operand == "<=")
            {
                ShowResult(left <= right);
            }

            else if (operand == ">=")
            {
                ShowResult(left >= right);
            }
            else if (operand == "==")
            {
                ShowResult(left == right);
            }

            else if (operand == "!=")
            {
                ShowResult(left != right);
            }
            else if (operand == "&")
            {
                ShowResult(left & right);
            }
            else if (operand == "^")
            {
                ShowResult(left ^ right);
            }
            else if (operand == "|")
            {
                ShowResult(left | right);
            }
            else
            {
                MessageBox.Show("演算子を選択してください。");
            }
            prepareInput();
        }
    }
}
