﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//.NET 3.0
namespace Lambdas
{
	[TestClass]
	public class _05_Lambda
	{
		[TestMethod]
		public void Lambda05()
		{
			Func<int, int, int> myAdd = (aa, bb) => { return aa + bb; }; 
			
			int res = myAdd(10, 20);

			Assert.AreEqual(30, res);
		}
	}
}
