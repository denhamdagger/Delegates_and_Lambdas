using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//.NET 1.0
namespace Lambdas
{
	[TestClass]
	public class _02_Lambda
	{
		delegate int myDele(int x, int y);

		public int Add(int a, int b)
		{
			return a + b;
		}

		[TestMethod]
		public void Lambda02()
		{
			myDele myAdd = new myDele(Add); // could also write myDele myAdd = Add;
			
			int res = myAdd(10, 20);

			Assert.AreEqual(30, res);
		}
	}
}
