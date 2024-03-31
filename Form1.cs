using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        //using System.Data;
        private string currentCalculation = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void button0_Click(object sender, EventArgs e)
        {
            // This adds the number or operator to the string calculation
            currentCalculation += ((Button)sender).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // This adds the number or operator to the string calculation
            currentCalculation += ((Button)sender).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // This adds the number or operator to the string calculation
            currentCalculation += ((Button)sender).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // This adds the number or operator to the string calculation
            currentCalculation += ((Button)sender).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // This adds the number or operator to the string calculation
            currentCalculation += ((Button)sender).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            // This adds the number or operator to the string calculation
            currentCalculation += ((Button)sender).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            // This adds the number or operator to the string calculation
            currentCalculation += ((Button)sender).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // This adds the number or operator to the string calculation
            currentCalculation += ((Button)sender).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // This adds the number or operator to the string calculation
            currentCalculation += ((Button)sender).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // This adds the number or operator to the string calculation
            currentCalculation += ((Button)sender).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            // This adds the number or operator to the string calculation
            currentCalculation += ((Button)sender).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string formattedCalculation = currentCalculation.ToString().Replace("X", "*").ToString().Replace("&divide;", "/");

            try
            {
                textBoxOutput.Text = new DataTable().Compute(formattedCalculation, null).ToString();
                currentCalculation = textBoxOutput.Text;
            }
            catch (Exception ex)
            {
                textBoxOutput.Text = "0";
                currentCalculation = "";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            // This adds the number or operator to the string calculation
            currentCalculation += ((Button)sender).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            // This adds the number or operator to the string calculation
            currentCalculation += ((Button)sender).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            // This adds the number or operator to the string calculation
            currentCalculation += ((Button)sender).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            // This adds the number or operator to the string calculation
            currentCalculation += ((Button)sender).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void buttonLeftPara_Click(object sender, EventArgs e)
        {
            // This adds the number or operator to the string calculation
            currentCalculation += ((Button)sender).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void buttonRightPara_Click(object sender, EventArgs e)
        {
            // This adds the number or operator to the string calculation
            currentCalculation += ((Button)sender).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            // Reset the calculation and empty the textbox
            textBoxOutput.Text = "0";
            currentCalculation = "";
        }

        private void buttonClearLast_Click(object sender, EventArgs e)
        {
            // If the calculation is not empty, remove the last number/operator entered
            if (currentCalculation.Length > 0)
            {
                currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1, 1);
            }

            // Re-display the calculation onto the screen
            textBoxOutput.Text = currentCalculation;
        }

        private void TextBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
