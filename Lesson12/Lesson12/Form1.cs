using System;
using System.Linq;
using System.Windows.Forms;

namespace Lesson12
{
    public partial class Form1 : Form
    {
        interface IButtonAction
        {
            decimal Click(decimal currentValue, Label display, IButtonAction previousAction);
        }
        class NumberButtonAction : IButtonAction
        {
            readonly int displayNumber;
            internal NumberButtonAction(int number)
            {
                displayNumber = number;
            }
            public decimal Click(decimal currentValue, Label display, IButtonAction previousAction)
            {
                if (display.Text == "0" || previousAction is Operator)
                {
                    display.Text = displayNumber.ToString();
                }
                else
                {
                    display.Text += displayNumber;
                }
                return currentValue;
            }
            bool IsOverFlow(string current)
            {
                decimal n = decimal.Parse(current);
                return decimal.MaxValue / 10 <= n;
            }
        }
        class Operator : IButtonAction
        {
            static Func<decimal, decimal, decimal>
                previousCalculate = (lastValue, newValue) => newValue;
            readonly Func<decimal, decimal, decimal> calculate;
            internal Operator(Func<decimal, decimal, decimal> calc)
            {
                calculate = calc;
            }
            public decimal Click(decimal currentValue, Label display, IButtonAction previousAction)
            {
                try
                {
                    decimal nextVal = previousCalculate
                        (currentValue, decimal.Parse(display.Text));
                    previousCalculate = calculate;
                    display.Text = nextVal.ToString();
                    return nextVal;
                }
                catch (OverflowException)
                {
                    MessageBox.Show("オーバーフロー");
                    return currentValue;
                }
            }
            internal static void ResetOperation()
            {
                previousCalculate = (lastValue, newValue) => newValue;
            }
        }
        class ClearEntryButton : IButtonAction
        {
            public virtual decimal Click(decimal currentValue, Label display, IButtonAction previousAction)
            {
                display.Text = "0";
                return currentValue;
            }
        }
        class AllClearButton : ClearEntryButton
        {
            public override decimal Click(decimal currentValue, Label display, IButtonAction previousAction)
            {
                Operator.ResetOperation();
                return base.Click(currentValue, display, previousAction);
            }
        }

        decimal currentValue;
        IButtonAction previousAction;

        public Form1()
        {
            InitializeComponent();
            previousAction = new NumberButtonAction(0);
            buttonNum0.Tag = previousAction;
            buttonNum1.Tag = new NumberButtonAction(1);
            buttonNum2.Tag = new NumberButtonAction(2);
            buttonNum3.Tag = new NumberButtonAction(3);
            buttonNum4.Tag = new NumberButtonAction(4);
            buttonNum5.Tag = new NumberButtonAction(5);
            buttonNum6.Tag = new NumberButtonAction(6);
            buttonNum7.Tag = new NumberButtonAction(7);
            buttonNum8.Tag = new NumberButtonAction(8);
            buttonNum9.Tag = new NumberButtonAction(9);
            buttonAC.Tag = new AllClearButton();
            buttonCE.Tag = new ClearEntryButton();
            buttonSlash.Tag = new Operator((left, right) =>
            {
                if (right == 0)
                {
                    MessageBox.Show("0で除算はできません。");
                    return 0;
                }
                return left / right;
            });
            buttonAsterisk.Tag = new Operator((left, right) => left * right);
            buttonMinus.Tag = new Operator((left, right) => left - right);
            buttonPlus.Tag = new Operator((left, right) => left + right);
            buttonEqual.Tag = new Operator((Left, right) => right);

            foreach (var button in panel1.Controls.OfType<Button>())
            {
                if (button.Text != ".")
                {
                    button.Click += ButtonClick;
                }
            }
        }
        void ButtonClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            currentValue = (button.Tag as IButtonAction).Click
                (currentValue, label1, previousAction);
            previousAction = button.Tag as IButtonAction;
        }
    }
}
