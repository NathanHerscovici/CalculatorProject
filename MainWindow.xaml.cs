using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    enum Operand
    {
        OPERAND_add,
        OPERAND_subtract,
        OPERAND_multiply,
        OPERAND_divide
    }

    public partial class MainWindow : Window
    {
        private int firstNum = 0;
        int secondNum = 0;
        int operation = 0;
        bool isOperand = false;
        bool isEquals = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        public int setMainScreen
        {
            get => Convert.ToInt32(mainScreen.Text);
            set
            {
                mainScreen.Text = value.ToString();
            }

        }

        public void updateScreen(int num)
        {
            if (isEquals)
            {
                setMainScreen = num;
                isEquals = false;
            }

            else if (isOperand)
            {
                setMainScreen = 0;
                setMainScreen = num;
                isOperand = false;
            }
            else
            {
                int number = setMainScreen;
                setMainScreen = ((number * 10) + num);
            }
        }

        public void setOperation(int operand)
        {
            operation = operand;
            firstNum = setMainScreen;
            isOperand = true;
        }

        public void doTheMath()
        {
            secondNum = setMainScreen;

            if (operation == (int)Operand.OPERAND_add)
                setMainScreen = firstNum + secondNum;
            else if (operation == (int)Operand.OPERAND_subtract)
                setMainScreen = firstNum - secondNum;
            else if (operation == (int)Operand.OPERAND_multiply)
                setMainScreen = firstNum * secondNum;
            else if (operation == (int)Operand.OPERAND_divide)
                setMainScreen = firstNum / secondNum;
            isEquals = true;
        }

        private void oneButton_Click(object sender, RoutedEventArgs e)
        {
            updateScreen(1);
        }

        private void twoButton_Click_1(object sender, RoutedEventArgs e)
        {
            updateScreen(2);
        }

        private void threeButton_Click(object sender, RoutedEventArgs e)
        {
            updateScreen(3);
        }

        private void fourButton_Click(object sender, RoutedEventArgs e)
        {
            updateScreen(4);
        }

        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {
            updateScreen(5);
        }

        private void sixButton_Click(object sender, RoutedEventArgs e)
        {
            updateScreen(6);
        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            updateScreen(7);
        }

        private void eightButton_Click(object sender, RoutedEventArgs e)
        {
            updateScreen(8);
        }

        private void nineButton_Click(object sender, RoutedEventArgs e)
        {
            updateScreen(9);
        }

        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {
            updateScreen(0);
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            setMainScreen = 0;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            setOperation(0);
        }

        private void subtractButton_Click(object sender, RoutedEventArgs e)
        {
            setOperation(1);
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            setOperation(2);
        }

        private void divideButton_Click(object sender, RoutedEventArgs e)
        {
            setOperation(3);
        }

        private void equalsButton_Click(object sender, RoutedEventArgs e)
        {
            doTheMath();
        }
    }
}
