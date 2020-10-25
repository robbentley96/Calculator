using NUnit.Framework;
using CalculatorProject;
using System;

namespace CalculatorTest
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[TestCase(6,2, 8)]
		[TestCase(0, 20, 20)]
		[TestCase(61, -6, 55)]

		public void CalculatorAddTest(float input1, float input2, float expected)
		{
			float result = CalculatorLib.Add(input1, input2);
			Assert.AreEqual(expected, result);
		}

		[TestCase(6, 2, 4)]
		[TestCase(0, 20, -20)]
		[TestCase(61, -6, 67)]

		public void CalculatorSubtractTest(float input1, float input2, float expected)
		{
			float result = CalculatorLib.Subtract(input1, input2);
			Assert.AreEqual(expected, result);
		}

		[TestCase(6, 2, 12)]
		[TestCase(0, 20, 0)]
		[TestCase(61, -6, -366)]

		public void CalculatorMultiplyTest(float input1, float input2, float expected)
		{
			float result = CalculatorLib.Multiply(input1, input2);
			Assert.AreEqual(expected, result);
		}

		[TestCase(6, 2, 3)]
		[TestCase(0, 20, 0)]
		[TestCase(60, -6, -10)]

		public void CalculatorDivideTest(float input1, float input2, float expected)
		{
			float result = CalculatorLib.Divide(input1, input2);
			Assert.AreEqual(expected, result);
		}

		[TestCase(20, 0)]
		public void CalculatorDivideByZeroTest(float input1, float input2)
		{
			Assert.Throws<DivideByZeroException>(() => CalculatorLib.Divide(input1,input2));
		}
	}
}