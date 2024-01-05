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
        private readonly CalculatorNumberVo _numberVo;
        private decimal lastNumber;
        public MainWindow()
        {
            InitializeComponent();

            _numberVo = new CalculatorNumberVo();
        }

        /// <summary>
        /// Number Button을 클릭했을 작동하는 이벤트로서 resultLabel에 숫자를 표시함
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            decimal number = 0;
            Button numberButton = sender as Button;
            decimal selectedNumber = Convert.ToDecimal(numberButton.Content);

            if(decimal.TryParse((string)resultLabel.Content, out decimal result))
            {
                number = result * 10 + selectedNumber;
            }
            else
            {
                number = selectedNumber;
            }
            _numberVo.ResultNumber = number;
            resultLabel.Content = _numberVo.ToStringResult();
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e) 
        {
            if (sender == acButton)
            {
                _numberVo.ResultNumber = 0;
            }
            else if (sender == negtiveButton)
            {
                _numberVo.ResultNumber *= -1;
            }
            else if (sender == percentButton)
            {
                _numberVo.ResultNumber /= 100;
            }
            else if (sender == divideButton)
            {

            }
            else if (sender == multiplyButton)
            {

            }
            else if (sender == subtractButton)
            {

            }
            else if (sender == plusButton)
            {

            }
            else if (sender == equalButton)
            {

            }
            else if(sender == decimalButton)
            {

            }

            resultLabel.Content = _numberVo.ToStringResult();
        }
    }
}