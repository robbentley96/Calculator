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
	public partial class MainWindow : Window
	{
		//boolean to check if the first input is being typed (or second)
		bool firstInput = true;

		//booleans to check if a decimal point has been added to the first/second input (to prevent multiple points)
		bool firstInputDecimal = false;
		bool secondInputDecimal = false;

		string input1 = "";
		string input2 = "";
		string op = "";


		public MainWindow()
		{
			
			InitializeComponent();
		}

		private void ZeroButton_Click(object sender, RoutedEventArgs e)
		{
			if (firstInput)
			{
				input1 = CalculatorLib.writeInput(input1,"0");
				CalculatorReadout.Text = input1;
			}
			else
			{
				input2 = CalculatorLib.writeInput(input2, "0");
				CalculatorReadout.Text = input2;
			}
			
		}
		private void OneButton_Click(object sender, RoutedEventArgs e)
		{
			if (firstInput)
			{
				input1 = CalculatorLib.writeInput(input1, "1");
				CalculatorReadout.Text = input1;
			}
			else
			{
				input2 = CalculatorLib.writeInput(input2, "1");
				CalculatorReadout.Text = input2;
			}
		}

		private void TwoButton_Click(object sender, RoutedEventArgs e)
		{
			if (firstInput)
			{
				input1 = CalculatorLib.writeInput(input1, "2");
				CalculatorReadout.Text = input1;
			}
			else
			{
				input2 = CalculatorLib.writeInput(input2, "2");
				CalculatorReadout.Text = input2;
			}
		}

		private void ThreeButton_Click(object sender, RoutedEventArgs e)
		{
			if (firstInput)
			{
				input1 = CalculatorLib.writeInput(input1, "3");
				CalculatorReadout.Text = input1;
			}
			else
			{
				input2 = CalculatorLib.writeInput(input2, "3");
				CalculatorReadout.Text = input2;
			}
		}

		private void FourButton_Click(object sender, RoutedEventArgs e)
		{
			if (firstInput)
			{
				input1 = CalculatorLib.writeInput(input1, "4");
				CalculatorReadout.Text = input1;
			}
			else
			{
				input2 = CalculatorLib.writeInput(input2, "4");
				CalculatorReadout.Text = input2;
			}
		}

		private void FiveButton_Click(object sender, RoutedEventArgs e)
		{
			if (firstInput)
			{
				input1 = CalculatorLib.writeInput(input1, "5");
				CalculatorReadout.Text = input1;
			}
			else
			{
				input2 = CalculatorLib.writeInput(input2, "5");
				CalculatorReadout.Text = input2;
			}
		}

		private void SixButton_Click(object sender, RoutedEventArgs e)
		{
			if (firstInput)
			{
				input1 = CalculatorLib.writeInput(input1, "6");
				CalculatorReadout.Text = input1;
			}
			else
			{
				input2 = CalculatorLib.writeInput(input2, "6");
				CalculatorReadout.Text = input2;
			}
		}

		private void SevenButton_Click(object sender, RoutedEventArgs e)
		{
			if (firstInput)
			{
				input1 = CalculatorLib.writeInput(input1, "7");
				CalculatorReadout.Text = input1;
			}
			else
			{
				input2 = CalculatorLib.writeInput(input2, "7");
				CalculatorReadout.Text = input2;
			}
		}

		private void EightButton_Click(object sender, RoutedEventArgs e)
		{
			if (firstInput)
			{
				input1 = CalculatorLib.writeInput(input1, "8");
				CalculatorReadout.Text = input1;
			}
			else
			{
				input2 = CalculatorLib.writeInput(input2, "8");
				CalculatorReadout.Text = input2;
			}
		}

		private void NineButton_Click(object sender, RoutedEventArgs e)
		{
			if (firstInput)
			{
				input1 = CalculatorLib.writeInput(input1, "9");
				CalculatorReadout.Text = input1;
			}
			else
			{
				input2 = CalculatorLib.writeInput(input2, "9");
				CalculatorReadout.Text = input2;
			}
		}

		private void EqualsButton_Click(object sender, RoutedEventArgs e)
		{
			if (!firstInput)
			{
				try
				{
					CalculatorReadout.Text = CalculatorLib.Calculate(input1, input2, op);
				}
				catch (DivideByZeroException ex)
				{
					CalculatorReadout.FontSize = 36;
					CalculatorReadout.Text = ex.Message;
				}
				catch (Exception)
				{
					CalculatorReadout.Text = "Error";
				}


				
			}
		}

		private void AddButton_Click(object sender, RoutedEventArgs e)
		{
			if (firstInput)
			{
				op = "+";
				firstInput = false;
				CalculatorReadout.Text = op;
			}
		}

		private void SubtractButton_Click(object sender, RoutedEventArgs e)
		{
			if (firstInput)
			{
				op = "-";
				firstInput = false;
				CalculatorReadout.Text = op;
			}
		}

		private void MultiplyButton_Click(object sender, RoutedEventArgs e)
		{
			if (firstInput)
			{
				op = "*";
				firstInput = false;
				CalculatorReadout.Text = op;
			}
		}

		private void DivideButton_Click(object sender, RoutedEventArgs e)
		{
			if (firstInput)
			{
				op = "/";
				firstInput = false;
				CalculatorReadout.Text = op;
			}
		}

		private void ClearButton_Click(object sender, RoutedEventArgs e)
		{
			firstInput = true;
			input1 = "";
			input2 = "";
			op = "";
			CalculatorReadout.Text = "";
			CalculatorReadout.FontSize = 72;
			firstInputDecimal = false;
			secondInputDecimal = false;

		}

		private void DecimalButton_Click(object sender, RoutedEventArgs e)
		{
			if (firstInput)
			{
				if (!firstInputDecimal)
				{
					input1 = CalculatorLib.writeInput(input1, ".");
					CalculatorReadout.Text = input1;
					firstInputDecimal = true;
				}
			}
			else
			{
				if (!secondInputDecimal)
				{
					input2 = CalculatorLib.writeInput(input2, ".");
					CalculatorReadout.Text = input2;
					secondInputDecimal = true;
				}
			}
		}
	}
}
