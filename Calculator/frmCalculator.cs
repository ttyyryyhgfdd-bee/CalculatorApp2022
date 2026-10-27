using System;
namespace CalculatorApp
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }

        #region variebles
        Calculator.Math calcMath = new Calculator.Math();
        bool newOperation = true;
        bool lastAction = true;
        double firstValue;
        double secondValue;
        double result = 0.0;
        string choosenOperation;
        #endregion

        #region ActionNumber
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
            lastAction = false;
        }
        #endregion

        #region ActionOperation
        private void btnActionOperation(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            if (btn.Text == "Back")
            {
                if (txtCalcGUI.Text.Length <= 1)
                {
                    txtCalcGUI.Text = "0";
                    newOperation = true;
                }
                else
                {
                    txtCalcGUI.Text = txtCalcGUI.Text.Remove(txtCalcGUI.Text.Length - 1);
                }
                return;
            }

            if (btn.Text == "Clear")
            {
                firstValue = 0;
                secondValue = 0;
                result = 0;
                choosenOperation = "";
                txtCalcGUI.Text = "0";
                newOperation = true;
                lastAction = false;
                return;
            }

            if (btn.Text != "=")
            {
                firstValue = Convert.ToDouble(txtCalcGUI.Text);
                choosenOperation = btn.Text;
                newOperation = true;
                lastAction = false;
                return;
            }
            if (lastAction)
            {
                firstValue = Convert.ToDouble(txtCalcGUI.Text);
            }
            else
            {
                secondValue = Convert.ToDouble(txtCalcGUI.Text);
            }
            

            #region Operations
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
                case "!":
                    result = calcMath.Factorial(Convert.ToInt32(firstValue));
                    break;
                case "D%":
                    result = calcMath.InvPercent(firstValue, secondValue);
                    break;
                case "^":
                    result = calcMath.Power(firstValue, Convert.ToInt32(secondValue));
                    break;
                default:
                    break;
            }
            #endregion

            #endregion

            txtCalcGUI.Text = result.ToString();
            newOperation = true;
            lastAction = true;
        }
    }
}
