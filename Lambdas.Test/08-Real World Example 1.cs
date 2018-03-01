using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lambdas
{
	[TestClass]
	public class _08_Lambda
	{
		class Person
		{
			public string FirstName { get; set; }
			public string LastName { get; set; }
			public int Age { get; set; }

			public override string ToString()
			{
				return string.Format("{0} {1}, aged {2}", FirstName, LastName, Age);
			}
		}

		[TestMethod]
		public void Lambda08()
		{
			List<Person> people = new List<Person>() {
				new Person{FirstName = "Steve", LastName = "Bloggs", Age = 46},
				new Person{FirstName = "Holly", LastName = "Silver", Age = 8},
				new Person{FirstName = "Chloe", LastName = "Gold", Age = 6},
				new Person{FirstName = "Alan",  LastName = "Python", Age = 45}
			};

			Console.WriteLine("\nUnsorted");
			foreach (Person p in people)
				Console.WriteLine(p);

			people.Sort( (p1, p2) => p1.FirstName.CompareTo(p2.FirstName) );

			Console.WriteLine("\nSorted");
			foreach (Person p in people)
				Console.WriteLine(p);
		}
	}
}
