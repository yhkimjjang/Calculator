using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private decimal lastNumber;
        private SelectedOperator selectedOperator;

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Number Button을 클릭했을 작동하는 이벤트로서 resultLabel에 숫자를 표시함
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button numberButton = sender as Button;
            decimal selectedValue = Convert.ToDecimal(numberButton.Content);

            if(resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = $"{selectedValue}";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{selectedValue}";
            }
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e) 
        {
            if (sender == plusButton) selectedOperator = SelectedOperator.Addition;
            if(sender == subtractButton) selectedOperator = SelectedOperator.Subtraction;
            if(sender == multiplyButton) selectedOperator = SelectedOperator.Multiplication;
            if(sender == divideButton) selectedOperator = SelectedOperator.Division;
        }
    }

    public enum SelectedOperator
    {
        Addition,
        Subtraction, 
        Multiplication, 
        Division,
    }

    public class SimpleMath
    {
        public static decimal Add(decimal n1, decimal n2)
        {
            return n1 + n2;
        }

        public static decimal Subtract(decimal n1, decimal n2) 
        { 
            return n1 - n2;
        }

        public static decimal Multiply(decimal n1, decimal n2)
        {
            return n1 * n2;
        }

        public static decimal Divide(decimal n1, decimal n2)
        {
            return n1 / n2;
        }
    }
}