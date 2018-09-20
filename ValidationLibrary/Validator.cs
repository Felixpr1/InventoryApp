using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ValidationLibrary
{
    public static class Validator
    {
        // The title of the error message box with its default value.
        public static string Title { get; set; } = "Entry Error";
        
        // Determines whether the given textbox contains data.
        public static bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == string.Empty)
            {
                MessageBox.Show(name + " is required.", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
            return true;
        }

        // Determines whether the given textbox contains a string that matches the
        // given pattern (a regurlar expression).
        public static bool MatchesPattern(TextBox textBox, string name, string pattern)
        {
            if (!Regex.IsMatch(textBox.Text, pattern))
            {
                MessageBox.Show(name + " has an invalid format.", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
            return true;
        }

        // Determines whether the given textbox contains a valid integer.
        public static bool IsInt32(TextBox textBox, string name)
        {
            int value;
            if (!int.TryParse(textBox.Text, out value))
            {
                MessageBox.Show(name + " should be an integer.", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
            return true;
        }

        // Determines whether the given textbox contains a valid decimal.
        public static bool IsDecimal(TextBox textBox, string name)
        {
            decimal value;
            if (!decimal.TryParse(textBox.Text, out value))
            {
                MessageBox.Show(name + " should be a decimal.", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
            return true;
        }

        // Determines whether the given textbox contains a decimal within the given range.
        public static bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal value = decimal.Parse(textBox.Text);
            if (value < min || value > max)
            {
                MessageBox.Show(name + " should be between " +
                    min + " and " + max + ".", Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}
