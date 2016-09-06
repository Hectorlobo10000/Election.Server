using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace Elections.Server.Presentation.Validators
{
    public class Validate
    {
        public static int ValidateFields(Object content)
        {
            var count = 0;
            var grid = (Grid) content;
            for (var index = 0; index < 6; index++)
            {
                var border = (Border) grid.Children[index];
                var textBox = (TextBox) border.Child;

                if (string.IsNullOrEmpty(textBox.Text) || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.BorderBrush = new SolidColorBrush(color: Colors.Red);
                    count++;
                }
                else
                {
                    textBox.BorderBrush = new SolidColorBrush(color: Colors.SteelBlue);
                }
            }
            return count;
        }

        public static int ValidateCombo(Object content)
        {
            var count = 0;
            var grid = (Grid) content;
            for (var index = 6; index < 9; index++)
            {
                var border = (Border) grid.Children[index];
                var comboBox = (ComboBox) border.Child;
                if (comboBox.SelectedIndex == -1)
                {
                    comboBox.BorderBrush = new SolidColorBrush(color: Colors.Red);
                    count++;
                }
                else
                {
                    comboBox.BorderBrush = new SolidColorBrush(color: Colors.SteelBlue);
                }
            }
            return count;
        }
    }
}