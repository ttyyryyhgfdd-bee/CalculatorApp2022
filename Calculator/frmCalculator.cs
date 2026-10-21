using System;
namespace CalculatorApp
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }
        Calculator.Math calcMath = new Calculator.Math();
        bool newOperation = true;
        double firstValue;
        double secondValue;
        double result = 0.0;
        string choosenOperation;
        private void btnActionNumber(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (newOperation)
            {
                txtCalcGUI.Clear();
                newOperation = false;
            }
            if (btn.Text == ",")
            {
                var val = txtCalcGUI.Text.IndexOf(',');
                if (val != -1)
                {
                    return;
                }
            }
            txtCalcGUI.Text += btn.Text;
        }
        private void btnActionOperation(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn.Text != "=")
            {
                firstValue = Convert.ToDouble(txtCalcGUI.Text);
                choosenOperation = btn.Text;
                newOperation = true;
                return;
            }
            secondValue = Convert.ToDouble(txtCalcGUI.Text);

            switch (choosenOperation)
            {
                case "+":
                    result = calcMath.Addition(firstValue, secondValue);
                    break;
                case "-":
                    result = calcMath.Subtraction(firstValue, secondValue);
                    break;
                case "*":
                    result = calcMath.Multiplication(firstValue, secondValue);
                    break;
                case "/":
                    result = calcMath.Divider(firstValue, secondValue);
                    break;
                case "%":
                    result = calcMath.Percent(firstValue, secondValue);
                    break;
                default:
                    break;
            }
            txtCalcGUI.Text = result.ToString();
            newOperation = true;
        }
    }
}
