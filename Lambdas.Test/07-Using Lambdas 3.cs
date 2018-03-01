using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//.NET 3.0
namespace Lambdas
{
	[TestClass]
	public class _07_Lambda
	{
		[TestMethod]
		public void Lambda07()
		{
			Func<int> myAdd = () => 30; 
			
			int res = myAdd();

			Assert.AreEqual(30, res);
		}
	}
}
