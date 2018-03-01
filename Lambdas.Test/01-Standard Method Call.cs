using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//.NET 1.0
namespace Lambdas
{
	[TestClass]
	public class _01_Lambda
	{
		public int Add(int a, int b)
		{
			return a + b;
		}

		[TestMethod]
		public void Lambda01()
		{
			int res = Add(10, 20);

			Assert.AreEqual(30, res);
		}
	}
}
