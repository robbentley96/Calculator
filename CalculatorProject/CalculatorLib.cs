using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProject
{
	public class CalculatorLib
	{
		

		public static string writeInput(string num, string digit)
		{
			return num += digit;
		}

		public static float Add(float var1, float var2)
		{
			return var1 + var2;
		}

		public static float Subtract(float var1, float var2)
		{
			return var1 - var2;
		}

		public static float Multiply(float var1, float var2)
		{
			return var1 * var2;
		}

		public static float Divide(float var1, float var2)
		{
			if (var2 == 0)
			{
				throw new DivideByZeroException("Cannot divide by zero");
			}
			return var1 / var2;
		}

		

		public static string Calculate(string var1, string var2, string op)
		{
			if (op == "+")
			{
				return Add(float.Parse(var1), float.Parse(var2)).ToString();
			}

			else if (op == "-")
			{
				return Subtract(float.Parse(var1), float.Parse(var2)).ToString();
			}

			else if (op == "*")
			{
				return Multiply(float.Parse(var1), float.Parse(var2)).ToString();
			}

			else if (op == "/")
			{
				return Divide(float.Parse(var1), float.Parse(var2)).ToString();
			}

			else return "Error";
		}
	}
}
