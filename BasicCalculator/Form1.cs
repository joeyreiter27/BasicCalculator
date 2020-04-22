using System;
using System.Linq;
using System.Windows.Forms;

namespace BasicCalculator
{
    /// <summary>
    /// A basic calculator
    /// </summary>
    public partial class BasicCalculator : Form
    {
        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public BasicCalculator()
        {
            InitializeComponent();
        }

        #endregion

        #region Input Method
        private void UserInputText_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Clearing Methods

        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// 
        /// 
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void CEButton_Click(object sender, EventArgs e)
        {

            // Clears text from the textbox
            this.UserInputText.Text = string.Empty;

            //Focus the user input text (see helper method below)
            FocusInputText();

        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            //Delete the value after the selection
            DeleteTextValue();

            // Focus the user input text
            FocusInputText();
        }
        #endregion

        #region Operator Methods

        /// <summary>
        /// Adds the Divide Character to the text box at the currently selected position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DivideButton_Click(object sender, EventArgs e)
        {
            //Inserts the value into the text box at the currently selected position
            InsertTextValue("/");
            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the Multiply Character to the text box at the currently selected position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            //Inserts the value into the text box at the currently selected position
            InsertTextValue("*");
            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the Minus Character to the text box at the currently selected position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinusButton_Click(object sender, EventArgs e)
        {
            //Inserts the value into the text box at the currently selected position
            InsertTextValue("-");
            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the Add Character to the text box at the currently selected position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            //Inserts the value into the text box at the currently selected position
            InsertTextValue("+");
            // Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Executes the arthmetic and produces the calculated value to the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            //
            CalculateEquation();
            // Focus the user input text
            FocusInputText();
        }



        #endregion

        #region Number Methods
        /// <summary>
        /// Adds the Decimal Character to the text box at the currently selected position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void DecimalButton_Click(object sender, EventArgs e)
        {

            //Inserts the value into the text box at the currently selected position
            InsertTextValue(".");
            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the 3 Character to the text box at the currently selected position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThreeButton_Click(object sender, EventArgs e)
        {
            //Inserts the value into the text box at the currently selected position
            InsertTextValue("3");
            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the 6 Character to the text box at the currently selected position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SixButton_Click(object sender, EventArgs e)
        {
            //Inserts the value into the text box at the currently selected position
            InsertTextValue("6");
            // Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Adds the 9 Character to the text box at the currently selected position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NineButton_Click(object sender, EventArgs e)
        {
            //Inserts the value into the text box at the currently selected position
            InsertTextValue("9");
            // Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Adds the 8 Character to the text box at the currently selected position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EightButton_Click(object sender, EventArgs e)
        {
            //Inserts the value into the text box at the currently selected position
            InsertTextValue("8");
            // Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Adds the 5 Character to the text box at the currently selected position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiveButton_Click(object sender, EventArgs e)
        {
            //Inserts the value into the text box at the currently selected position
            InsertTextValue("5");
            // Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Adds the 2 Character to the text box at the currently selected position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TwoButton_Click(object sender, EventArgs e)
        {
            //Inserts the value into the text box at the currently selected position
            InsertTextValue("2");
            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Adds the 0 Character to the text box at the currently selected position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            //Inserts the value into the text box at the currently selected position
            InsertTextValue("0");
            // Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Adds the 1 Character to the text box at the currently selected position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OneButton_Click(object sender, EventArgs e)
        {
            //Inserts the value into the text box at the currently selected position
            InsertTextValue("1");
            // Focus the user input text
            FocusInputText();

        }

        /// <summary>
        /// Adds the 4 Character to the text box at the currently selected position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourButton_Click(object sender, EventArgs e)
        {
            //Inserts the value into the text box at the currently selected position
            InsertTextValue("4");
            // Focus the user input text
            FocusInputText();
        }


        /// <summary>
        /// Adds the 7 Character to the text box at the currently selected position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SevenButton_Click(object sender, EventArgs e)
        {
            //Inserts the value into the text box at the currently selected position
            InsertTextValue("7");
            // Focus the user input text
            FocusInputText();
        }
        #endregion


        /// <summary>
        /// Calculates the given equation and outputs the answer to the user label
        /// </summary>
        private void CalculateEquation()
        {
            //Completes the arthmetic 
            // Focus the user input text

            this.CalculationResult.Text = ParseOperation();

            FocusInputText();
        }

        /// <summary>
        /// Parses the users input and completes an order of operations
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try
            {
                //Get the users equation input
                var input = this.UserInputText.Text;

                //Remove all spaces

                input = input.Replace(" ", "");

                // Create a new top level operation
                var operation = new Operation();
                var leftSide = true;


                // Loop through each character of the input 
                // starting from the left working to the right
               for (int i =0; i <input.Length; i++)
                {
                    // Check if the character is a number (same as writing a series of OR statements for each value) 
                    if ("0123456789.".Any(c => input[i] == c))
                    {
                        if (leftSide)
                            operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);

                        
                    }


                    //TODO: Handle order priority 
                    // 4 + 5 * 3
                    // it should calculate 5 * 3 first, then 4 + the result

                }




                return string.Empty;

            }
            catch (Exception ex)
            {
                return $"Invalid equation. {ex.Message}";
            }
        }
        /// <summary>
        /// Attempts to add a new character to the current number, checking for valid characters as it goes
        /// </summary>
        /// <param name="currentNumber">The current number string</param>
        /// <param name="newCharacter"></param>
        /// <returns></returns>
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            //check if there is already a . present
            if (newCharacter == '.' && currentNumber.Contains('.'))
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and cannot be added.");
            return currentNumber + newCharacter;
        }    

        #region Private Helpers


        /// <summary>
        /// Focusses the user input text
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }
        /// <summary>
        /// Inserts the given text into the user input text box
        /// </summary>
        /// <param name="v">value of button clicked</param>
        private void InsertTextValue(string v)


        {
            //used to remember the selection start value
            var selectionStart = this.UserInputText.SelectionStart;

            //set new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, v);

            //Restor the selection start
            this.UserInputText.SelectionStart = selectionStart + v.Length;

            //Set selection length to zero
            this.UserInputText.SelectionLength = 0;

        }

        /// <summary>
        /// Deletes the character to the right of the selection start of the user input text box
        /// </summary>
        /// <param name="v"></param>
        private void DeleteTextValue()


        {
            //If we dont have a value to delete, return
            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return;

            //used to remember the selection start value
            var selectionStart = this.UserInputText.SelectionStart;

          
            //sets the text box value equal to its original value minus 1 from the selection point
            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);

            //Restore the selection start
            this.UserInputText.SelectionStart = selectionStart;

            //Set selection length to zero
            this.UserInputText.SelectionLength = 0;

        }




        #endregion

    }
}
