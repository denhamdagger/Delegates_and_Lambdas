using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//.NET 2.0
namespace Lambdas
{
	[TestClass]
	public class _03_Lambda
	{
		public int Add(int a, int b)
		{
			return a + b;
		}

		[TestMethod]
		public void Lambda03()
		{
			Func<int, int, int> myAdd = Add;
			
			int res = myAdd(10, 20);

			Assert.AreEqual(30, res);
		}
	}
}
