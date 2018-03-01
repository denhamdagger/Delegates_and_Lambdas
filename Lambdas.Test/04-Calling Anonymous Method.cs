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
	public class _04_Lambda
	{
		[TestMethod]
		public void Lambda04()
		{
			Func<int, int, int> myAdd = delegate(int aa, int bb) 
			{
				return aa + bb; 
			};
			
			int res = myAdd(10, 20);

			Assert.AreEqual(30, res);
		}
	}
}
