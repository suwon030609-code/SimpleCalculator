namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private string firstInput = "";
        private string secondInput = "";
        private string currentOperator = "";
        public Form1()
        {
            InitializeComponent();
            txtHistory.Text = "";
            txtDisplay.Text = "0";
        }
        private void UpdateScreen()
        {
            if (currentOperator == "")
            {
                txtHistory.Text = firstInput;
                txtDisplay.Text = firstInput == "" ? "0" : firstInput;
            }
            else
            {
                txtHistory.Text = $"{firstInput} {currentOperator} {secondInput}".Trim();
                txtDisplay.Text = secondInput == "" ? "0" : secondInput;
            }

        }
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string digit = clickedButton.Text;

            if (currentOperator == "")
            {
                firstInput += digit;
            }
            else
            {
                secondInput += digit;
            }

            UpdateScreen();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (firstInput == "")
                return;

            currentOperator = "+";
            UpdateScreen();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
           if (firstInput == "" || secondInput == "" || currentOperator != "+")
                return;

            int n1 = int.Parse(firstInput);
            int n2 = int.Parse(secondInput);
            int result = n1 + n2;

            txtHistory.Text = $"{n1} + {n2} = {result}";
            txtDisplay.Text = result.ToString();

            firstInput = result.ToString();
            secondInput = "";
            currentOperator = "";
        }
    }
}
