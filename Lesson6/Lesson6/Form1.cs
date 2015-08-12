using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Total { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            var inputA = int.Parse(textBox1.Text);
            var inputB = int.Parse(textBox2.Text);
            Total = inputA + inputB;
            label1.Text = Total.ToString();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
