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

            acButton.Click += AcButton_Click;
            negtiveButton.Click += NegtiveButton_Click;
            percentButton.Click += PercentButton_Click;
        }

        private void PercentButton_Click(object sender, RoutedEventArgs e)
        {
            if(decimal.TryParse((string)resultLabel.Content, out lastNumber))
            {
                _numberVo.LastNumber /= 100;
                resultLabel.Content = $"{_numberVo.ToStringResult()}";
            }
        }

        private void NegtiveButton_Click(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse((string)resultLabel.Content, out lastNumber))
            {
                _numberVo.LastNumber *= -1;
                resultLabel.Content = $"{_numberVo.ToStringResult()}";
            }
        }

        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            _numberVo.LastNumber = 0;
            resultLabel.Content = $"{_numberVo.ToStringResult()}";
        }

        /// <summary>
        /// 7번 클릭했을 때 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void number7Button_Click(object sender, RoutedEventArgs e)
        {
            if(decimal.TryParse((string)resultLabel.Content, out decimal result))
            {
                _numberVo.LastNumber = result * 10 + 7;
            }
            else
            {
                _numberVo.LastNumber = 7;
            }

            resultLabel.Content = $"{_numberVo.ToStringResult()}";
        }
    }
}