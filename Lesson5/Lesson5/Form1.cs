using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter;

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
        }

        int Counter
        {
            get { return counter; }
            set { counter = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter = 0;
            label1.Text = counter.ToString();
            
        }
    }
}
