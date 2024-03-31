using System.Data;
using System.Text.RegularExpressions;

namespace Calculator
{

    public partial class Form1 : Form
    {
        /** 
         @basic - helper function
         */
        private string TruncateNumber(double number)
        {
            // Convert the number to a string
            string numberString = number.ToString();

            // Check if the number has decimal places
            if (numberString.Contains("."))
            {
                // Split the number into integer and decimal parts
                string[] parts = numberString.Split('.');
                string integerPart = parts[0];
                string decimalPart = parts[1];

                // Check if the decimal part is either all zeros or too long
                if (decimalPart == "0" || decimalPart.Length > 12)
                {
                    // Return only the integer part
                    return integerPart;
                }
                else
                {
                    // Return the original number since it satisfies the conditions
                    return numberString;
                }
            }
            else
            {
                // Return the original number if it's an integer
                return numberString;
            }
        }
        private string currentCalculation = "";
        public Form1()
        {
            InitializeComponent(GetButtonEquals());
           

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
            // Check if the current calculation is empty or ends with an operator
            if (currentCalculation == "" || "+-×÷".Contains(currentCalculation[currentCalculation.Length - 1]))
            {
                // If so, add "0" before the decimal point
                currentCalculation += "0";
            }

            // Add the decimal point to the current calculation
            currentCalculation += ((Button)sender).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            // Replace "×" with "*", "÷" with "/", and "−" with "-"
            string formattedCalculation = currentCalculation.Replace("×", "*")
                                                             .Replace("÷", "/")
                                                             .Replace("−", "-");


            try
            {
                // Parse the expression to identify division operations
                string[] tokens = formattedCalculation.Split('+', '-', '*', '/');
                foreach (string token in tokens)
                {
                    // Check if the token is a division operation
                    if (token.Contains("/"))
                    {
                        // If the division operation is between integers, append ".0" to one of the operands
                        string[] operands = token.Split('/');
                        if (operands.Length == 2 && int.TryParse(operands[0], out _) && int.TryParse(operands[1], out _))
                        {
                            formattedCalculation = formattedCalculation.Replace(token, $"{operands[0]}.0/{operands[1]}");
                            break; // No need to continue after modifying one division operation
                        }
                    }
                }

                // Calculate the result
                double result = Convert.ToDouble(new DataTable().Compute(formattedCalculation, null));

                // Truncate the result if necessary
                string truncatedResult = TruncateNumber(result);

                // Display the result
                textBoxOutput.Text = truncatedResult;
                currentCalculation = truncatedResult;
            }
            catch (Exception ex)
            {
                textBoxOutput.Text = "0";
                currentCalculation = "";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            // Check if the current calculation is empty or ends with an operator
            if (currentCalculation == "" || "+-×÷".Contains(currentCalculation[currentCalculation.Length - 1]))
            {
                // If so, add "0" before the plus operator
                currentCalculation += "0";
            }
            // This adds the number or operator to the string calculation
            currentCalculation += ((Button)sender).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            // Check if the current calculation is empty or ends with an operator
            if (currentCalculation == "" || "+-×÷".Contains(currentCalculation[currentCalculation.Length - 1]))
            {
                // If so, add "0" before the plus operator
                currentCalculation += "0";
            }
            // This adds the number or operator to the string calculation
            currentCalculation += ((Button)sender).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            // Check if the current calculation is empty or ends with an operator
            if (currentCalculation == "" || "+-×÷".Contains(currentCalculation[currentCalculation.Length - 1]))
            {
                // If so, add "0" before the plus operator
                currentCalculation += "0";
            }
            // This adds the number or operator to the string calculation
            currentCalculation += ((Button)sender).Text;

            // Display the current calculation back to the user
            textBoxOutput.Text = currentCalculation;
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            // Check if the current calculation is empty or ends with an operator
            if (currentCalculation == "" || "+-×÷".Contains(currentCalculation[currentCalculation.Length - 1]))
            {
                // If so, add "0" before the plus operator
                currentCalculation += "0";
            }
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
